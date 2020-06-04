using System;

namespace patterns.Structural.Composite.Specification
{
    /// <summary>
    /// Client
    /// </summary>
    /// <remarks>
    /// Клиент для работы с компоновщиком
    /// </remarks>
    public static class LogRuleFactory
    {
        public static LogImportRule Import(Func<LogEntry, bool> predicate)
        {
            return new SingleLogImportRule(predicate);
        }

        public static LogImportRule Or(this LogImportRule left, Func<LogEntry, bool> predicate)
        {
            return new OrLogImportRule(left, Import(predicate));
        }

        public static LogImportRule And(this LogImportRule left, Func<LogEntry, bool> predicate)
        {
            return new AndLogImportRule(left, Import(predicate));
        }

        public static LogImportRule RejectOldEntriesWithLowSeverity(TimeSpan period)
        {
            return
                //импортируем исключение
                Import(le => le is ExceptionLogEntry)
                    //или старыее собщения с высокой важностью
                    .Or(le => (DateTime.Now - le.Date) > period).And(le => le.Severity >= 5)
                    //или новые с любой важностью
                    .Or(le => (DateTime.Now - le.Date) <= period);
        }
    }


}
