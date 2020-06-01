using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using patterns.Structural.Adapter;

namespace patterns.Structural.Decorator
{
    /// <summary>
    /// Concrete decorator
    /// <remarks>
    /// Реализация декоратора
    /// добавляет к декорируему обьетку специфическое поведение 
    /// </remarks>
    /// </summary>
    /// <param name="logSaver"></param>
    public class TraceServerDecorator:LogSaverDecorator
    {
        public TraceServerDecorator(ILogSaver logSaver) : base(logSaver)
        {
        }

        public override async Task SaveLogEntry(string appId, LogEntry logEntry)
        {
            var sw = Stopwatch.StartNew();
            try
            {
                await _decoratee.SaveLogEntry(appId, logEntry);

            }
            finally
            {
                Trace.TraceInformation($"Операция сохванения замершена за {sw.ElapsedMilliseconds} mc");
            }
        }
    }
}
