using System;

namespace Exceptions
{
    class SavingsAccount
    {
        private int accountNumber;
        private double balance;

        public SavingsAccount(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
            if(balance < 0) { throw new OverdrawnException("amount is gone too low",balance); }
        }
    }

    class SavingsAccountTest
    {
        static void Main()
        {

            SavingsAccount account = new
           SavingsAccount(12345, 2000);
            try
            {
                account.Withdraw(2500);
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }
    }

    public class OverdrawnException:System.ApplicationException
    {
        public double bal;
        public OverdrawnException(string message,double balance)
            :base(message)
        {
            Console.WriteLine("constructor is called");
            bal = balance;
        }
    }
}