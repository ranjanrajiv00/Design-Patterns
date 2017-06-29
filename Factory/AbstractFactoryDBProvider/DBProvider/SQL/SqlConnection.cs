using AbstractFactoryDBProvider.AbstractDBProvider;
using System;

namespace AbstractFactoryDBProvider.DBProvider.SQL
{
    public class SqlConnection : IDbConnection
    {
        public void Close()
        {
            Console.WriteLine("Sql connection opened.");
        }

        public void Open()
        {
            Console.WriteLine("Sql connection closed.");
        }
    }
}