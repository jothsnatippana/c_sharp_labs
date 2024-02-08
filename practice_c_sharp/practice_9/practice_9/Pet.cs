using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_9
{
    abstract class Pet
    {
        public string Name;

        protected Pet(string name)
        {
            this.Name = name;
        }
        public abstract void Speak();
        public virtual void Move(bool fast)
        {
            if(fast)
                Console.WriteLine("{0} is {1}", Name, "Running");
            else
            Console.WriteLine("{0} is {1}",Name,"walking");
        }
    }
}
