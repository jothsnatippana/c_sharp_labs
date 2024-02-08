using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_10
{
    class Programmer : Employee ,IPromotable
    {
        protected double averageOT;

        public Programmer(string name, double salary, double averageOT)
        : base(name, salary)
        {
            this.averageOT = averageOT;
        }
        public override void Print()
        {
            Console.WriteLine("Programmer");
            base.Print();
            Console.WriteLine("Average OT: {0}", averageOT);
        }
        public void Promote()
        {
            salary = salary + (10 * salary) / 100;
            Console.WriteLine("new salary:{0}", salary);
        }
    }
}
