using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadersWritersProblem
{
    internal class Logger
    {
        private ConcurrentQueue<string> _statusLogQueue = new ConcurrentQueue<string>();

        public void AddStatus(string status)
        {
            string timestampedStatus = DateTime.Now.ToString("HH:mm:ss.fff") + ": " + status;
            _statusLogQueue.Enqueue(timestampedStatus);
        }

        public string[] GetLatestLogs(int maxCount)
        {
            StringBuilder statusesToShow = new StringBuilder();
            int logCount = 0;
            string statusText;
            string[] result = new string[maxCount];

            while (_statusLogQueue.TryDequeue(out statusText) && logCount < maxCount)
            {
                result[logCount] = statusText;
                logCount++;
            }

            if (logCount < maxCount)
            {
                Array.Resize(ref result, logCount);
            }

            return result;
        }
    }
}
