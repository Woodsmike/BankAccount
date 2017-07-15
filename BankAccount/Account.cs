using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        decimal accountBalance = 0;
        string lastName;
        string firstName;
        int lastFourSocial;
        int birthYear;
        

        public virtual void SearchAccount(string lastName, string firstName,
            int lastFourOfSocial, int birthYear)
        {

        }

        public virtual decimal AccountBalance(decimal accountBalance)
        {
            return accountBalance;
        }
    
        public Account()
        {
            //default constructor
        }
    }

}
