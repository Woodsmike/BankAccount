using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        decimal savingsAccountBalance = 0.0m;


        public SavingsAccount()
        {
            //default constructor
        }
        public override decimal AccountBalance(decimal savingsAccountBalance)
        {
            //Console.WriteLine("Your account balance is: {0}", accountBalance);
            return this.savingsAccountBalance;
        }
    }
}
