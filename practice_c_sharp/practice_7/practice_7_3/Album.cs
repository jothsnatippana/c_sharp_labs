using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_7_3
{
    class Album
    {
        Photo[] photos;
        
        public Album(int capacity)
        {
            photos=new Photo[capacity];
            for(int i = 0; i < photos.Length; i++) { photos[i]= new Photo(); }
        }

        public Photo this[int index] 
        {
            get
            {
                if(index<photos.Length)
                  return photos[index];
                Console.WriteLine("error:please enter valid index");
                return new Photo("untitled");
            }
            set
            {
                if (index < photos.Length)
                    photos[index] = value;
                else
                Console.WriteLine("error:please enter valid index");
            }
        }
    }
}
