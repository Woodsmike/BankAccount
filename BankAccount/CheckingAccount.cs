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
        protected decimal checkingBalance;

        public decimal DepositAmount { get; set; }
        public decimal Withdraw { get; set; }
        public decimal CheckingBalance { get; set; }

        public CheckingAccount()
        {
            //default constructor
        }
        public CheckingAccount(decimal depositAmount, decimal withdraw, decimal checkingBalance)
        {

            this.depositAmount = depositAmount;
            this.withdraw = withdraw;
            this.checkingBalance = checkingBalance;

        }

        public override decimal AddToCheckingAccount()
        {

            checkingBalance += depositAmount;
            return checkingBalance;

        }
        public override decimal SubtractFromChecking()
        {

            checkingBalance -= withdraw;
            return checkingBalance;

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
