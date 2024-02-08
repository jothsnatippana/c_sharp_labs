using practice_6;
class Driver
{
    static void Main(string[] args)
    {
        SavingsAccount s1=new SavingsAccount(23456,560);
        Console.WriteLine(s1.Acc_Number);
        Console.WriteLine(s1.Bal);
        s1.InterestEarned = 23;
        Console.WriteLine(s1.InterestEarned);
        Console.WriteLine(s1.IsOverDrawn);
        s1.InterestEarned = -34;
        Console.WriteLine(s1.InterestEarned);
        SavingsAccount.InterestRate = 23;
        Console.WriteLine(SavingsAccount.InterestRate);
        SavingsAccount.InterestRate = -23;
        Console.WriteLine(SavingsAccount.InterestRate);
    }
}