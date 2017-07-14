using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        public string lastName { get; }
        public string firstName { get; }
        protected int lastFourOfSocial = 0000;
        protected int birthYear = 1920;
        public double accountBalance = 0.0d;

        public CheckingAccount()
        {
            //default constructor
        }
        public CheckingAccount(string lastName, string firstName,
            int lastFourOfSocial, int birthYear, double accountBalance)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.lastFourOfSocial = lastFourOfSocial;
            this.birthYear = birthYear;
            this.accountBalance = accountBalance;
        }

        public override void SearchAccount(/*string lastName, string firstName,*/
            int lastFourOfSocial, int birthYear)
        {
            //this.firstName = firstName;
            //this.lastName = lastName;
            this.birthYear = birthYear;
            this.lastFourOfSocial = lastFourOfSocial;

            if (lastFourOfSocial == this.lastFourOfSocial)
            {
                Console.WriteLine(firstName + "\n" + lastName + "\n" + birthYear + "\n" + lastFourOfSocial);
            }

        }
    }
}
