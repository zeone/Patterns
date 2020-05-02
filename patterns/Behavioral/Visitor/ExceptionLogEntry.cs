namespace patterns.Behavioral.Visitor
{
   public class ExceptionLogEntry:LogEntryVisitor
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }


    }
}
