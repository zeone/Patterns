using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structural.Adapter
{
    /// <summary>
    /// Adapter
    /// <remarks>
    /// Конкретный адаптер для использования ElasticSearchLogSaver
    /// </remarks>
    /// </summary>
    class ElasticSearchLogSaverAdapter : ILogSaver
    {
        private readonly ElasticSearchLogSaver _elasticSearch = new ElasticSearchLogSaver();
        public void Save(LogEntry logEntry)
        {
            if (logEntry is SimpleLogEntry simpleLogEntry)
            {
                _elasticSearch.Save(simpleLogEntry);
                return;
            }

            var exceptionLogEntry = (ExceptionLogEntry)logEntry;
            _elasticSearch.SaveException(exceptionLogEntry);

        }
    }
}
