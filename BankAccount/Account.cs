using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        protected string accountType;
        protected int checkingAccountNumber;
        protected int savingsAccountNumber;
        //protected double deposit;
        //protected double withdrawFromAccount;
        
        public string AccountType { get; set; }
        public int CheckingAccountNumber { get; set; }
        public int SavingsAccountNumber { get; set; }
        //public double WithdrawFromAccount { get; set; }          
        //public double Deposit { get; set; }
        

        public Account(string accountType, int chkAccNum, int savAccNum)
        {
            this.accountType = accountType;
            this.checkingAccountNumber = chkAccNum;
            this.savingsAccountNumber = savAccNum;
            //this.withdrawFromAccount = withDraw;
            //this.deposit = deposit;
         
        }

        public Account()
        {
            //default constructor
        }
        public virtual string GetAccountType()
        {
            return AccountType;
        }
        public virtual int GetCheckAccNumber()
        {
            return CheckingAccountNumber;
        }
        public virtual int GetSavingsAccNumber()
        {
            return SavingsAccountNumber;
        }
        //public virtual double AddToCheckingAccount(double deposit)
        //{
            
        //    return deposit;

        //}
        //public virtual double AddToSavingsAccount(double deposit)
        //{
        //    return deposit;

        //}
        public virtual double SubtractFromChecking(double withdrawFromAccount)
        {
            return withdrawFromAccount;

        }
        public virtual double SubtractFromSavings(double withdrawFromAccount)
        {
            return withdrawFromAccount;

        }
        
        //public double SaveDepositAmount(double deposit)
        //{
        //    Deposit = deposit;
        //    return Deposit;
        //}

    }

}
