using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace patterns.SimpleTests
{
    public class LogEntryReader
    {
        private readonly Stream _stream;
        private readonly ILogEntryParser _logEntryParser;

        public LogEntryReader(Stream stream, ILogEntryParser logEntryParser)
        {
            _stream = stream;
            _logEntryParser = logEntryParser;
        }

        public IEnumerable<LogEntry> Read()
        {
            using (var sr = new StreamReader(_stream))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    LogEntry logEntry;
                    if (_logEntryParser.TryParse(line, out logEntry))
                        yield return logEntry;
                }
            }
        }
    }
}
