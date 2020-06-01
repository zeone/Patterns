using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace patterns.Structural.Facade
{
    /// <summary>
    /// Facade
    /// <remarks>
    /// Агрегирует сложные интерфейсы, и оставляет только нужные операции
    /// </remarks>
    /// </summary>
    class SqlServerFacade
    {
        private readonly SqlServer _server = new SqlServer();
        public void ExecuteNonQuery(string query)
        {
            _server.InitConnection("127.0.0.1");
            Console.WriteLine(_server.DoSomething(query));
        }

        public void ExecuteDbReader(IDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
