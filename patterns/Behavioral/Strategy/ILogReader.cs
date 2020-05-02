using System.Collections.Generic;

namespace patterns.Behavioral.Strategy
{
    /// <summary>
    /// Strategy
    /// </summary>
    interface ILogReader
    {
        List<LogEntry> Read();
    }
}
