using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client : ClientBase
    {
        private string lastName;
        private string firstName;
        public int houseNumber;
        public string streetName;
        public double phoneNumber;
        protected int lastFourOfSocial;
        protected int birthYear;
        public decimal addToChecking = 0.0m;
        private decimal checkingAccountBalance = 0.0m;

        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public double PhoneNumber { get; set; }
        public decimal AddToChecking { get; set; }
        public int AccountNumber { get; }


        public Client()
        {
            //default constructor
        }
        public Client(string lastName, string firstName, int houseNumber, string streetName,
            double phoneNumber, int lastFourOfSocial, int birthYear)
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
