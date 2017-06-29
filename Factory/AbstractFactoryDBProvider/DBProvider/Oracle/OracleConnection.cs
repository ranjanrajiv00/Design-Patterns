using AbstractFactoryDBProvider.AbstractDBProvider;
using System;

namespace AbstractFactoryDBProvider.DBProvider.Oracle
{
    public class OracleConnection : IDbConnection
    {
        public void Close()
        {
            Console.WriteLine("Oracle connection opened.");
        }

        public void Open()
        {
            Console.WriteLine("Oracle connection closed.");
        }
    }
}