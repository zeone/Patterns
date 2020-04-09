using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Visitor
{
    public abstract class LogEntryVisitor
    {
        public abstract void Accept(ILogEntryVisitor logEntryVisitor);

        
    }
}
