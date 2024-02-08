using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_10
{
    class Intern : Employee
    {
        protected int lengthOfInternship;

        public Intern(string name, double salary, int lengthOfInternship)
        : base(name, salary)
        {
            this.lengthOfInternship = lengthOfInternship;
        }

        public override void Print()
        {
            Console.WriteLine("Intern");
            base.Print();
            Console.WriteLine("Length of internship(months): {0}", lengthOfInternship); 
        }
    }
} 

