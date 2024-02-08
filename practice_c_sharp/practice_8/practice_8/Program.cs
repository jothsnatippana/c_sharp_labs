using practice_8;

class Driver
{
    static void Main(string[] args)
    {
        Art ar1 = new Art("kalyani", 2023, 23.45,"manju", 34.5, 2023);
        Asset as1 = new Asset("manju", 34.5, 2023);
        Property p1=new Property(23.45, "manju", 34.5, 2023);
        Stock st1 = new Stock("manju", 34.5, 2023,"symbol",23,45.9);
        Building b1 = new Building("address",78.9,"manju", 34.5, 2023);
        Console.WriteLine(as1.AmortizedCost(120));
        Console.WriteLine(ar1.AmortizedCost(120));
        Console.WriteLine(p1.AmortizedCost(120));
        Console.WriteLine(st1.AmortizedCost(120));
        Console.WriteLine(b1.AmortizedCost(120));
        p1.compute();
        ar1.Print();
        as1.Print();
        p1.Print();
        st1.Print();
        b1.Print();
    }
}