using System;
using patterns.Strategy;
using patterns.TemplateMethod;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region strategy

            Console.WriteLine("-----------Strategy pattern-------------");
            var concreteStrategy = new LogFileReaderStrategy();
            var logProcessorInt = new LogProcessorStrategyInterface(concreteStrategy);
            logProcessorInt.ProcessLogs();
            Console.WriteLine(Environment.NewLine);

            var logProcessorDelegate = new LogProcessorStrategyDelegate(() => new LogWindowsEventReaderStrategy().Read());
            logProcessorDelegate.ProcessLogs();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region TemplateMethod
            Console.WriteLine("-----------Strategy pattern-------------");
            var processorLogTemMet = new LogFileReaderTemplMet();
            processorLogTemMet.ProcessLogs();
            Console.WriteLine(Environment.NewLine);

            var logProcDelTemMet = new LogProcessorDelegateTemplMet();
            logProcDelTemMet.ProcessLogs(() => Console.WriteLine("process data from file delegate"));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion

            Console.WriteLine("Finish");
            Console.ReadLine();
        }
    }
}
