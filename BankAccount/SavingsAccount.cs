using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {

        protected decimal depositAmount;
        protected decimal withdraw;
      
        public decimal DepositAmount { get; set; }
        public decimal Withdraw { get; set; }
        
        
        
        
        

        public SavingsAccount(decimal withdraw, decimal depositAmount, decimal savingsAccountBalance)
        {

            this.withdraw = withdraw;
            this.depositAmount = depositAmount;
            this.savingsAccountBalance = savingsAccountBalance;
         
        
           
        }

        public SavingsAccount()
        {
            //default constructor
        }
        public override decimal AddToSavingsAccount()
        {
            return deposit;

        }
        public override decimal GetSavBalance()
        {
            return savingsAccountBalance;
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
    }
}
