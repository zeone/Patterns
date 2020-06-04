using System.Linq;

namespace patterns.Structural.Composite.Specification
{
    class AndLogImportRule : CompositeLogImportRule
    {
        public AndLogImportRule(LogImportRule left, LogImportRule import) : base(left, import)
        {
        }

        public override bool ShouldImport(LogEntry logEntry)
        {
            return _rules.All(e => e.ShouldImport(logEntry));
        }
    }
}
