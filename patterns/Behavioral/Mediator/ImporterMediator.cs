namespace patterns.Behavioral.Mediator
{
    /// <summary>
    /// Mediator
    /// Паттерн комбинирует в себе логику разных объектов  таким обрадом делая их независимыми друг от друга
    /// </summary>
    public class ImporterMediator
    {
        readonly FileReaderMediator _reader = new FileReaderMediator();
        readonly FileSaverMediator _saver = new FileSaverMediator();
        public void ImportFile()
        {
            _reader.ReadFile();
            _saver.SaveFile();
            

        }
    }
}

