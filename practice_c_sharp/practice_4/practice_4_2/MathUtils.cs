﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_4_2
{
    class MathUtils
    {
        public static int Min(int a,int b)
        {
            if (a < b) { return a; }
            return b;
        }

        public static int Max(int a,int b) 
        {  if (a > b) { return a; }
            return b;
        }
    }
}
