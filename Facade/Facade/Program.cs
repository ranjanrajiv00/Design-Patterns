using System;

namespace Facade
{
    /// <summary>
    /// Provide a unified interface to a set of interfaces in a subsystem.
    /// Facade defines a higher-level interface that makes the subsystem easier to use.
    /// Wrap a complicated subsystem with a simpler interface.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}