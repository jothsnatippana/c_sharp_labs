using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8
{
    class Property:Asset
    {
        private double assessment;
        public Property(double assessment,string name, double cost, int yearPurchased) :base(name,cost,yearPurchased)
        {
            this.assessment = assessment;
        }

        public double compute()
        {
            Console.WriteLine("property");
            return assessment;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Property");
        }
    }
}
