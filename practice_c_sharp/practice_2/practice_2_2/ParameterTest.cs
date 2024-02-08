using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2_2
{
     class ParameterTest
    {
        public void Value(int x)
        {
            x++;
        }
        public void Swap(ref int x,ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }

        public void MinMax(int[] arr1,out int maxim,out int minim)
        {
            maxim = int.MinValue;
            minim=int.MaxValue;
            foreach(int i in arr1)
            {
                maxim = Math.Max(i, maxim);
                minim = Math.Min(i, minim);
            }
        }

    }
}
