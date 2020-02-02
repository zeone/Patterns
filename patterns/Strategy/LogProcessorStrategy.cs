using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Strategy
{
    /// <summary>
    /// CONTEXT
    /// паттерн стратегия
    /// Суть в том что есть у нас есть некий общий функционал(поведение), но при этом он может использоваться по разному, то при помощи интерфейса или делегата
    /// мы можем переопределять его поведение
    /// Если просто, то у нас есть некий клас который должен например записывать логи, но источники могут быть разные,
    /// по этому при помощи делегата либо интерфейса мы можем указать как получить нужные данные и привести их к общему типу с которым уже и будет работать наш класс
    /// </summary>


    class LogProcessorStrategyDelegate
    {
        // делегат который будет передан для получения данных из логов
        private readonly Func<List<LogEntry>> _logImporter;
        public LogProcessorStrategyDelegate(Func<List<LogEntry>> logImporter)
        {
            Console.WriteLine("Log processor with delegate");
            _logImporter = logImporter;
        }
        public void ProcessLogs()
        {
            foreach (var logEntry in _logImporter.Invoke())
            {
                SaveLogEntry(logEntry);
            }
        }

        private void SaveLogEntry(LogEntry logEntry)
        {
            Console.WriteLine($"date: {logEntry.Date.ToShortDateString()} ");
        }
    }

    /// <summary>
    /// CONTEXT
    /// </summary>
    class LogProcessorStrategyInterface
    {
        //клас с реализованным интерфейсом ILogReader
        private readonly ILogReader _logImporter;
        public LogProcessorStrategyInterface(ILogReader logImporter)
        {
            Console.WriteLine("Log processor with interface");
            _logImporter = logImporter;
        }
        public void ProcessLogs()
        {
            foreach (var logEntry in _logImporter.Read())
            {
                SaveLogEntry(logEntry);
            }
        }

        private void SaveLogEntry(LogEntry logEntry)
        {
            Console.WriteLine($"date: {logEntry.Date.ToShortDateString()} ");
        }
    }
}
