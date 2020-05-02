using System;
using System.Collections.Generic;

namespace patterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Template Method
    /// позволяет описать основное поведения в базовом класе, при этом часть алгоритма выноситься в наследники или делегат
    /// похож на паттерн стратегия
    /// </summary>
    abstract class LogProcessorTemplMet
    {
        protected LogProcessorTemplMet()
        {
            Console.WriteLine("абстрактный класс");
        }

        public void ProcessLogs()
        {
            ReadFile();
            ProcessData();
        }

        /// <summary>
        /// объявлен как виртуал чтобы можно было переопределить в юнит тестах
        /// </summary>
        protected virtual void ReadFile()
        {
            Console.WriteLine("read file");
        }

        protected abstract List<LogEntry> ProcessData();
    }

    /// <summary>
    /// Template Method
    ///вместо абстрактного метода и наследования, будет использовать делегат
    /// </summary>
    class LogProcessorDelegateTemplMet
    {
        public LogProcessorDelegateTemplMet()
        {
            Console.WriteLine("делегат");
        }
        /// <summary>
        /// принимает делегат вместо абстрактного метода
        /// </summary>
        /// <param name="doSomething"></param>
        public void ProcessLogs(Action doSomething)
        {
            ReadFile();
            doSomething.Invoke();
        }

        /// <summary>
        /// объявлен как виртуал чтобы можно было переопределить в юнит тестах
        /// </summary>
        protected virtual void ReadFile()
        {
            Console.WriteLine("read file");
        }

    }
}
