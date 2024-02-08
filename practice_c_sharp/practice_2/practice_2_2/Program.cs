using practice_2_2;
class Driver
{
    static void Main(string[] args)
    {
        ParameterTest p1 = new ParameterTest();
        int x = 6;
        Console.WriteLine("the value before calling is:{0}",x);
        p1.Value(x);
        Console.WriteLine("the value after calling is:{0}", x);
        int a = 5;
        int b = 6;
        Console.WriteLine("the values before swapping are {0} ,{1}",a,b);
        p1.Swap(ref a, ref b);
        Console.WriteLine("after using ref for swapping a is {0} and b is {1}",a,b);
        int[] arr1=new int[10];
        arr1 = [1, 56, 23, 87, -2, 45, 10, 2, 8, 12];
        p1.MinMax(arr1, out int maxim, out int minim);
        Console.WriteLine("the min value is {0} ;the max value is {1}",minim,maxim);
    }
}