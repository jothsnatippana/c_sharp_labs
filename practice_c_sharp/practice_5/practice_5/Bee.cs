using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5
{
    class Bee
    {
        private int Current_state;
        private const int searching = 1;
        private const int gathering = 2;
        private const int returning = 3;
        private const int depositing = 4;
        public Hive h;
        private Random r=new Random();
        public Bee(Hive hive) 
        {
            this.h = hive;
            this.Current_state = searching;
        }
        public void Work()
        {
            switch(Current_state)
            {
                case searching:
                    Console.WriteLine("Searching.....");
                    int flower = r.Next(5);
                    if (flower == 0)
                        Current_state = gathering;
                    break;
                case gathering:
                    Console.WriteLine("Gathering.....");
                    Current_state= returning;
                    break;
                case returning:
                    Console.WriteLine("Returning....");
                    Current_state= depositing;
                    break;
                case depositing:
                    Console.WriteLine("Depositing.....");
                    int h1=r.Next(h.cells.Length);
                    if (h.cells[h1]==Hive.Empty)
                    {
                        h.cells[h1]=Hive.Full;
                        Current_state = searching;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
