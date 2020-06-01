using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structural.Decorator
{
    class ElasticLogSaver : ILogSaver
    {
        /// <summary>
        /// Concrete Component
        /// </summary>
        /// <remarks>Конкретная реализация компонента</remarks>
        /// <param name="appId"></param>
        /// <param name="logEntry"></param>
        /// <returns></returns>
        public Task SaveLogEntry(string appId, LogEntry logEntry)
        {
            Console.WriteLine($"app id{appId} , log entry message {logEntry.Message}");
            return Task.FromResult<object>(null);
        }
    }
}
