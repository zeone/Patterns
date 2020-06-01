namespace patterns.Behavioral.Visitor
{
   public interface ILogEntryVisitor
   {
       void Visit(ExceptionLogEntryV exceptionLogEntry);
       void Visit(SimpleLogEntryV simpleLogEntry);
   }
}
