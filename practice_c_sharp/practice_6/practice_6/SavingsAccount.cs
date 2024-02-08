using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_6
{
    class SavingsAccount
    {
        private int acc_Number;
        private double bal;
        private double Interest_earned;
        private static double interestRate;
        public int Acc_Number
        {
            get
            {
                return acc_Number;
            }
        }
        public double Bal
        {
            get
            {
                return bal;
            }
        }
        public SavingsAccount(int Acc_num, double bal)
        {
            this.acc_Number = Acc_num;
            this.bal = bal;
            this.Interest_earned = 0.0;
        }
        public bool IsOverDrawn
        {
            get
            {
                return (bal < 0);
            }
        }
        public double InterestEarned
        {
            get
            {
                return Interest_earned;
            }
            set
            {
                if (value > 0)
                {
                    Interest_earned = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public static double InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > 0)
                    interestRate = value;
                else { Console.WriteLine("Error"); }
            }
        }
    }
}
