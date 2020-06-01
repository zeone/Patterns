using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structural.Decorator
{
    public abstract class LogSaverDecorator : ILogSaver
    {
        /// <summary>
        /// Decorator
        /// <remarks>
        /// Базовый класс декоратора, предназначенный для расширения поведения компонента 
        /// </remarks>
        /// </summary>
        protected readonly ILogSaver _decoratee;

        protected LogSaverDecorator(ILogSaver logSaver)
        {
            _decoratee = logSaver;
        }

        public abstract Task SaveLogEntry(string appId, LogEntry logEntry);
    }
}
