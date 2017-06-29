using AbstractFactoryDBProvider.AbstractFactory;
using System;
using System.Reflection;

namespace AbstractFactoryDBProvider
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDbProviderFactory dbProviderFactory = LoadDbProviderFactory();

            PrintHeader("Connection");
            var dbConnection = dbProviderFactory.CreateConnection();
            dbConnection.Open();
            dbConnection.Close();

            PrintHeader("Command");
            var dbCommand = dbProviderFactory.CreateCommand();
            dbCommand.Execute();

            Console.ReadKey();
        }

        private static IDbProviderFactory LoadDbProviderFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IDbProviderFactory;
        }

        private static void PrintHeader(string header)
        {
            Console.WriteLine("************************{0}****************************", header);
        }
    }
}