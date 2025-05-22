using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadersWritersProblem
{
    internal class Writer : DatabaseClient
    {
        private readonly int _id;
        private readonly int _minThinkingTime;
        private readonly int _maxThinkingTime;
        private readonly int _minWritingTime;
        private readonly int _maxWritingTime;

        public Writer(int id, int minThinkingTime, int maxThinkingTime,
                     int minWritingTime, int maxWritingTime, Random random,
                     Logger logger, SimulationStatistics statistics, SimulationManager manager)
            : base($"Writer {id}", random, logger, statistics, manager)
        {
            _id = id;
            _minThinkingTime = minThinkingTime;
            _maxThinkingTime = maxThinkingTime;
            _minWritingTime = minWritingTime;
            _maxWritingTime = maxWritingTime;
        }

        protected override int GetMinThinkingTime() => _minThinkingTime;
        protected override int GetMaxThinkingTime() => _maxThinkingTime;

        public override void Process()
        {
            while (!Manager.ShouldStop)
            {
                try
                {
                    Thread.Sleep(Random.Next(GetMinThinkingTime(), GetMaxThinkingTime() + 1));

                    if (Manager.ShouldStop) break;

                    DateTime requestTime = DateTime.Now;

                    Manager.AddToClientQueue(Name);
                    Logger.AddStatus($"{Name} is waiting in queue");

                    int currentQueueLength = Manager.ClientQueueCount;
                    Statistics.UpdateQueueStatistics(currentQueueLength);

                    Thread.Sleep(50);

                    if (Manager.ShouldStop) break;

                    // Процедура входу для письменника з таймаутами
                    bool readerLockAcquired = false;
                    bool writerLockAcquired = false;

                    try
                    {
                        readerLockAcquired = Manager.ReadersExistSemaphore.WaitOne(5000);

                        if (!readerLockAcquired)
                        {
                            Logger.AddStatus($"{Name} timed out waiting for readers");
                            // Видаляємося з черги при таймауті
                            Manager.RemoveFromClientQueue(Name);
                            continue;
                        }

                        if (Manager.ShouldStop)
                        {
                            Manager.ReadersExistSemaphore.Release();
                            // Видаляємося з черги при зупинці
                            Manager.RemoveFromClientQueue(Name);
                            break;
                        }

                        writerLockAcquired = Manager.WriterSemaphore.WaitOne(5000);

                        if (!writerLockAcquired)
                        {
                            Logger.AddStatus($"{Name} timed out waiting for writer lock");
                            Manager.ReadersExistSemaphore.Release();
                            // Видаляємося з черги при таймауті
                            Manager.RemoveFromClientQueue(Name);
                            continue;
                        }

                        if (Manager.ShouldStop)
                        {
                            Manager.WriterSemaphore.Release();
                            Manager.ReadersExistSemaphore.Release();
                            // Видаляємося з черги при зупинці
                            Manager.RemoveFromClientQueue(Name);
                            break;
                        }

                        Manager.SetWriterActive(true);

                        Manager.RemoveFromClientQueue(Name);

                        Manager.AddActiveProcess(Name);

                        double waitTime = (DateTime.Now - requestTime).TotalSeconds;
                        Statistics.WriterWaitTimes.Enqueue(waitTime);

                        DateTime startServiceTime = DateTime.Now;

                        Logger.AddStatus($"{Name} is accessing the database");
                        // Використання змінного часу запису замість фіксованого
                        Thread.Sleep(Random.Next(_minWritingTime, _maxWritingTime + 1));

                        if (Manager.ShouldStop) break;

                        double serviceTime = (DateTime.Now - startServiceTime).TotalSeconds;
                        Statistics.WriterServiceTimes.Enqueue(serviceTime);

                        Manager.SetWriterActive(false);

                        Manager.RemoveActiveProcess(Name);

                        Manager.WriterSemaphore.Release();
                        writerLockAcquired = false;

                        Manager.ReadersExistSemaphore.Release();
                        readerLockAcquired = false;

                        Statistics.IncrementWritersServed();

                        Logger.AddStatus($"{Name} has finished writing");
                    }
                    catch (Exception ex)
                    {
                        Logger.AddStatus($"Error in {Name} critical section: {ex.Message}");

                        // Видаляємося з черги при помилці
                        Manager.RemoveFromClientQueue(Name);

                        if (writerLockAcquired) Manager.WriterSemaphore.Release();
                        if (readerLockAcquired) Manager.ReadersExistSemaphore.Release();
                    }
                }
                catch (Exception ex)
                {
                    Logger.AddStatus($"Error in {Name}: {ex.Message}");
                    // Видаляємося з черги при помилці в зовнішньому блоці
                    Manager.RemoveFromClientQueue(Name);
                }
            }
        }
    }
}