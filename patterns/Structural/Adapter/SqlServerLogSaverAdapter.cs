using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace patterns.Structural.Adapter
{
    /// <summary>
    /// Adapter
    /// <remarks>
    /// Конкретный адаптер для использования SqlServerLogSaver
    /// </remarks>
    /// </summary>
    class SqlServerLogSaverAdapter : ILogSaver
    {
        private readonly SqlLogSaver _sqlLogSaver = new SqlLogSaver();

        public void Save(LogEntry logEntry)
        {
            if (logEntry is SimpleLogEntry simpleLogEntry)
            {
                _sqlLogSaver.Save(simpleLogEntry.Date, simpleLogEntry.Severity, simpleLogEntry.Message);
                return;
            }

            var exceptionLogEntry = (ExceptionLogEntry)logEntry;
            _sqlLogSaver.SaveException(exceptionLogEntry.Date, exceptionLogEntry.Message, exceptionLogEntry.Exception);
        }
    }
}
