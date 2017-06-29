using EventDeligate.Publisher;
using System;

namespace EventDeligate.Observer
{
    public class Investor : IInvestor
    {
        private string _name { get; set; }

        public Investor(string name, Stock stock)
        {
            this._name = name;
            stock.StockChange += Update;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}", this._name, stock.Symbol, stock.Price);
        }
    }
}