using System;
using System.Collections.Generic;

namespace patterns.Behavioral.TemplateMethod
{
    class LogFileReaderTemplMet:LogProcessorTemplMet
    {
        protected override List<LogEntry> ProcessData()
        {
            Console.WriteLine("process data from file");
            return null;
        }
    }
}
