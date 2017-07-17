using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account  //this class derived from Accont
    {
        protected double savingsAccountBalance = 5000000; //set fields
        protected double deposit;
        protected double withdraw;
        protected string savingsAccountType;

        public double SavingsAccountBalance  //used this property to store savings acct. information
        {
            get { return this.savingsAccountBalance; }
            set { this.savingsAccountBalance = value; }
        }

        public double Deposit { get; set; }  //set more properites
        public double Withdraw { get; set; }
        public string SavingsAccountType { get; set; }

        public SavingsAccount()
        {
            //default constructor
        }

        public SavingsAccount(double withdraw, double deposit) //second constructor
        {
            this.withdraw = withdraw;
            this.deposit = deposit;
            
        }


        public double AddToSavingsAccount(double deposit)  //used this method to add to the savings acct
        {
            return deposit += savingsAccountBalance;
        }

        public double GetSavBalance()
        {
            return savingsAccountBalance;
        }

        public override double SubtractFromSavings(double withdraw) //used this from a virtual method from the parent class
        {
            return savingsAccountBalance -= withdraw;
        }

        public override string GetAccountType()
        {
            savingsAccountType = accountType;
            return savingsAccountType;
        }

        public double WithdrawalMade()
        {
            withdraw = Withdraw;
            return withdraw;
        }      
    }
}
