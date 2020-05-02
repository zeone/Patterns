namespace patterns.Behavioral.Visitor
{
    public class SimpleLogEntry : LogEntryVisitor
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}
