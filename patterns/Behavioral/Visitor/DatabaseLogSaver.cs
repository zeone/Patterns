using System;

namespace patterns.Behavioral.Visitor
{
    /// <summary>
    /// Суть паттерна в том, что если у насть некий объект но его функционал должен изменяться в зависимости от случая, то мы создаем интерфейс(ILogEntryVisitor)
    /// в котором прописываем действия под все необходимые кейсы(ExceptionLogEntry, SimpleLogEntry) и далее, в конкретной реализации класа в котором будут происходиться действия,
    /// мы переопределяем через интерфейс все неоюходимые методы
    /// </summary>
    // todo: разобратся детальней
    public class DatabaseLogSaver : ILogEntryVisitor
    {

        public void SaveLogEntry(LogEntryVisitor logEntry)
        {
            logEntry.Accept(this);
        }

        void ILogEntryVisitor.Visit(ExceptionLogEntry exceptionLogEntry)
        {
            SaveException(exceptionLogEntry);
        }

        void ILogEntryVisitor.Visit(SimpleLogEntry simpleLogEntry)
        {
            SaveSimpleLogEntry(simpleLogEntry);
        }

        private void SaveSimpleLogEntry(SimpleLogEntry simpleLogEntry)
        {
            Console.WriteLine("Saved simple");
        }


        private void SaveException(ExceptionLogEntry exceptionLogEntry)
        {
            Console.WriteLine("Saved exception");
        }
    }
}
