using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_9
{
    class Dog : Pet
    {
        public bool CanFetch;

        public Dog(string name, bool canFetch)
        : base(name)
        {
            this.CanFetch = canFetch;
        }
        public override void Move(bool fast)
        {
            if (fast)
                Console.WriteLine("{0} is {1}", Name, "Bound");
            else
                Console.WriteLine("{0} is {1}", Name, "Stride");
        }

        public override void Speak()
        {
            Console.WriteLine("barks");
        }
    }
}
