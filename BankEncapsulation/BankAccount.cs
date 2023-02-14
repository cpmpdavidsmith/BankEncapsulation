using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        //private field set to 0
        private double _balance = 0;

        public double Deposit(double amount)
        {
            return _balance += amount;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }	
}

