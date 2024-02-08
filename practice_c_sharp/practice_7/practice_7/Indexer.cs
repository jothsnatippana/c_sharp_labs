using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_7
{
    class Indexer
    {
        private string name;
        private int len;
        public int Len
        {
            get
            {
                return len;
            }
        }
        public Indexer(string name) 
        {
            this.name = name;
            this.len=name.Length;
        }    

        public char this [int i] 
        { 
            get 
            { 
                if(i<len)
                 return name[i];
                else
                    Console.WriteLine("index out of range");
                return '\0';
            }  
        }
    }
}
