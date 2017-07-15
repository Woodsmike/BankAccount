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
        protected decimal savingsBalance;

        public decimal DepositAmount { get; set; }
        public decimal Withdraw { get; set; }
        public decimal SavingsBalance { get; set; }
        
        
        
        

        public SavingsAccount(int accountNumber, decimal savingsBalance)
        {
            
            
            this.savingsBalance = savingsBalance;
        
           
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
            return savingsBalance;
        }

    }
}
