using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        public abstract void SearchAccount(/*string lastName, string firstName,*/
            int lastFourOfSocial, int birthYear);
    
    }

}
