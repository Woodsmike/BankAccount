using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount 
{
    class CheckingAccount : Account
    {
        protected double checkingAccountBalance = 1000000;
        protected double deposit;
        protected double withdraw;
        
        public double CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
            set { this.checkingAccountBalance = value; }
        }   
        public double Deposit { get; set; }
        public double Withdraw { get; set; }


        public CheckingAccount()
        {
            //default constructor
        }
        public CheckingAccount(double withdraw, double deposit)
        {

            this.deposit = deposit;
            this.withdraw = withdraw;
            
            
        }

        public double AddToChecking(double deposit)
        {                       
            return deposit = checkingAccountBalance + deposit;
        }
        public override double SubtractFromChecking(double withdraw)
        {
            return withdraw = checkingAccountBalance - withdraw;
        }
        public double GetChkBalance()
        {
            return checkingAccountBalance;
        }
        public double SaveDepositMade(double deposit)
        {
            deposit = Deposit;
            return deposit;
        }
        public double WithdrawalMade()
        {
            withdraw = Withdraw;
            return withdraw;
        }
      
    }
}
