using System.Linq;

namespace patterns.Structural.Composite.Specification
{
    class OrLogImportRule : CompositeLogImportRule
    {
        /// <summary>
        /// Leaf
        /// </summary>
        /// <remarks>
        ///Конкретное правило
        /// </remarks>
        /// <param name="left"></param>
        /// <param name="import"></param>
        public OrLogImportRule(LogImportRule left, LogImportRule import) : base(left, import)
        {
        }

        public override bool ShouldImport(LogEntry logEntry)
        {
            return _rules.Any(e => e.ShouldImport(logEntry));
        }
    }
}
