using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDeligate.Publisher
{
    public class Stock
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
                    OnStockChange();
                }
            }
        }

        public Stock(string symbol, double price) {
            this._symbol = symbol;
            this._price = price;
        }
        public delegate void StockChangeHandler(Stock stock);
        public event StockChangeHandler StockChange;

        private void OnStockChange()
        {
            if (StockChange != null)
            {
                StockChange(this);
            }
        }
    }
}
