using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        public string lastName;
        public string firstName;
        protected int lastFourOfSocial = 0000;
        protected int birthYear = 1920;
        public decimal checkingAccountBalance = 0.0m;

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal CheckingAccountBalance { get; set; }
        public int LastFourOfSocial { get; }

        public CheckingAccount()
        {
            //default constructor
        }
        public CheckingAccount(string lastName, string firstName,
            int lastFourOfSocial, int birthYear, decimal checkingAccountBalance)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.lastFourOfSocial = lastFourOfSocial;
            this.birthYear = birthYear;
            this.checkingAccountBalance = checkingAccountBalance;
        }
        public override decimal AccountBalance(decimal checkingAccountBalance)
        {
            //Console.WriteLine("Your account balance is: {0}", accountBalance);
            return this.checkingAccountBalance;
        }
    }
}
