namespace Basics
{ 
   class Basic
    {
        static void Main(string[] args)
        {
            //basic output
            int a = 1;
            string b = "manju";
            char c = 'a';
            double d = 23.4;
            Console.WriteLine("using console.writeline:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("using console.write:");
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            //formatted output
            Console.WriteLine();
            Console.WriteLine("value of a:{0} ; value of b:{1} ; value of c:{2} ; value of d:{3}", a, b, c, d);
            Console.Write("value of a:{0} ; value of b:{1} ; value of c:{2} ; value of d:{3}", a, b, c, d);
            //input
            Console.WriteLine();
            int num1,num2,num3;
            string str1,str2,str3;
            num1=Console.Read();
            str1=Console.ReadLine();
            Console.WriteLine(num1);
            Console.WriteLine(str1);
            str2=Console.ReadLine();
            str3=Console.ReadLine();
            num2=Convert.ToInt32(str2);
            num3 = (int)Convert.ToDouble(str3);
            Console.WriteLine("the converted values are:{0} and {1}",num2,num3);
        }
    }
}