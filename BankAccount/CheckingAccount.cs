using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        protected decimal depositAmount;
        protected decimal withdraw;
        

        public decimal DepositAmount { get; set; }
        public decimal Withdraw { get; set; }
       

        public CheckingAccount()
        {
            //default constructor
        }
        public CheckingAccount(decimal depositAmount, decimal withdraw, decimal checkingAccountBalance)
        {

            this.depositAmount = depositAmount;
            this.withdraw = withdraw;
            this.checkingAccountBalance = checkingAccountBalance;
            
        }

        public override decimal AddToCheckingAccount()
        {

            checkingAccountBalance += depositAmount;
            return checkingAccountBalance;

        }
        public override decimal SubtractFromChecking()
        {

            checkingAccountBalance -= withdraw;
            return checkingAccountBalance;

        }
        public decimal DepositMade()
        {
            deposit = DepositAmount;
            return deposit;
        }
        public decimal WithdrawalMade()
        {
            withdraw = Withdraw;
            return withdraw;
        }
        //public override decimal GetChkBalance()
        //{
        //    return checkingBalance;
        //}
    }
}
