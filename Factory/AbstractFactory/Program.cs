using AbstractFactory.Factories;
using System;
using System.Reflection;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IAutoFactory factory = LoadFactory();

            PrintHeader("SportsCar");
            var sportsCar = factory.CreateSportsCar();
            sportsCar.Start();
            sportsCar.Stop();

            PrintHeader("EconomyCar");
            var economyCar = factory.CreateEconomyCar();
            economyCar.Start();
            economyCar.Stop();

            PrintHeader("LuxuryCar");
            var luxuryCar = factory.CreateLuxuryCar();
            luxuryCar.Start();
            luxuryCar.Stop();

            Console.ReadKey();
        }

        private static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }

        private static void PrintHeader(string header)
        {
            Console.WriteLine("************************{0}****************************", header);
        }
    }
}