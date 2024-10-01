using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Account
    {

        string _accountHolder;
        double _amount;
        public string AccountHolder { get
            {
                return _accountHolder;
            } private set
            {}
        }

        public double Amount
        {
            get
            {
                return _amount;
            } set
            {
                                   
                LogTransaction("Deposit successful.");
                _amount = value;
            }
        }

      public Account(string accountHolder)
        {

            _accountHolder = accountHolder;
            AccountHolder = accountHolder;

        }

        public void Deposit(double amount) { 
        
            this.Amount = amount;
        
        }

        public void DisplayAccountInfo()
        {

            Console.WriteLine($"Account Holder: {_accountHolder}");
            Console.WriteLine($"Amount: {_amount}");

        }

        public void LogTransaction(string message)
        {
            Console.WriteLine($"{message}");

        }

    }
}
