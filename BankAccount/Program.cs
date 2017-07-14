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
            int CheckingAccountNumber = 1;
            int selectionKey = 0;
            string exit = " ";
            
            do
            {
                Console.WriteLine("Welcome to Steal'em Robb'em Blind Bank!\n]\n");
                Console.WriteLine("Do you currently have an account? 'Y'/'N'?");
                string answerYN = Console.ReadLine();
                string lastName = " ";
                string firstName = " ";
                
                do
                {

                    Console.WriteLine("Please enter your information");
                    //adding an account
                    Console.WriteLine("What is your last name?");
                    lastName = Console.ReadLine();
                    Console.WriteLine("What is your first name?");
                    firstName = Console.ReadLine();
                    Console.WriteLine("What is your last 4 numbers of your social security number?");
                    int lastFourOfSocial = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is your birth year?");
                    int birthYear = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much would you like to deposit today?");
                    double accountBalance = double.Parse(Console.ReadLine());

                    CheckingAccount CheckingAccountNumber1 = new CheckingAccount(lastName, firstName,
                        lastFourOfSocial, birthYear, accountBalance);
                    Client client1 = new Client(lastName, firstName,
                        lastFourOfSocial, birthYear, accountBalance);

                    Console.WriteLine(CheckingAccountNumber1.lastName);
                    Console.WriteLine(CheckingAccountNumber1.firstName);
                    Console.WriteLine(CheckingAccountNumber1.accountBalance.ToString("C2"));
                } while (answerYN != "y" || answerYN != "yes");
                

                    Console.WriteLine("MAIN MENU:");

                Console.WriteLine("Please choose from the following options.\n");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                ConsoleKeyInfo keyName = Console.ReadKey();
                string strReadKey = Console.ReadKey().KeyChar.ToString();
                int.TryParse(strReadKey, out selectionKey);
                switch (selectionKey)
                {

                    case 1:
                        ClientInfo();
                        break; // Break, don't return
                    case 2:
                        ViewAccountBalance(Account);
                        break;
                    case 3:
                        DepositFunds(Account);
                        break;
                    case 4:
                        WithdrawalFunds(Account);
                        break;
                    case 5:
                        if (exit == "quit")
                        {
                            Environment.Exit(0);
                            return;
                        };
                        break;
                    default:
                        break;
                }


                    
                Console.WriteLine("Do you wish to Exit? Please type 'Exit' or" +
                    " press the enter key to continue");
                exit = Console.ReadLine().ToLower();
                
            } while (exit != "exit");
            if (exit == "quit")
            {
                Environment.Exit(0);
                return;
            }
            //if (Console.KeyAvailable)
            //{
            //    Console.ReadKey(false);
            //}
            Console.Clear();
            Console.WriteLine("Thank you for banking at Steal'em Robb'em Blind Bank!");
        }
    }
}
