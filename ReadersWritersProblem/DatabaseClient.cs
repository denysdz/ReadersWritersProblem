using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadersWritersProblem
{
    internal abstract class DatabaseClient
    {
        protected readonly string Name;
        protected readonly Random Random;
        protected readonly Logger Logger;
        protected readonly SimulationStatistics Statistics;
        protected readonly SimulationManager Manager;

        public DatabaseClient(string name, Random random, Logger logger,
                              SimulationStatistics statistics, SimulationManager manager)
        {
            Name = name;
            Random = random;
            Logger = logger;
            Statistics = statistics;
            Manager = manager;
        }

        public abstract void Process();
        protected abstract int GetMinThinkingTime();
        protected abstract int GetMaxThinkingTime();
    }
}
