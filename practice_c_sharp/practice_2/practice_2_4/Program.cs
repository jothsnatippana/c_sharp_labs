using practice_2_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class World
{
    static void Main(string[] args)
    {
        Robot robot = new Robot();
        robot.Intialize("nam shin", 4, 5, 0);
        robot.Print();
        robot.At(3,5);
    }
}