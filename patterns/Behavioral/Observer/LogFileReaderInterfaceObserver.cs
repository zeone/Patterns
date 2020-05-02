using System;

namespace patterns.Behavioral.Observer
{
    /// <summary>
    /// похож на использование делегата, только здесь передаеться обект который наследуеться от интерфейса и разная его реализация
    /// </summary>
    public interface ILogFileReaderObserver
    {
        void NewLogEntry(string logEntry);
        void FileWasRolled(string oldLogFile, string newLogFile);
    }
    public class LogFileReaderInterfaceObserver
    {
        private readonly ILogFileReaderObserver _obsrerver;
        private readonly string _fileName;

        public LogFileReaderInterfaceObserver(string filenName, ILogFileReaderObserver observer)
        {
            _fileName = filenName;
            _obsrerver = observer;
        }
        /// <summary>
        /// вызов сделал снаружи, по сути должна быть внутренняя логика выхова этого метода
        /// </summary>
        public void DetectThatNewFileWasCreated()
        {
            if (IfNewFileWasCreated())
            {
                _obsrerver.FileWasRolled(_fileName, newLogFile: GetNewFileName());
            }
        }

        private string GetNewFileName()
        {
            return $"new file created";
        }

        private bool IfNewFileWasCreated()
        {
            return true;
        }
    }

    /// <summary>
    /// конкретная реализация наблюдателя
    /// </summary>
    public class LogFileReaderInterfaceObservable : ILogFileReaderObserver
    {
        public void NewLogEntry(string logEntry)
        {
            throw new NotImplementedException();
        }

        public void FileWasRolled(string oldLogFile, string newLogFile)
        {
            Console.WriteLine($"old file: {oldLogFile} new file: {newLogFile} interface row");
        }
    }
}
