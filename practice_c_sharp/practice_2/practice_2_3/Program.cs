using practice_2_3;
class Driver
{
    
    static void Main(string[] args)
    {
        Sum s= new Sum();
        int result=s.Sum_value(new int[] { 1, 2, 3, 4, 5,7,8,9 });
        Console.WriteLine(result);
    }
}