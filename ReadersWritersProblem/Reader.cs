using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadersWritersProblem
{
    internal class Reader : DatabaseClient
    {
        private readonly int _id;
        private readonly int _minThinkingTime;
        private readonly int _maxThinkingTime;
        private readonly int _minReadingTime;
        private readonly int _maxReadingTime;

        public Reader(int id, int minThinkingTime, int maxThinkingTime,
                     int minReadingTime, int maxReadingTime, Random random,
                     Logger logger, SimulationStatistics statistics, SimulationManager manager)
            : base($"Reader {id}", random, logger, statistics, manager)
        {
            _id = id;
            _minThinkingTime = minThinkingTime;
            _maxThinkingTime = maxThinkingTime;
            _minReadingTime = minReadingTime;
            _maxReadingTime = maxReadingTime;
        }

        protected override int GetMinThinkingTime() => _minThinkingTime;
        protected override int GetMaxThinkingTime() => _maxThinkingTime;

        public override void Process()
        {
            while (!Manager.ShouldStop)
            {
                try
                {
                    // Thinking time (час обдумування/генерації)
                    Thread.Sleep(Random.Next(GetMinThinkingTime(), GetMaxThinkingTime() + 1));
                    if (Manager.ShouldStop) break;

                    DateTime requestTime = DateTime.Now;
                    Logger.AddStatus($"{Name} is requesting database access");
                    Manager.ReaderCountSemaphore.Wait(5000);
                    if (Manager.ShouldStop) break;
                    Manager.IncrementReadersCount();
                    Manager.AddActiveProcess(Name);
                    if (Manager.ReadersCount == 1)
                    {
                        Manager.ReadersExistSemaphore.WaitOne(5000);
                    }
                    Manager.ReaderCountSemaphore.Release();
                    double waitTime = (DateTime.Now - requestTime).TotalSeconds;
                    Statistics.ReaderWaitTimes.Enqueue(waitTime);

                    DateTime startServiceTime = DateTime.Now;
                    Logger.AddStatus($"{Name} is accessing the database");

                    // Час читання (час обслуговування)
                    Thread.Sleep(Random.Next(_minReadingTime, _maxReadingTime + 1));
                    if (Manager.ShouldStop) break;

                    double serviceTime = (DateTime.Now - startServiceTime).TotalSeconds;
                    Statistics.ReaderServiceTimes.Enqueue(serviceTime);

                    Manager.ReaderCountSemaphore.Wait(5000);
                    if (Manager.ShouldStop) break;
                    Manager.RemoveActiveProcess(Name);
                    Manager.DecrementReadersCount();
                    if (Manager.ReadersCount == 0)
                    {
                        Manager.ReadersExistSemaphore.Release();
                    }
                    Manager.ReaderCountSemaphore.Release();
                    Statistics.IncrementReadersServed();
                    Logger.AddStatus($"{Name} has finished reading");
                }
                catch (Exception ex)
                {
                    Logger.AddStatus($"Error in {Name}: {ex.Message}");
                }
            }
        }
    }
}