using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2_3
{
    class Sum
    {
        private int res;
        public int Sum_value(params int[] arr1)
        {
            foreach (int i in arr1)
                res += i;
            return res;
        }
    }
}
