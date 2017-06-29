using Problem.Autos;
using System;

namespace Problem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string carName = args[0];
            var aCar = GetCar(carName);
            aCar.Start();
            aCar.Stop();
            Console.Read();
        }

        private static IAuto GetCar(string carName)
        {
            switch (carName)
            {
                case "bmw":
                    return new BMW();

                case "maruti":
                    return new Maruti();

                default:
                    return null;
            }
        }
    }
}