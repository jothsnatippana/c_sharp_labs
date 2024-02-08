using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practice_8
{
    class Stock : Asset
    {
        private string symbol;
        private int shares;
        private double price;
        public Stock(string name, double cost, int yearPurchased,string symbol, int shares, double price) :base(name,cost,yearPurchased)
        { 
            this.symbol = symbol;
            this.shares = shares;
            this.price = price;
        }

        public new double Compute()
        {
            Console.WriteLine("stocks");
            return (double)(price / shares);
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Stocks");
        }
    }
}
