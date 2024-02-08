using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_3
{
    class Book
    {
        private string title;
        private string author;
        private bool available;

        public Book(string title, string author, bool available):this(title,author)
        {
            Console.WriteLine("three Argument Constructor");
            this.title = title;
            this.author = author;
            this.available = available;
            Console.WriteLine(this.title);
            Console.WriteLine(this.author);
            Console.WriteLine(this.available);
        }
        public Book(string title,string author):this(title)
        {
            Console.WriteLine("two argument constructor");
            this.title = title;
            this.author = author;
            this.available = true;
            Console.WriteLine(this.title);
            Console.WriteLine(this.author);
            Console.WriteLine(this.available);
        }

        public Book(string title):this()
        {
            Console.WriteLine("one argument constructor");
            this.title = title;
            this.author = "anonymous";
            this.available = true;
            Console.WriteLine(this.title);
            Console.WriteLine(this.author);
            Console.WriteLine(this.available);
        }

        public Book()
        {
            Console.WriteLine("No argument constructor");
            this.title = "untitled";
            this.author = "anonymous";
            this.available = true;
            Console.WriteLine(this.title);
            Console.WriteLine(this.author);
            Console.WriteLine(this.available);
        }
    }
}
