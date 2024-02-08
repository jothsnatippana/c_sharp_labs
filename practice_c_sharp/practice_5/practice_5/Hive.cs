using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5
{
    class Hive
    {
        public int[] cells;
        public const int Empty = 0;
        public const int Full = 1;
        public Hive(int size)
        {
            cells = new int[size];
            for(int i=0;i<size;i++) 
            { 
                cells[i] = Empty; 
            }
        }
    }
}
