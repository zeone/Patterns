namespace patterns.Behavioral.Visitor
{
    public abstract class LogEntryVisitor
    {
        public abstract void Accept(ILogEntryVisitor logEntryVisitor);

        
    }
}
