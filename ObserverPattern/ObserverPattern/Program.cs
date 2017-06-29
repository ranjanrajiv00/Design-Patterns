using ObserverPattern.Observer;
using ObserverPattern.Publisher;
using System;

namespace ObserverPattern
{
    /// <summary>
    /// When one object is dependent on another object
    /// When change in one object require a notification to other object
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM(120.00);
            ibm.Subscribe(new Investor("Rajiv"));
            ibm.Subscribe(new Investor("Ranjan"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 120.10;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.ReadKey();
        }
    }
}