using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.SimpleTests
{
    public interface ILogEntryParser
    {
        bool TryParse(string s, out LogEntry logEntry);
    }
}
