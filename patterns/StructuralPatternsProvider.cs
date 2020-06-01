using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using patterns.Structural.Adapter;
using patterns.Structural.Decorator;
using patterns.Structural.Facade;
using ILogSaver = patterns.Structural.Adapter.ILogSaver;

namespace patterns
{
    static class StructuralPatternsProvider
    {
        public static void Run()
        {
            #region Adapter
            Console.WriteLine("-----------Adapter pattern-------------");
            var simpleLogEntry = new SimpleLogEntry
            {
                Message = "simpleLogEntry",
                Severity = 2,
                Date = DateTime.Now
            };
            var exceptionalLogEntry = new ExceptionLogEntry()
            {
                Message = "exceptional log entry",
                Severity = 5,
                Date = DateTime.Now,
                Exception = new Exception("Some exception message")
            };
            ILogSaver sqlLogSaver = new SqlServerLogSaverAdapter();
            sqlLogSaver.Save(simpleLogEntry);
            sqlLogSaver.Save(exceptionalLogEntry);

            ILogSaver elasticLogSaver = new ElasticSearchLogSaverAdapter();
            elasticLogSaver.Save(simpleLogEntry);
            elasticLogSaver.Save(exceptionalLogEntry);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region Facade
            Console.WriteLine("-----------Facade pattern-------------");
            var facade = new SqlServerFacade();
            facade.ExecuteNonQuery("select * from all");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region Decorator
            Console.WriteLine("-----------Decorator pattern -------------");
            Console.WriteLine("-----------Throttling -------------");
            var logSaver = new ThrottlingLogSaverDecorator(new ElasticLogSaver());
            logSaver.SaveLogEntry("1242", simpleLogEntry);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-----------Trace -------------");
            var traceLogSaver = new TraceServerDecorator(new ElasticLogSaver());
            traceLogSaver.SaveLogEntry("12432", simpleLogEntry);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-----------Factory -------------");
            var factLogSaver = LogSaverFactory.CrateLogSaver();
            factLogSaver.SaveLogEntry("12432", simpleLogEntry);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            #endregion
        }
    }
}
