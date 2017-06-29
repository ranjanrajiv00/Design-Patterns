using System;

namespace SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string carName = "BMW";
            var car = AutoFactory.CreateCar(carName);
            car.Start();
            car.Stop();
            Console.ReadKey();
        }
    }
}