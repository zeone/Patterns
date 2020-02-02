using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Strategy
{
    /// <summary>
    /// Strategy
    /// </summary>
    interface ILogReader
    {
        List<LogEntry> Read();
    }
}
