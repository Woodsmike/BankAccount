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
        protected int checkingAccountNumber = 0;
        protected int savingsAccountNumber = 0;
        protected decimal deposit;
        protected decimal withdrawFromAccount;
        protected decimal checkingAccountBalance;
        protected decimal savingsAccountBalance;

        public string AccountType { get; set; }
        public int CheckingAccountNumber { get; set; }
        public int SavingsAccountNumber { get; set; }
        public decimal WithdrawFromAccount { get; set; }          
        public decimal Deposit { get; set; }
        public decimal CheckingAccountBalance { get; set; }
        public decimal SavingsAccountBalance { get; set; }

        public Account(string accountType, int chkAccNum, int savAccNum, decimal withDraw, decimal deposit,
            decimal chkBalance, decimal savBalance)
        {
            this.accountType = accountType;
            this.checkingAccountNumber = chkAccNum;
            this.savingsAccountNumber = savAccNum;
            this.withdrawFromAccount = withDraw;
            this.deposit = deposit;
            this.checkingAccountBalance = chkBalance;
            this.savingsAccountBalance = savBalance;
        }

        public Account()
        {
            //default constructor
        }
        public virtual string GetAccountType()
        {
            return accountType;
        }
        public virtual int GetCheckAccNumber()
        {
            return checkingAccountNumber;
        }
        public virtual int GetSavingsAccNumber()
        {
            return savingsAccountNumber;
        }
        public virtual decimal AddToCheckingAccount()
        {
            return deposit;
           
        }
        public virtual decimal AddToSavingsAccount()
        {
            return deposit;

        }
        public virtual decimal SubtractFromChecking()
        {
            return withdrawFromAccount;

        }
        public virtual decimal SubtractFromSavings()
        {
            return withdrawFromAccount;

        }
        public virtual decimal GetChkBalance()
        {
            return checkingAccountBalance;
        }
        public virtual decimal GetSavBalance()
        {
            return savingsAccountBalance;
        }

    }

}
