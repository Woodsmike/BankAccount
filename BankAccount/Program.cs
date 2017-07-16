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
            string depositAmount;

            Console.Clear();
            Console.WriteLine("Welcome to Steal'em Robb'em Blind Bank!\n\n");


            Client client2 = new Client("Capone", "Al", 6, " Feet Under Park",
                        2120010001, 0001, 1899);


            SavingsAccount account2 = new SavingsAccount();
            CheckingAccount account3 = new CheckingAccount();
            double deposit;
            double withdraw;
            int minSavBalance = 500;

            do
            {

                Console.Clear();


                Console.WriteLine(account2.GetSavBalance().ToString("C2"));
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

                    switch (selectionKey)
                    {
                        case "a":
                            account3.GetChkBalance().ToString("C2");
                            Console.WriteLine("Your checking account balance is: " + account3.GetChkBalance().ToString("C2"));
                            AccountAnswer();
                            break;


                        case "b":

                            account2.GetSavBalance().ToString("C2");
                            Console.WriteLine("Your savings account balance is: " + account2.GetSavBalance().ToString("C2"));
                            AccountAnswer();
                            break;

                        default:
                            break;
                    }

                }
                else if (selectionKey == "3")
                {
                    Console.WriteLine("a. Checking Account\nb. Savings account");
                    string accountAnswer = Console.ReadLine().ToLower();
                    Console.Clear();
                    switch (accountAnswer)
                    {
                        case "a":
                            double tryParseDbl;
                            deposit = 0;
                            Console.Clear();
                            Console.WriteLine("How much would you like to deposit today " +
                                "in your checking account?");
                            depositAmount = Console.ReadLine().ToLower();
                            Exit();
                            while (double.TryParse(depositAmount, out tryParseDbl) == false)
                            {

                                Console.Write("Please enter a valid number or quit to exit: ");
                                depositAmount = Console.ReadLine().ToUpper();

                                Exit();

                                if (double.TryParse(depositAmount, out tryParseDbl) == true)
                                {
                                    deposit = double.Parse(depositAmount);
                                }

                            }
                            //deposit = double.TryParse(Console.ReadLine() out deposit);
                            account3.CheckingAccountBalance = account3.AddToChecking(deposit);
                            Console.WriteLine("Your new balance is :" +
                                account3.CheckingAccountBalance.ToString("C2"));

                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                            break;

                        case "b":

                            Console.WriteLine("How much would you like to deposit " +
                                "today in your savings account?");

                            deposit = double.Parse(Console.ReadLine());
                            account2.SavingsAccountBalance = account2.AddToSavingsAccount(deposit);
                            Console.WriteLine("Your new balance is :" +
                                account2.SavingsAccountBalance.ToString("C2"));

                            Console.WriteLine("Would you like to make another deposit?");
                            accountAnswer = Console.ReadLine().ToLower();
                            break;


                        default:

                            Console.WriteLine("Continue");
                            break;
                    }
                }
                else if (selectionKey == "4")
                {
                    Console.WriteLine("a. Checking Account\nb. Savings account");
                    string accountAnswer = Console.ReadLine().ToLower();
                    Console.Clear();
                    switch (accountAnswer)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("How much would you like to withdraw today " +
                                "in your checking account?");

                            withdraw = double.Parse(Console.ReadLine());
                            do
                            {

                                Console.WriteLine("Insuffient Funds.");
                                Console.WriteLine("Press enter a different amount or enter 'exit'.");
                                withdraw = double.Parse(Console.ReadLine());
                                Console.Clear();

                            } while (withdraw > account3.CheckingAccountBalance);

                            account3.CheckingAccountBalance = account3.SubtractFromChecking(withdraw);
                            Console.WriteLine("Your new balance is :" +
                                account3.CheckingAccountBalance.ToString("C2"));

                            Console.WriteLine("Would you like to make another withdraw?");
                            accountAnswer = Console.ReadLine().ToLower();
                            break;

                        case "b":

                            Console.WriteLine("How much would you like to withdraw " +
                                "today in your savings account?");

                            withdraw = double.Parse(Console.ReadLine());
                            do
                            {

                                Console.WriteLine("You may not withdraw below your minimum " +
                                    "balance of $" + minSavBalance);
                                Console.WriteLine("Press enter a different amount or enter 'exit'.");
                                withdraw = double.Parse(Console.ReadLine());
                                Console.Clear();

                            } while (withdraw > account2.SavingsAccountBalance - minSavBalance);

                            account2.SavingsAccountBalance = account2.SubtractFromChecking(withdraw);
                            Console.WriteLine("Your new balance is :" +
                                account2.SavingsAccountBalance.ToString("C2"));

                            Console.WriteLine("Would you like to make another withdraw?");
                            accountAnswer = Console.ReadLine().ToLower();
                            break;


                        default:

                            Console.WriteLine("Continue");
                            break;

                    }

                }
                else
                {
                    Exit();
                }

            } while (selectionKey != "5");
            Console.WriteLine("Please press the enter key" +
            " or to go back to the main menu or type 'Exit' to quit.");


            //} while (selectionKey != "5") ;


        }
        public static void Exit()
        {
            
            if (depositAmount == "exit")
            {
                Console.Clear();
                Console.WriteLine("Thank you for banking at Steal'em Robb'em Blind Bank!");
                Environment.Exit(0);
                return;
            }
        }
        public static void AccountAnswer()
        {
            string accountAnswer;
            Console.WriteLine("Please hit any key to continue");
            accountAnswer = Console.ReadLine().ToLower();
        }
    }
}
