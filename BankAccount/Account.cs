using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account   //Parent class to Checking and Savings account classes
    {
        protected int checkingAccountNumber; //set fields
        protected int savingsAccountNumber;
        protected string accountType;        
        
        public string AccountType { get; set; }  //set properties
        public int CheckingAccountNumber { get; set; }
        public int SavingsAccountNumber { get; set; }

        public Account()
        {
            //default constructor
        }

        public Account(string accountType, int chkAccNum, int savAccNum) //second constructor
        {
            this.accountType = accountType;
            this.checkingAccountNumber = chkAccNum;
            this.savingsAccountNumber = savAccNum;
        }

        public virtual string GetAccountType()  //set some virtual methods
        {
            return AccountType;
        }

        public int GetCheckAccNumber()
        {
            return CheckingAccountNumber;
        }

        public int GetSavingsAccNumber()
        {
            return SavingsAccountNumber;
        }
       
        public virtual double SubtractFromChecking(double withdrawFromAccount)
        {
            return withdrawFromAccount;
        }

        public virtual double SubtractFromSavings(double withdrawFromAccount)
        {
            return withdrawFromAccount;
        }        
    }
}
