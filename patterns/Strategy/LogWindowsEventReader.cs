using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Strategy
{
    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    class LogWindowsEventReaderStrategy : ILogReader
    {
        public List<LogEntry> Read()
        {
            Console.WriteLine("Read from windows events");
            return new List<LogEntry>();
        }
    }
}
