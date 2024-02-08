using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8
{
    class Building:Property
    {
        private string address;
        public Building(string address, double assessment, string name, double cost, int yearPurchased):base(assessment, name, cost, yearPurchased)
        {
            this.address = address;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Building");
        }
    }
}
