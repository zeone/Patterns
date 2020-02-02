using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.TemplateMethod
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
