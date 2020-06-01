using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structural.Adapter
{
    /// <summary>
    /// Adaptee
    /// <remarks>
    /// Конкретный функционал для работы с sql
    /// </remarks>  
    /// </summary>
    class SqlLogSaver
    {
        public void Save(DateTime date, int serventy, string message)
        {
            Console.WriteLine("SqlLogSaver  Save() " + message);
        }

        public void SaveException(DateTime date, string message, Exception e)
        {
            Console.WriteLine("SqlLogSaver  SaveException() " + e.Message);
        }
    }
}
