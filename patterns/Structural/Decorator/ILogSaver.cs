using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structural.Decorator
{
    /// <summary>
    /// Component
    /// <remarks>
    /// Базовый класс компонента, чье поведение будет расширяться декораторами
    /// </remarks>
    /// </summary>
   public interface ILogSaver
    {
        Task SaveLogEntry(string appId, LogEntry logEntry);
    }
}
