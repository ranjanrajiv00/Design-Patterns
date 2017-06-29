using AbstractFactoryDBProvider.AbstractDBProvider;
using System;

namespace AbstractFactoryDBProvider.DBProvider.SQL
{
    public class SqlCommand : IDbCommand
    {
        public void Execute()
        {
            Console.WriteLine("SQL command executed successfully.");
        }
    }
}