using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ReadersWritersProblem;

namespace ReadersWritersProblem
{
    internal class SimulationStatistics
    {
        private int _totalReadersServed = 0;
        private int _totalWritersServed = 0;
        private int _maxQueueLength = 0;
        private long _totalQueueLength = 0;
        private int _queueLengthMeasurements = 0;

        public int TotalReadersServed => _totalReadersServed;
        public int TotalWritersServed => _totalWritersServed;
        public int MaxQueueLength => _maxQueueLength;
        public long TotalQueueLength => _totalQueueLength;
        public int QueueLengthMeasurements => _queueLengthMeasurements;

        public ConcurrentQueue<int> QueueLengthHistory { get; } = new ConcurrentQueue<int>();
        public ConcurrentQueue<double> ReaderWaitTimes { get; } = new ConcurrentQueue<double>();
        public ConcurrentQueue<double> WriterWaitTimes { get; } = new ConcurrentQueue<double>();
        public ConcurrentQueue<double> ReaderServiceTimes { get; } = new ConcurrentQueue<double>();
        public ConcurrentQueue<double> WriterServiceTimes { get; } = new ConcurrentQueue<double>();

        public void Reset()
        {
            _totalReadersServed = 0;
            _totalWritersServed = 0;
            _maxQueueLength = 0;
            _totalQueueLength = 0;
            _queueLengthMeasurements = 0;

            int dummyInt;
            double dummyDouble;

            while (QueueLengthHistory.TryDequeue(out dummyInt)) { }

            while (ReaderWaitTimes.TryDequeue(out dummyDouble)) { }

            while (WriterWaitTimes.TryDequeue(out dummyDouble)) { }
           
            while (ReaderServiceTimes.TryDequeue(out dummyDouble)) { }
           
            while (WriterServiceTimes.TryDequeue(out dummyDouble)) { }
        }

        public void IncrementReadersServed()
        {
            Interlocked.Increment(ref _totalReadersServed);
        }

        public void IncrementWritersServed()
        {
            Interlocked.Increment(ref _totalWritersServed);
        }

        public void UpdateQueueStatistics(int currentQueueLength)
        {
            QueueLengthHistory.Enqueue(currentQueueLength);
            Interlocked.Increment(ref _queueLengthMeasurements);

            int currentMax = _maxQueueLength;
            while (currentQueueLength > currentMax)
            {
                int newMax = Interlocked.CompareExchange(ref _maxQueueLength, currentQueueLength, currentMax);
                if (newMax == currentMax) break;
                currentMax = newMax;
            }

            Interlocked.Add(ref _totalQueueLength, currentQueueLength);
        }

        public double GetAverageQueueLength()
        {
            return QueueLengthMeasurements > 0 ? (double)TotalQueueLength / QueueLengthMeasurements : 0;
        }

        public double GetAverageReaderWaitTime()
        {
            var times = ReaderWaitTimes.ToArray();
            return times.Length > 0 ? times.Average() : 0;
        }

        public double GetAverageWriterWaitTime()
        {
            var times = WriterWaitTimes.ToArray();
            return times.Length > 0 ? times.Average() : 0;
        }

        public double GetAverageReaderServiceTime()
        {
            var times = ReaderServiceTimes.ToArray();
            return times.Length > 0 ? times.Average() : 0;
        }

        public double GetAverageWriterServiceTime()
        {
            var times = WriterServiceTimes.ToArray();
            return times.Length > 0 ? times.Average() : 0;
        }
    }

}


