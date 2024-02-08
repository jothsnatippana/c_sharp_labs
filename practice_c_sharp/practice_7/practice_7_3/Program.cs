using practice_7_3;
class Driver
{
    static void Main(string[] args)
    {
        Photo p1=new Photo("book1");
        Photo p2 = new Photo("book2");
        Photo p3 = new Photo("book3");
        Photo p4 = new Photo("book4");
        Photo p5 = new Photo("book5");
        Album a1 = new Album(5);
        a1[1] = p1;
        a1[2] = p2;
        a1[3]=p3;
        a1[4]=p4;
        a1[0] = p5;
        a1[9]=p5;
        Console.WriteLine(a1[1].Title);
        Console.WriteLine(a1[2].Title);
        Console.WriteLine(a1[3].Title);
        Console.WriteLine(a1[4].Title);
        Console.WriteLine(a1[0].Title);
        Console.WriteLine(a1[21].Title);


    }
}