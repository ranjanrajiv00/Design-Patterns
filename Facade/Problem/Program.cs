using Problem.SubSystems;
using System;

namespace Problem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarModel model = new CarModel();
            CarEngine engine = new CarEngine();
            CarBody body = new CarBody();
            CarAccessories accessories = new CarAccessories();

            Console.WriteLine("******** Creating a Car **********\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}