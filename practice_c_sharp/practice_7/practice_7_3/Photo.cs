using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_7_3
{
    class Photo
    {
        private string title;
        public Photo()
        {
            this.Title= string.Empty;
        }
        public Photo(string title)
        {
            this.title = title;
        }
        public string Title { get { return title; }
        set { title = value; } }
    }
}
