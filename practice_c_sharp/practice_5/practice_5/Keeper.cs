using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5
{
    class Keeper
    {
        public int Collect(Hive hive)
        {
            int count = 0;
            for(int i=0;i<hive.cells.Length;i++) 
            {
                if (hive.cells[i]==Hive.Full)
                    count++;
                hive.cells[i] = Hive.Empty;
            }
            return count;
        }

        public void Run()
        {
            Hive h1 = new Hive(20);
            Bee[] bees = new Bee[5];
            for(int i=0;i<bees.Length;i++)
            {
                bees[i] = new Bee(h1);
            }
            while(true)
            {
                for(int i=0;i<h1.cells.Length;i++)
                {
                    for(int j=0;j<bees.Length;j++)
                    {
                        bees[j].Work();
                    }
                }
                Console.WriteLine("total hive Collected:{0}",Collect(h1));
            }
        }
    }
}
