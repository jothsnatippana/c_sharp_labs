using practice_2;

class Basics
{
    static void Main(string[] args)
    {
        Point Point1 = new Point();
        Point Point2 = new Point();
        Point1.Intialize(2, 3);
        Point2.Intialize(21, 22);
        Console.WriteLine("the value of x : {0} ; the value of y :{1}",Point1.GetX(),Point1.GetY());
        Point1.SetX(4);
        Point1.SetY(5);
        Console.WriteLine("the values after setting x and y values");
        Console.WriteLine("the value of x : {0} ; the value of y :{1}", Point1.GetX(), Point1.GetY());
        Point1.Translate(6, 7);
        Console.WriteLine("the values after translating x and y values");
        Console.WriteLine("the value of x : {0} ; the value of y :{1}", Point1.GetX(), Point1.GetY());
        Point1.Scale(10);
        Console.WriteLine("the values after scaling x and y values");
        Console.WriteLine("the value of x : {0} ; the value of y :{1}", Point1.GetX(), Point1.GetY());
        double res=Point1.Distance(Point2);
        Console.WriteLine("the distance between point1 and point2 is:{0}", res);
    }
}