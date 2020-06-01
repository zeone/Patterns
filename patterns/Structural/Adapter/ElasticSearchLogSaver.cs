using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structural.Adapter
{
    /// <summary>
    /// Adaptee
    /// <remarks>
    /// Конкретный функционал для работы с еластиксом
    /// </remarks>  
    /// </summary>
    class ElasticSearchLogSaver
    {
        public void Save(SimpleLogEntry simpleLogEntry)
        {
            Console.WriteLine("ElasticSearchLogSaver  Save() " + simpleLogEntry.Message);
        }

        public void SaveException(ExceptionLogEntry exceptionLogEntry)
        {
            Console.WriteLine("ElasticSearchLogSaver  SaveException() " + exceptionLogEntry.Exception.Message);
        }
    }
}
