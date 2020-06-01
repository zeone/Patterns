using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structural.Adapter
{
    /// <summary>
    /// Target
    /// <remarks>
    /// Целевой интерфейс к через который будут работать и к которому будут преобразованы существующие класы 
    /// </remarks>
    /// </summary>
    interface ILogSaver
    {
        void Save(LogEntry logEntry);
    }
}
