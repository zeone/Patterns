using System;

namespace patterns
{
    public class LogEntry
    {
        public DateTime Date { get; set; }
        public int Severity { get; set; }
        public string Message { get; set; }

        public static LogEntry Parse(string line)
        {
            return new LogEntry
            {
                Date = DateTime.Now,
                Severity = 0,
                Message = line
            };
        }
    }
}
