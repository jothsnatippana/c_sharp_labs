class Loops
{
    static void Main(string[] args)
    {
        double sum = 0;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
                sum += (1.0 / ((2 * i) + 1));
            else
                sum -= (1.0 / ((2 * i) + 1));

        }
        Console.WriteLine(sum);
    }
}