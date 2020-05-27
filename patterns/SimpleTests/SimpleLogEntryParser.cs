using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.SimpleTests
{
    public class SimpleLogEntryParser : ILogEntryParser
    {
        public bool TryParse(string s, out LogEntry logEntry)
        {
            logEntry = new LogEntry()
            {
                Date = DateTime.Now.Date,
                Message = "SimpleLogEntry",
                Severity = 1
            };
            return true;
        }
    }
}
