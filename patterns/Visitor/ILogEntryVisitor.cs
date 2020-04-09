using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Visitor
{
   public interface ILogEntryVisitor
   {
       void Visit(ExceptionLogEntry exceptionLogEntry);
       void Visit(SimpleLogEntry simpleLogEntry);
   }
}
