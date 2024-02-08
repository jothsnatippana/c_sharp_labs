class Matrix
{
    static void Main(string[] args)
    {
        double[,] arr1 = new double[3, 5];
        int count = 1;
        for(int i=0;i<3;i++)
        {
            for (int j=0;j<5;j++)
            {
                arr1[i, j] = count++;
            }
        }
        Console.WriteLine("the total elements in array :{0}",arr1.Length);
        Console.WriteLine("the number of rows {0}",arr1.GetLength(0));
        Console.WriteLine("the number of columns {0}", arr1.GetLength(1));
        Console.WriteLine("Array Elements:");
        foreach (int i in arr1) 
        { 
            Console.Write(i);
        }
    }
}