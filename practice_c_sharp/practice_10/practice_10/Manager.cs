using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_10
{
    class Manager : Employee,IPromotable,IGoodStudent
    {
        protected string secretaryName;

        public Manager(string name, double salary, string secretaryName)
        : base(name, salary)
        {
            this.secretaryName = secretaryName;
        }

        public override void Print()
        {
            Console.WriteLine("Manager");
            base.Print();
            Console.WriteLine("Secretary: {0}",secretaryName);
        }

        void IPromotable.Promote()
        {
            salary=salary+(50 *salary)/100;
            Console.WriteLine("new salary:{0}",salary);
        }

        void IGoodStudent.Promote()
        {
            Console.WriteLine("you were always a good student");
        }
    }
}
