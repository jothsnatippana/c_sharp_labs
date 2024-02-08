using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
     class Point
    {
        private int x;
        private int y;
        public void Intialize(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(int x) 
        { 
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;   
        }
        public void Translate(int xoffset,int yoffset)
        {
            this.x += xoffset;
            this.y += yoffset;
        }
        public void Scale(int a)
        {
            this.x *= a;
            this.y *= a;
        }

        public double Distance(Point p)
        {
            double result = (double)Math.Sqrt(Math.Pow(this.x-p.x, 2)+Math.Pow(this.y-p.y,2));
            return result;
        }
    }
}
