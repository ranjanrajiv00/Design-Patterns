using AbstractFactoryDBProvider.AbstractDBProvider;
using System;

namespace AbstractFactoryDBProvider.DBProvider.Oracle
{
    public class OracleCommand : IDbCommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle command executed successfully.");
        }
    }
}