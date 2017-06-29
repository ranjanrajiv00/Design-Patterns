using ObserverPattern.Observer;
using System.Collections.Generic;

namespace ObserverPattern.Publisher
{
    public abstract class Stock
    {
        private string _symbol;

        public string Symbol
        {
            get { return _symbol; }
        }

        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        private List<IInvestor> _investors = new List<IInvestor>();

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Subscribe(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void UnSubscribe(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var item in _investors)
            {
                item.Update(this);
            }
        }
    }
}