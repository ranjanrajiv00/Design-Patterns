using ObserverPattern.Publisher;
using System;

namespace ObserverPattern.Observer
{
    public class Investor : IInvestor
    {
        private string _name { get; set; }

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}", this._name, stock.Symbol, stock.Price);
        }
    }
}