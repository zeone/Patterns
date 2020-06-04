namespace patterns.Structural.Composite.Specification
{
    /// <summary>
    /// Component
    /// <remarks>
    /// базовый класс для всех компонентов
    /// </remarks>
    /// </summary>
    public abstract class LogImportRule
    {
        public abstract bool ShouldImport(LogEntry logEntry);
    }
}
