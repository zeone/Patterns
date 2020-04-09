using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Visitor
{
    public class SimpleLogEntry : LogEntryVisitor
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}
