using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_4
{
    class Student
    {
        public string name;
        public int age;
        public int id;
        public static int nextId=1;
        public Student(string name,int age)
        {
            this.name = name;
            this.age = age;
            this.id = nextId++;
            Console.WriteLine("id:{0} ; name:{1} ; age:{2}",this.id,this.name,this.age);
        }
    }
}
