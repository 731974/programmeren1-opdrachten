using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Account
    {
        string _accountHolder;
        double _amount;
        public string AccountHolder {
            get
            {
                return _accountHolder;
            } private set
            {
                _accountHolder = value;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            } set
            {
                if (value < 0)
                {
                    LogTransaction("Balance cannot be negative.");
                    return;
                }
                _amount = value;
                LogTransaction("Deposit successful.");
            }
        }

        public Account(string accountHolder)
        {
            _accountHolder = accountHolder;
            _amount = 0;
        }

        public void Deposit(double amount) { 
            if (amount <= 0)
            {
                LogTransaction("Cannot deposit negative amount.");
                return;
            }
                
            Amount += amount;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {_accountHolder}");
            Console.WriteLine($"Amount: {_amount}");
        }
        
        private void LogTransaction(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
