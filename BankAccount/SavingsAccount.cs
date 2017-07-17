using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {

        protected double savingsAccountBalance = 5000000;
        protected double deposit;
        protected double withdraw;
       
        public double SavingsAccountBalance
        {
            get { return this.savingsAccountBalance; }
            set { this.savingsAccountBalance = value; }
        }
       
        public double Deposit { get; set; }
        public double Withdraw { get; set; }


        public SavingsAccount()
        {
            //default constructor
        }

        public SavingsAccount(double withdraw, double deposit)
        {

            this.withdraw = withdraw;
            this.deposit = deposit;       

        }


        public double AddToSavingsAccount(double deposit)
        {
            return deposit += savingsAccountBalance;

        }
        public double GetSavBalance()
        {
            return savingsAccountBalance;
        }
        public override double SubtractFromSavings(double withdraw)
        {
            return savingsAccountBalance -= withdraw;

        }
        public double WithdrawalMade()
        {
            withdraw = Withdraw;
            return withdraw;
        }
      
    }
}
