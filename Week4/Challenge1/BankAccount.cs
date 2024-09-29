using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class BankAccount
    {
        string HolderName;
        double InitialBalance;
        BankAccount(string holderName, double initialBalance)
        {

            HolderName = holderName;
            InitialBalance = initialBalance;

        }

    }
}
