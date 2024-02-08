using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_10
{
        abstract class Employee 
        { 
          protected string name; 
          protected double salary; 
 
          protected Employee(string name, double salary) 
         { 
          this.name = name; 
          this.salary = salary; 
         } 
 
         public virtual void Print() 
         { 
          Console.WriteLine("Name : {0}", name); 
          Console.WriteLine("Salary: {0}", salary); 
         } 
        } 
}
