using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class ClientBase  //my abstract class
    {
        protected int checkingAccountNumber; //set fields
        protected int savingsAccountNumber;

        public int CheckingAccountNumber { get; set; }  //set properties
        public int SavingsAccountNumber { get; set; }
              
        public ClientBase()  
        {
            //default constructor
        }

        // set this method for the child class to use
        public virtual int SearchForCheckAcctNum(int checkingAccountNumber)
        {
            this.checkingAccountNumber = checkingAccountNumber;
            return checkingAccountNumber;
        }

        public virtual int SearchForSavAcctNum(int savingsAccountNumber)
        {            
            this.savingsAccountNumber = savingsAccountNumber;
            return savingsAccountNumber;
        }
    }
}
