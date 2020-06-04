using System;

namespace patterns.Structural.Composite.Specification
{
    /// <summary>
    /// Component
    /// <remarks>
    /// Простое правило фильтрации (по вакту являеться листом и не содержит в в себе компонентов
    /// </remarks>
    /// </summary>
    public class SingleLogImportRule : LogImportRule
    {
        private Func<LogEntry, bool> _predicate;
        public SingleLogImportRule(Func<LogEntry, bool> predicate)
        {
            _predicate = predicate;
        }

        public override bool ShouldImport(LogEntry logEntry)
        {
            return _predicate(logEntry);
        }


    }
}
