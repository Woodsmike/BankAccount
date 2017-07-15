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
            string exit = " ";


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
            decimal checkingAccountBalance = 0.0m;
            decimal savingsAccountBalance = 0.0m;

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
                            checkingAccountBalance = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                        }
                        else if (accountAnswer == "savings")
                        {
                            Console.WriteLine("How much would you like to deposit today in your checking account?");
                            savingsAccountBalance = decimal.Parse(Console.ReadLine());
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
                lastFourOfSocial, birthYear, checkingAccountBalance);


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
                    }
                    else if (selectionKey == "2")
                    {
                        Console.WriteLine("a. Checking Account\nb. Savings account");
                        selectionKey = Console.ReadLine();
                        Console.Clear();

                        if (selectionKey == "a")
                        {
                            client1.AccountBalance(checkingAccountBalance);
                            decimal cab = client1.AccountBalance(checkingAccountBalance);
                            Console.WriteLine("This is your checking account balance: " + cab.ToString("C2"));
                            Console.WriteLine("Please hit any key to continue");
                            accountAnswer = Console.ReadLine().ToLower();
                        }
                        else if (selectionKey == "b")
                        {
                            client1.AccountBalance(savingsAccountBalance);
                            decimal cab = client1.AccountBalance(savingsAccountBalance);
                            Console.WriteLine("This is your saving account balance: " + cab.ToString("C2"));
                            Console.WriteLine("Please hit any key to continue");
                            accountAnswer = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if(selectionKey == "3")
                    {
                        client1.ClientInfo();

                    }
                    else if(selectionKey == "4")
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
                    Client client2 = new Client("Capone", "Al", 6, "foot under park", 2160010001,
                    6666, 1899, 0m);
                    checkingAccountBalance = 23324342m;
                    Console.WriteLine(checkingAccountBalance);
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
                    }
                    else if (selectionKey == "2")
                    {
                        Console.WriteLine("a. Checking Account\nb. Savings account");
                        selectionKey = Console.ReadLine();
                        Console.Clear();

                        if (selectionKey == "a")
                        {
                            client2.AccountBalance(checkingAccountBalance);
                            decimal cab = client2.AccountBalance(checkingAccountBalance);
                            Console.WriteLine("This is your checking account balance: " + cab.ToString("C2"));
                            Console.WriteLine("Please hit any key to continue");
                            string accountAnswer = Console.ReadLine().ToLower();
                        }
                        else if (selectionKey == "b")
                        {
                            client2.AccountBalance(savingsAccountBalance);
                            decimal cab = client2.AccountBalance(savingsAccountBalance);
                            Console.WriteLine("This is your saving account balance: " + cab.ToString("C2"));
                            Console.WriteLine("Please hit any key to continue");
                            string accountAnswer = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (selectionKey == "3")
                    {
                        client2.ClientInfo();

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

                  
                } while (selectionKey != "5");

            
        }
        public static void Exit()
        {
            //string exit = Console.ReadLine().ToLower();
            //if (exit == "exit")
            //{
                Console.Clear();
                Console.WriteLine("Thank you for banking at Steal'em Robb'em Blind Bank!");
                Environment.Exit(0);
                return;
            //}

        }
    }
}
