using EventDeligate.Observer;
using EventDeligate.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDeligate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            Stock ibm = new Stock("IBM", 120.00);
            var investor1 = new Investor("Rajiv", ibm);
            var investor2 = new Investor("Ranjan", ibm);

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 120.10;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.ReadKey();
        }        
    }
}
