using System;
using System.Collections.Generic;

namespace patterns.Behavioral.Observer
{
    public class LogEntryEventArgs : EventArgs
    {
        /// <summary>
        /// подписываемся на события и выполняем код со стороны наблюдателя
        /// </summary>
        /// <param name="longEntrie"></param>
        public LogEntryEventArgs(string longEntrie)
        {
            LogEntry = longEntrie;
        }

        public string LogEntry { get; internal set; }
    }
    class LogFileReaderEventObserver : IDisposable
    {
        private readonly string _fileName;

        public LogFileReaderEventObserver(string fileName)
        {
            _fileName = fileName;

        }

        public event EventHandler<LogEntryEventArgs> OnNewLogEntry;

        /// <summary>
        /// вызов сделал снаружи, по сути должна быть внутренняя логика выхова этого метода
        /// </summary>
        public void CheckFile()
        {

            foreach (var longEntrie in ReadNewLonEntries())
            {
                RaiseNewLogEntry(longEntrie);
            }
        }

        private void RaiseNewLogEntry(string longEntrie)
        {
            var handler = OnNewLogEntry;
            handler?.Invoke(this, new LogEntryEventArgs(longEntrie));
        }

        private IEnumerable<string> ReadNewLonEntries()
        {
            return new List<string>
            {
                "first event",
                "second event",
                "third event"
            };
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
