using FactoryMethod.Autos;
using FactoryMethod.Factories;
using System;
using System.Reflection;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IAutoFactory autoFactory = LoadFactory();
            IAuto car = autoFactory.CreateAutoMobile();
            car.Start();
            car.Stop();

            Console.ReadKey();
        }

        private static IAutoFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}