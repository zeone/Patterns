namespace patterns.Behavioral.Visitor
{
   public class ExceptionLogEntryV:LogEntryVisitor
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }


    }
}
