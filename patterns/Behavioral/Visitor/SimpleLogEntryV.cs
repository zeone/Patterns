﻿namespace patterns.Behavioral.Visitor
{
    public class SimpleLogEntryV : LogEntryVisitor
    {
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}
