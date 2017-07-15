using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client : ClientBase
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        protected int lastFourOfSocial;
        protected int birthYear;
        protected decimal accountBalance { get; }
        public int houseNumber { get; set; }
        public string streetName { get; set; }
        public double phoneNumber { get; set; }

        public Client()
        {
            //default constructor
        }
        public Client(string lastName, string firstName, int houseNumber, string streetName,
            double phoneNumber, int lastFourOfSocial, int birthYear, decimal accountBalance)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.phoneNumber = phoneNumber;
            this.lastFourOfSocial = lastFourOfSocial;
            this.birthYear = birthYear;
        }
        public virtual void ClientInfo()
        {
            Console.WriteLine("Customer's name: {0} {1} ", firstName, lastName);
            Console.WriteLine("Customer's address : {0} {1} ", houseNumber, streetName);
            Console.WriteLine("Customer's phone number (cell) {0} ", phoneNumber);
        }

        public void AccountChoice()
        {
            Console.WriteLine("a. Checking Account");
            Console.WriteLine("b. Savings Account");
            string selectionKey = Console.ReadLine();
            Console.Clear();

            if(selectionKey == "a")
            {
                Console.WriteLine(AccountBalance(this.accountBalance));
            }
            

        }
        public override void SearchAccount(string lastName, string firstName,
          int lastFourOfSocial, int birthYear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.lastFourOfSocial = lastFourOfSocial;

            if (lastFourOfSocial == this.lastFourOfSocial)
            {
                Console.WriteLine(firstName + "\n" + lastName + "\n" + birthYear + "\n" + lastFourOfSocial);
            }

        }
    }
}
