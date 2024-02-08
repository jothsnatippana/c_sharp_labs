using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8
{
    class Art :Property
    {
        private string artist;
        private int yearCreated;
        public Art(string artist,int yearCreated, double assessment, string name, double cost, int yearPurchased) :base(assessment,name,cost,yearPurchased)
        { 
            this.artist = artist;
            this.yearCreated = yearCreated;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Art");
        }
    }
}
