using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadersWritersProblem
{
    internal class SimulationManager : IDisposable
    {
        public Semaphore WriterSemaphore { get; private set; }
        public SemaphoreSlim ReaderCountSemaphore { get; private set; }
        public Semaphore ReadersExistSemaphore { get; private set; }

        private int _readersCount = 0;
        private bool _writerActive = false;
        public int ReadersCount => _readersCount;
        public bool WriterActive => _writerActive;

        public bool ShouldStop { get; private set; } = false;

        private ConcurrentQueue<string> _clientQueue = new ConcurrentQueue<string>();
        private ConcurrentBag<string> _activeProcesses = new ConcurrentBag<string>();

        private Logger _logger;
        private SimulationStatistics _statistics;
        private Random _random = new Random();

        private List<Thread> _activeThreads = new List<Thread>();
        private readonly object _threadLock = new object();

        public SimulationManager(Logger logger, SimulationStatistics statistics)
        {
            _logger = logger;
            _statistics = statistics;

            WriterSemaphore = new Semaphore(1, 1); 
            ReaderCountSemaphore = new SemaphoreSlim(1, 1); 
            ReadersExistSemaphore = new Semaphore(1, 1); 
        }

        public int ClientQueueCount => _clientQueue.Count;
        public IEnumerable<string> ClientQueue => _clientQueue.ToArray();
        public IEnumerable<string> ActiveProcesses => _activeProcesses.ToArray();

        public void AddActiveProcess(string process)
        {
            _activeProcesses.Add(process);
        }

        public void RemoveActiveProcess(string process)
        {
            var updatedActiveProcesses = new ConcurrentBag<string>();
            foreach (var p in _activeProcesses.Where(p => p != process))
            {
                updatedActiveProcesses.Add(p);
            }
            _activeProcesses = updatedActiveProcesses;
        }

        public void AddToClientQueue(string client)
        {
            _clientQueue.Enqueue(client);
        }

        public void RemoveFromClientQueue(string clientToRemove)
        {
            var tempQueue = new ConcurrentQueue<string>();
          
            string dequeuedClient;
            while (_clientQueue.TryDequeue(out dequeuedClient))
            {
                if (dequeuedClient != clientToRemove)
                {
                    tempQueue.Enqueue(dequeuedClient);
                }
            }
 
            _clientQueue = tempQueue;
        }

        public void IncrementReadersCount()
        {
            Interlocked.Increment(ref _readersCount);
        }

        public void DecrementReadersCount()
        {
            Interlocked.Decrement(ref _readersCount);
        }

        public void SetWriterActive(bool active)
        {
            _writerActive = active;
        }

        public void StartSimulation(int numReaders, int numWriters,
                             int minReaderThinkingTime, int maxReaderThinkingTime,
                             int minWriterThinkingTime, int maxWriterThinkingTime,
                             int minReadingTime, int maxReadingTime,
                             int minWritingTime, int maxWritingTime)
        {
            ShouldStop = false;

            _readersCount = 0;
            _writerActive = false;
            _statistics.Reset();
            _clientQueue = new ConcurrentQueue<string>();
            _activeProcesses = new ConcurrentBag<string>();

            _logger.AddStatus("Starting new simulation...");

            List<Thread> readers = new List<Thread>();
            List<Thread> writers = new List<Thread>();

            for (int i = 0; i < numReaders; i++)
            {
                var reader = new Reader(i + 1, minReaderThinkingTime, maxReaderThinkingTime,
                                       minReadingTime, maxReadingTime, _random, _logger, _statistics, this);
                Thread readerThread = new Thread(new ThreadStart(reader.Process));
                readerThread.Priority = ThreadPriority.AboveNormal;
                readers.Add(readerThread);
            }

            for (int i = 0; i < numWriters; i++)
            {
                var writer = new Writer(i + 1, minWriterThinkingTime, maxWriterThinkingTime,
                                       minWritingTime, maxWritingTime, _random, _logger, _statistics, this);
                Thread writerThread = new Thread(new ThreadStart(writer.Process));
                writerThread.Priority = ThreadPriority.Normal;
                writers.Add(writerThread);
            }

            for (int i = 0; i < Math.Min(3, numReaders); i++)
            {
                readers[i].Start();
                lock (_threadLock)
                {
                    _activeThreads.Add(readers[i]);
                }
                Thread.Sleep(50); 
            }

            for (int i = 0; i < Math.Min(2, numWriters); i++)
            {
                writers[i].Start();
                lock (_threadLock)
                {
                    _activeThreads.Add(writers[i]);
                }
                Thread.Sleep(100);
            }

            for (int i = Math.Min(3, numReaders); i < numReaders; i++)
            {
                readers[i].Start();
                lock (_threadLock)
                {
                    _activeThreads.Add(readers[i]);
                }
                Thread.Sleep(20);

                if (i < numWriters)
                {
                    writers[i].Start();
                    lock (_threadLock)
                    {
                        _activeThreads.Add(writers[i]);
                    }
                    Thread.Sleep(20);
                }
            }

            for (int i = Math.Min(numReaders, numWriters); i < numWriters; i++)
            {
                writers[i].Start();
                lock (_threadLock)
                {
                    _activeThreads.Add(writers[i]);
                }
                Thread.Sleep(20);
            }
        }

        public void StopSimulation()
        {
    
            ShouldStop = true;
            _logger.AddStatus("Stopping simulation, please wait...");

      
            try
            {
                ReadersExistSemaphore.Release();
                WriterSemaphore.Release();
            }
            catch
            {
               
            }

           
            lock (_threadLock)
            {
                foreach (Thread thread in _activeThreads)
                {
                    if (thread.IsAlive)
                        thread.Join(500); 
                }
                _activeThreads.Clear();
            }

          
            _clientQueue = new ConcurrentQueue<string>();
            _activeProcesses = new ConcurrentBag<string>();

            _logger.AddStatus("Simulation stopped.");
        }

        public void Dispose()
        {
          
            ShouldStop = true;

            try
            {
               
                try
                {
                    ReadersExistSemaphore.Release();
                    WriterSemaphore.Release();
                }
                catch
                {
                 
                }

               
                Task.Run(() => {
                    foreach (Thread thread in _activeThreads)
                    {
                        if (thread.IsAlive)
                            thread.Join(100); 
                    }

                 
                    WriterSemaphore.Close();
                    ReaderCountSemaphore.Dispose();
                    ReadersExistSemaphore.Close();
                });
            }
            catch
            {
               
            }
        }
    }
}
