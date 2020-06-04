using System.Collections.Generic;

namespace patterns.Structural.Composite.Specification
{
    /// <summary>
    /// Composite
    /// <remarks>
    /// Составной компонент, делегирует выполнение основной операции дочерним елементам
    /// </remarks>
    /// </summary>
    public abstract class CompositeLogImportRule : LogImportRule
    {
        protected CompositeLogImportRule(LogImportRule left, LogImportRule import)
        {
            _rules.Add(left);
            _rules.Add(import);
        }

        protected List<LogImportRule> _rules = new List<LogImportRule>();
    }
}
