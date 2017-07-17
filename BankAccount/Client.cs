using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client : ClientBase
    {
        //
        private string lastName;
        private string firstName;
        public int houseNumber;
        public string streetName;
        public double phoneNumber;
        protected int lastFourOfSocial;
        protected int birthYear;
     
        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public double PhoneNumber { get; set; }      
        public int AccountNumber { get; }


        public Client()
        {
            //default constructor
        }

        public Client(string lastName, string firstName, int houseNumber, string streetName,
            double phoneNumber, int lastFourOfSocial, int birthYear, int savingsAccountNumber, 
            int checkingAccountNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.phoneNumber = phoneNumber;
            this.lastFourOfSocial = lastFourOfSocial;  //was going to use for logon - didn't get to it
            this.birthYear = birthYear;  //was going to use for logon - didn't get to it
            this.checkingAccountNumber = checkingAccountNumber;
            this.savingsAccountNumber = savingsAccountNumber;                 
        }

        public virtual void ClientInfo()  //method for client info section
        {            
            Console.WriteLine("________________________________________________" +
            "________________________________________________________________________\n\n");
            Console.WriteLine("\t\t\t\tCustomer's Account Information\n\n\n\n");
            Console.WriteLine("\t\t\t\tCustomer's First Name:      {0}\n", firstName);
            Console.WriteLine("\t\t\t\tCustomer's Last Name:       {0}\n", lastName);
            Console.WriteLine("\t\t\t\tCustomer's Home Address:    {0} {1} \n", houseNumber, streetName);
            Console.WriteLine("\t\t\t\tCustomer's Phone Number:    {0} \n", phoneNumber);
            Console.WriteLine("\t\t\t\tCustomer's Checking Acct#:  {0}\n", checkingAccountNumber);
            Console.WriteLine("\t\t\t\tCustomer's Savings Acct#:   {0}\n", savingsAccountNumber);
            Console.WriteLine("\n\n_________________________________________________" +
            "_______________________________________________________________________\n\n");
        }       
        
        //made below to input in the above ClientInfo method
        //this method also came from the abstract parent class
        public override void SearchForAccountNumber(int checkingAccountNumber, int savingsAccountNumber)
        {
            this.checkingAccountNumber = checkingAccountNumber;
            this.savingsAccountNumber = savingsAccountNumber;            
        }
    }
}
