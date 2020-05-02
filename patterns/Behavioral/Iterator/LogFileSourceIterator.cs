using System.Collections;
using System.Collections.Generic;

namespace patterns.Behavioral.Iterator
{
    /// <summary>
    /// Iterator
    /// паттерн позволяет содавать кастомные перечисляемые для разных задачь, далее использовать в циклах как форич
    /// </summary>
    public class LogFileSourceIterator : IEnumerable<LogEntry>
    {
        private readonly string _logFileName;

        private List<string> _exampleList = new List<string>
        {
            "1_",
            "2_",
            "3_",
            "4_"

        };
        public LogFileSourceIterator(string logFilename)
        {
            _logFileName = logFilename;
        }

        public IEnumerator<LogEntry> GetEnumerator()
        {
            //foreach (string line in File.ReadAllLines(_logFileName))
            //{
            //    yield return LogEntry.Parse(line);
            //}
            foreach (string line in _exampleList)
            {
                yield return LogEntry.Parse(line+_logFileName);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
