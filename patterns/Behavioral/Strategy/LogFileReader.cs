using System;
using System.Collections.Generic;

namespace patterns.Behavioral.Strategy
{
    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    class LogFileReaderStrategy : ILogReader
    {
        public List<LogEntry> Read()
        {
            Console.WriteLine("Read From file");
            return new List<LogEntry>();
        }
    }
}
