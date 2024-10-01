using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class BankAccount
    {

        double _initialBalance;
        string _accountNumber;



        public BankAccount(string accountNumber, double initialBalance)
        {
            _accountNumber = accountNumber;
            _initialBalance = initialBalance;
        }

        public void Withdraw(double amount)
        {

            if(amount < 0 )
            {
                return;
            }

            this.Balance -= amount;

        }

      public void Deposit(double amount)
        {
            if (amount < 0)
            {
                return;
            }

            this.Balance += amount;

        }

        public double Balance
        {
            get
            {
                return _initialBalance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _initialBalance = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            private set { }
        }

        public void DisplayInfo()
        {

            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account Number: {_accountNumber}");
            Console.WriteLine($"Balance: {_initialBalance:F2}");

        }
    }
}
