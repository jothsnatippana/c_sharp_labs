using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8
{
    class Asset
    {
        private string name;
        private double cost;
        private int yearPurchased;

        public Asset(string name,double cost,int yearPurchased)
        {
            this.name = name;
            this.cost = cost;
            this.yearPurchased = yearPurchased;
        }

        public double AmortizedCost(int currentYear)
        { 
          return cost / (currentYear - yearPurchased); 
        }
        public double Compute()
        {
            Console.WriteLine("assets");
            return cost;
        }
        public void Print()
        {
            Console.WriteLine("assests");
        }
}
}
