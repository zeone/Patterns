using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Visitor
{
   public class ExceptionLogEntry:LogEntryVisitor
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }


    }
}
