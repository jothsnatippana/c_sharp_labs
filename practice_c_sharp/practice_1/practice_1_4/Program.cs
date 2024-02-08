class Array_Examples
{
    static void Main(string[] args)
    {
        int[] arr1 = new int[10];
        int minim = int.MaxValue;
        for(int i=0;i<10;i++)
        {
            arr1[i] =Convert.ToInt32(Console.ReadLine());
            minim = Math.Min(arr1[i], minim);
        }
        Console.WriteLine("the contents of array");
        foreach (int i in arr1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("the minimum value is:{0}",minim);
    }
}