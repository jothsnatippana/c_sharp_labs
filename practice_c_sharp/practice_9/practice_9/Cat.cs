using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_9
{
    class Cat : Pet
    {
        public bool IsPicky;

        public Cat(string name, bool IsPicky)
         : base(name)
        {
            this.IsPicky = IsPicky;
        }

        public override void Move(bool fast)
        {
            if (fast)
                Console.WriteLine("{0} is {1}", Name, "Pounce");
            else
                Console.WriteLine("{0} is {1}", Name, "Slink");
        }

        public override void Speak()
        {
            Console.WriteLine("meows");
        }
    }
}
