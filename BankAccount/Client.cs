using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client : CheckingAccount
    {
        public string lastName { get; }
        public string firstName { get; }
        protected int lastFourOfSocial = 0000;
        protected int birthYear = 1960;

        public Client()
        {
            //default constructor
        }
        public Client(string lastName, string firstName, int lastFourOfSocial, int birthYear, double accountBalance) : base(lastName, firstName, lastFourOfSocial, birthYear, accountBalance)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.lastFourOfSocial = lastFourOfSocial;
            this.birthYear = birthYear;
        }
        public virtual void ClientInfo()
        {
            Console.WriteLine(lastName);
            Console.WriteLine(firstName);
        }
    }
}
