using System;
using System.Collections.Generic;
using System.Text;
using patterns.Behavioral.Iterator;
using patterns.Behavioral.Mediator;
using patterns.Behavioral.Observer;
using patterns.Behavioral.Strategy;
using patterns.Behavioral.TemplateMethod;
using patterns.Behavioral.Visitor;

namespace patterns
{
    public static class BehavioralPatternsProvider
    {
        public static void Run()
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
            Console.WriteLine("-----------Template Method-------------");
            var processorLogTemMet = new LogFileReaderTemplMet();
            processorLogTemMet.ProcessLogs();
            Console.WriteLine(Environment.NewLine);

            var logProcDelTemMet = new LogProcessorDelegateTemplMet();
            logProcDelTemMet.ProcessLogs(() => Console.WriteLine("process data from file delegate"));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region Mediator


            Console.WriteLine("-----------Mediator pattern-------------");
            var importerMediator = new ImporterMediator();
            importerMediator.ImportFile();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region Iterator
            foreach (var t in new LogFileSourceIterator("test"))
            {
                Console.WriteLine(t.Message);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            #endregion

            #region Observer


            Console.WriteLine("-----------Observer pattern-------------");
            var logReaderCallbackObserver = new LogFileReaderCallbackObserver("some name", (e) =>
            {
                Console.WriteLine($"returned {e} row");
            });

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            var logReaderEventObserver = new LogFileReaderEventObserver("test");
            logReaderEventObserver.OnNewLogEntry += (sender, eventArgs) =>
            {
                Console.WriteLine($"returned {eventArgs.LogEntry} row");
            };
            logReaderEventObserver.OnNewLogEntry += DoEventActions;

            void DoEventActions(object sender, LogEntryEventArgs args)
            {
                Console.WriteLine($"returned from function {args.LogEntry} row");
            }
            logReaderEventObserver.CheckFile();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            var logReaderObservable = new LogFileReaderInterfaceObservable();
            var logFileReaderInterfaceObserver = new LogFileReaderInterfaceObserver("file name", logReaderObservable);
            logFileReaderInterfaceObserver.DetectThatNewFileWasCreated();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region Visitor


            Console.WriteLine("-----------Visitor pattern-------------");
            var dbSaveLogEntry = new DatabaseLogSaver();
            var exLogEntry = new ExceptionLogEntry();
            var simpleLogEntry = new SimpleLogEntry();
            dbSaveLogEntry.SaveLogEntry(exLogEntry);
            dbSaveLogEntry.SaveLogEntry(simpleLogEntry);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion
        }
    }
}
