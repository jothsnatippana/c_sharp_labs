using practice_7_2;
class Driver
{
    static void Main(string[] args)
    {
        Student s1= new Student();
        s1[1] = 23;
        s1[3] = 34;
        s1[2] = 67;
        s1[4] = 89;
        s1[6] = 58;
        Console.WriteLine("1:{0} ; 2:{1} ; 3:{2} ; 4:{3}", s1[1], s1[2], s1[3], s1[4]);
        Console.WriteLine(s1[6]);
    }
}