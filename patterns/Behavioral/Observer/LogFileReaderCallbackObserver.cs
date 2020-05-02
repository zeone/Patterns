using System;
using System.Collections.Generic;
using System.Threading;

namespace patterns.Behavioral.Observer
{
    /// <summary>
    /// Все очень просто, принимаем делегат который выполняем при нужном состоянии
    /// </summary>
    public class LogFileReaderCallbackObserver : IDisposable
    {
        private readonly string _fileName;
        private readonly Action<string> _logEntrySubscriber;
        private static readonly TimeSpan CheckFileInterval = TimeSpan.FromSeconds(5);
        private readonly Timer _timer;

        public LogFileReaderCallbackObserver(string fileName, Action<string> logEntrySubscriber)
        {
            _fileName = fileName;
            _logEntrySubscriber = logEntrySubscriber;
            //    _timer = new Timer(()=>CheckFile(),CheckFileInterval,CheckFileInterval);
            CheckFile();
        }

        private void CheckFile()
        {
            foreach (var longEntire in ReadNewLonEntries())
            {
                _logEntrySubscriber(longEntire);
            }
        }

        private IEnumerable<string> ReadNewLonEntries()
        {
            return new List<string>
         {
             "first callback",
             "second callback",
             "third callback"
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
