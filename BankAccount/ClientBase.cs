using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class ClientBase  //my abstract class
    {
        protected int checkingAccountNumber;
        protected int savingsAccountNumber;

        public int CheckingAccountNumber { get; set; }
        public int SavingsAccountNumber { get; set; }

        

        public virtual void SearchForAccountNumber(int checkingAccountNumber, int savingsAccountNumber)
        {
            this.checkingAccountNumber = checkingAccountNumber;
            this.savingsAccountNumber = savingsAccountNumber;
        }
    }
}
