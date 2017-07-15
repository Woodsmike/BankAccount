using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectionKey = " ";
            int number = 0;

            Console.Clear();
            Console.WriteLine("Welcome to Steal'em Robb'em Blind Bank!\n\n");
            Console.WriteLine("Do you currently have an account? 'Y'/'N'?");
            string answerYN = Console.ReadLine();
            string lastName;
            string firstName;
            int houseNumber;
            string streetName;
            double phoneNumber;
            int lastFourOfSocial;
            int birthYear;
            int checkAccNumber;
            int savAccNumber;
            decimal deposit = 0;
            decimal depositAmount = 0;
            decimal withdraw = 0;           
            decimal checkingBalance = 0.0m;
            decimal savingsBalance = 0.0m;
            

            if (answerYN == "n" || answerYN == "no")
            {
                Console.WriteLine("Please enter your information");
                //adding an account
                Console.WriteLine("What is your last name?");
                lastName = Console.ReadLine().ToLower();

                Console.WriteLine("What is your first name?");
                firstName = Console.ReadLine().ToLower();

                Console.WriteLine("What is your street number?");
                houseNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your street name?");
                streetName = Console.ReadLine().ToLower();

                Console.WriteLine("What is your phone (cell) number?");
                phoneNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("What is your last 4 numbers of your social security number?");
                lastFourOfSocial = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your birth year?");
                birthYear = int.Parse(Console.ReadLine());

                CheckingAccount account1 = new CheckingAccount(deposit, withdraw, checkingBalance);
                Console.WriteLine("Would you like to make a deposit today?\n" +
                "Yes/No ");
                string accountAnswer = Console.ReadLine().ToLower();
                while (accountAnswer != "no" && accountAnswer != "n")
                {
                    Console.Clear();

                    if (accountAnswer == "yes" || accountAnswer == "y")
                    {

                        Console.WriteLine("Checking or Savings?");
                        accountAnswer = Console.ReadLine().ToLower();
                        if (accountAnswer == "checking")
                        {
                            Console.WriteLine("How much would you like to deposit today in your checking account?");
                            deposit = decimal.Parse(Console.ReadLine());
                            deposit = depositAmount;
                            account1.AddToCheckingAccount();
                            Console.WriteLine(checkingBalance);
                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                        }
                        else if (accountAnswer == "savings")
                        {
                            Console.WriteLine("How much would you like to deposit today in your checking account?");
                            deposit = decimal.Parse(Console.ReadLine());
                            deposit = depositAmount;
                            account1.AddToSavingsAccount();
                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Continue");
                    }
                }
                do
                {
                    Client client1 = new Client(lastName, firstName, houseNumber, streetName, phoneNumber,
                    lastFourOfSocial, birthYear);
                    
                    Console.Clear();
                    client1.ClientInfo();
                    Console.WriteLine("MAIN MENU:");

                    Console.WriteLine("Please choose from the following options.\n");
                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit");
                    selectionKey = Console.ReadLine();
                    Console.Clear();
                    bool intResultTryParse = int.TryParse(selectionKey, out number);
                    if (selectionKey == "1")
                    {
                        client1.ClientInfo();
                        AccountAnswer();
                    }
                    else if (selectionKey == "2")
                    {
                        Console.WriteLine("a. Checking Account\nb. Savings account");
                        selectionKey = Console.ReadLine();
                        Console.Clear();

                        if (selectionKey == "a")
                        {
                            account1.GetChkBalance();                                                      
                            AccountAnswer();
                        }
                        else if (selectionKey == "b")
                        {
                            account1.GetSavBalance();                          
                            AccountAnswer();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (selectionKey == "3")
                    {
                        Console.WriteLine("Checking or Savings?");
                        accountAnswer = Console.ReadLine().ToLower();
                        
                        if (accountAnswer == "checking")
                        {
                            Console.WriteLine("How much would you like to deposit today in your checking account?");
                            deposit = decimal.Parse(Console.ReadLine());
                            account1.AddToCheckingAccount();
                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                        }
                        else if (accountAnswer == "savings")
                        {
                            Console.WriteLine("How much would you like to deposit today in your checking account?");
                            deposit = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                        }

                        else
                        {
                            Console.WriteLine("Please enter Checking or Savings.  Or type" +
                                "'exit' to return");
                            AccountAnswer();
                        }

                    }
                    else if (selectionKey == "4")
                    {
                        client1.ClientInfo();
                    }
                    else
                    {
                        Exit();
                    }

                } while (selectionKey != "5");
            }

            else
            {
                do
                {

                    Console.Clear();
                    Client client2 = new Client("Capone", "Al", 6, " Feet Under Park", 2120010001, 0001,
                        1899);


                    SavingsAccount account2 = new SavingsAccount(depositAmount, withdraw, savingsBalance);
                    
                    CheckingAccount account3 = new CheckingAccount(depositAmount, withdraw, checkingBalance);
                    account3.CheckingBalance = 23324342.0m;
                    //account2.savingsBalance = 45908763.0m;

                    Console.WriteLine(savingsBalance);
                    Console.WriteLine("MAIN MENU:");

                    Console.WriteLine("Please choose from the following options.\n");
                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit");
                    selectionKey = Console.ReadLine();
                    Console.Clear();
                    bool intResultTryParse = int.TryParse(selectionKey, out number);
                    if (selectionKey == "1")
                    {
                        client2.ClientInfo();
                        AccountAnswer();
                    }
                    else if (selectionKey == "2")
                    {
                        Console.WriteLine("a. Checking Account\nb. Savings account");
                        selectionKey = Console.ReadLine();
                        Console.Clear();

                        if (selectionKey == "a")
                        {
                            account2.GetChkBalance();
                            Console.WriteLine("Your checking account balance is: " + account2.GetChkBalance().ToString("C2"));
                            AccountAnswer();
                        }
                        else if (selectionKey == "b")
                        {
                            account2.GetSavBalance().ToString("C2");
                            Console.WriteLine("Your checking account balance is: " + account2.GetSavBalance().ToString("C2"));
                            AccountAnswer();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (selectionKey == "3")
                    {
                        //Console.WriteLine("Would you like to make a deposit today?\n" +
                        //"Yes/No ");
                        //string accountAnswer = Console.ReadLine().ToLower();
                        //while (accountAnswer != "no" && accountAnswer != "n")
                        //{
                        //    Console.Clear();

                        //    if (accountAnswer == "yes" || accountAnswer == "y")
                        //    {

                        Console.WriteLine("a. Checking Account\nb. Savings account");
                        string accountAnswer = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (accountAnswer == "a")
                        {
                            Console.Clear();
                            Console.WriteLine("How much would you like to deposit today in your checking account?");
                            deposit = decimal.Parse(Console.ReadLine());
                            deposit = depositAmount;
                            account3.DepositMade();
                            account3.AddToCheckingAccount();
                            account3.GetCheckAccNumber().ToString("C2");
                            //tring newBalance = account2.GetCheckAccNumber();
                            Console.WriteLine("Your new balance is :" + account2.GetCheckAccNumber().ToString("C2"));
                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                        }
                        else if (accountAnswer == "b")
                        {
                            Console.WriteLine("How much would you like to deposit today in your checking account?");
                            savingsBalance = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                        }

                        else
                        {
                            Console.WriteLine("Continue");
                        }
                    }

                    else if (selectionKey == "4")
                    {
                        client2.ClientInfo();
                    }
                    else
                    {
                        Exit();
                    }

                } while (selectionKey != "5");
                Console.WriteLine("Please press the enter key" +
                " or to go back to the main menu or type 'Exit' to quit.");


            } while (selectionKey != "5") ;


        }
        public static void Exit()
        {

            Console.Clear();
            Console.WriteLine("Thank you for banking at Steal'em Robb'em Blind Bank!");
            Environment.Exit(0);
            return;
        }
        public static void AccountAnswer()
        {
            string accountAnswer;
            Console.WriteLine("Please hit any key to continue");
            accountAnswer = Console.ReadLine().ToLower();
        }
    }
}
