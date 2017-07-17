using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount 
{
    class CheckingAccount : Account  //this account is derived from Account parent class
    {
        protected double checkingAccountBalance = 1000000;  //set fields
        protected double deposit;
        protected double withdraw;
        protected string checkingAccountType;
        
        public double CheckingAccountBalance  //set properties
        {
            get { return this.checkingAccountBalance; }
            set { this.checkingAccountBalance = value; }
        }   
        public double Deposit { get; set; }
        public double Withdraw { get; set; }
        public string CheckingAccountType { get; set; }

        public CheckingAccount()
        {
            //default constructor
        }
        public CheckingAccount(double withdraw, double deposit)  //second constructor
        {
            this.deposit = deposit;
            this.withdraw = withdraw;            
        }


        public double AddToChecking(double deposit) // used this method to add to checking balance
        {                       
            return deposit = checkingAccountBalance + deposit;
        }

        public override double SubtractFromChecking(double withdraw) //used to method to subtract from checking balance
        {
            return withdraw = checkingAccountBalance - withdraw;
        }

        public double GetChkBalance()  //used this method to get checking balance
        {
            return checkingAccountBalance;
        }

        public double SaveDepositMade(double deposit) //did not used this one
        {
            deposit = Deposit;
            return deposit;
        }

        public double WithdrawalMade()  //did not used this one
        {
            withdraw = Withdraw;
            return withdraw;
        }
        public override string GetAccountType()  
        {
            checkingAccountType = accountType;
            return checkingAccountType;
        }
    }
}
