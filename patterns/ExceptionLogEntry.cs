using System;
using System.Collections.Generic;
using System.Text;

namespace patterns
{
    public class ExceptionLogEntry : LogEntry
    {
   
        public Exception Exception { get; set; }
    }
}
