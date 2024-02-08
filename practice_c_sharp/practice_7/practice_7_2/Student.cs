using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_7_2
{
    class Student
    {
        private double[] grades = new double[4];
        public double this[int i]
        {
            get
            {
                if(i<5 && i>0)
                  return grades[i-1];
                else
                    Console.WriteLine("index out of range");
                return 0.0;
            }
           set
           {
                if (i < 5 && i > 0)
                    grades[i-1]=value;
                else
                    Console.WriteLine("index out of range");
            }
        }
    }
}
