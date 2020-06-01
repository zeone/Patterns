using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace patterns.Structural.Facade
{
    class SqlServer
    {
        /// <summary>
        /// Пример сложного класса
        /// </summary>
        /// <param name="connStr"></param>
        public void InitConnection(string connStr)
        {
            Console.WriteLine($"connection {connStr} inited");
        }

        public string DoSomething(string query)
        {
            return $"Executed query: {query}";
        }

        /*
         *
         *Do a lot different things
         *
         *
         *
         */
    }
}
