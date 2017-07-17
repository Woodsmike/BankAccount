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
           
            Console.Clear();
            Intro intro1 = new Intro();
            MainMenu menu1 = new MainMenu();
            MainMenu CheckSav = new MainMenu();            

            Client client1 = new Client("Capone", "Al", 6, " Feet Under Park",
                        2120010001, 0001, 1899, 129094, 139982);

            CheckingAccount account3 = new CheckingAccount();
            SavingsAccount account2 = new SavingsAccount();
            account3.CheckingAccountBalance = 25000;
            account2.SavingsAccountBalance = 500000;
            account3.AccountType = "Checking";
            account2.AccountType = "Savings";
            double deposit;
            double withdraw;
            string selectionKey = " ";
            int number = 0;

            intro1.Introduction();
            do
            {
                Console.Clear();               
                menu1.MenuMethod();
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
                    CheckSav.ChckSavMenu();
                    //Console.WriteLine("a. Checking Account\nb. Savings account");
                    //selectionKey = Console.ReadLine();
                    selectionKey = Console.ReadLine();
                    Console.Clear();

                    switch (selectionKey)
                    {
                        case "a":
                            account3.GetChkBalance().ToString("C2");

                            menu1.TopLine();              
                            Console.WriteLine("\n\n\t\t\t\tYour Checking Account Balance: " 
                                + account3.GetChkBalance().ToString("C2"));                            
                            menu1.BottomLine();

                            AccountAnswer();
                            break;


                        case "b":
                            account2.GetSavBalance().ToString("C2");

                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\t\tYour Savings Account Balance: " + 
                                account2.GetSavBalance().ToString("C2"));
                            menu1.BottomLine();

                            AccountAnswer();
                            break;

                        default:
                            break;
                    }
                }
                else if (selectionKey == "3")
                {
                    CheckSav.ChckSavMenuDeposit();
                    string checkOrSave = Console.ReadLine().ToLower();
                    Console.Clear();
                    switch (checkOrSave)
                    {
                        case "a":
                            Console.Clear();

                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tHow much would you like to deposit today " +
                                "in your checking account?");

                            Console.Write("\n\n\t\t\tDeposit Amount: ");
                            deposit = double.Parse(Console.ReadLine());
                            menu1.BottomLine();

                            Console.Clear();
                            menu1.TopLine();
                            account3.CheckingAccountBalance = account3.AddToChecking(deposit);
                            Console.WriteLine("\n\n\t\t\tYour new balance is :" +
                                account3.CheckingAccountBalance.ToString("C2"));
                            menu1.BottomLine();

                            AccountAnswer();
                            break;

                        case "b":
                            Console.Clear();

                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tHow much would you like to deposit " +
                                "today in your savings account?");

                            Console.Write("\n\n\t\t\tDeposit Amount: ");
                            deposit = double.Parse(Console.ReadLine());
                            menu1.BottomLine();

                            Console.Clear();
                            menu1.TopLine();
                            account2.SavingsAccountBalance = account2.AddToSavingsAccount(deposit);
                            Console.WriteLine("\n\n\t\t\tYour new balance is :" +
                                account2.SavingsAccountBalance.ToString("C2"));
                            menu1.BottomLine();

                            AccountAnswer();
                            break;


                        default:
                            AccountAnswer();
                            break;
                    }
                }
                else if (selectionKey == "4")
                {
                    CheckSav.ChckSavMenuWithdraw();
                    string checkOrSave = Console.ReadLine().ToLower();
                    Console.Clear();
                    switch (checkOrSave)
                    {
                        case "a":
                            Console.Clear();
                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tHow much would you like to withdraw today " +
                                "in your checking account?");
                            Console.Write("\n\n\t\t\tWithdraw Amount: ");
                            withdraw = double.Parse(Console.ReadLine());
                            menu1.BottomLine();
                            Console.Clear();

                            do
                            {
                                if (withdraw > account3.CheckingAccountBalance)
                                {
                                    menu1.TopLine();
                                    Console.WriteLine("\n\n\t\t\t\t\t\tINSUFFICIENT FUNDS");
                                    Console.WriteLine("\n\n\n\t\t\t\tAmount available for withdrawal: " +
                                        account3.CheckingAccountBalance.ToString("C2"));
                                    Console.Write("\n\t\t\t\tPlease enter a different amount.\n\n" +
                                        "\t\t\t\tWithdraw Amount: ");
                                    withdraw = double.Parse(Console.ReadLine());
                                    menu1.BottomLine();

                                    Console.Clear();
                                }
                            } while (withdraw > account3.CheckingAccountBalance);

                            account3.CheckingAccountBalance = account3.SubtractFromChecking(withdraw);

                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tYour new balance is :" +
                                account3.CheckingAccountBalance.ToString("C2"));
                            menu1.BottomLine();

                            AccountAnswer();
                            break;

                        case "b":
                            double minSavBal = account2.SavingsAccountBalance - 500;
                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tHow much would you like to withdraw " +
                                "today in your savings account?");
                            Console.Write("\n\n\t\t\tWithdraw Amount: ");
                            withdraw = double.Parse(Console.ReadLine());
                            menu1.BottomLine();

                            Console.Clear();
                            do
                            {
                                if (withdraw > minSavBal)
                                {
                                    menu1.TopLine();
                                    Console.WriteLine("\n\n\t\t\t\t\t\tINSUFFICIENT FUNDS");
                                    Console.WriteLine("\n\n\n\t\t\t\tAmount available for withdrawal: " +
                                        minSavBal.ToString("C2"));
                                    Console.Write("\n\t\t\t\tPlease enter a different amount.\n\n" +
                                       "\t\t\t\tWithdraw Amount: ");
                                    withdraw = double.Parse(Console.ReadLine());
                                    menu1.BottomLine();
                                    Console.Clear();
                                }
                            } while (withdraw > minSavBal);
                            
                            account2.SavingsAccountBalance = account2.SubtractFromSavings(withdraw);
                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tYour New Balance :" +
                                account2.SavingsAccountBalance.ToString("C2"));
                            menu1.BottomLine();

                            AccountAnswer();
                            break;

                        default:
                            Console.WriteLine("\n\n\t\t\tContinue");
                            break;
                    }
                }
                else if(selectionKey == "5")
                {
                    Exit();
                }
                else
                {
                    AccountAnswer();
                }
            } while (selectionKey != "5");     
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("________________________________________________" +
               "________________________________________________________________________\n\n");
            Console.WriteLine("\n\n\t\t\tThank you for banking at Steal'em Robb'em Blind Bank!");
            Console.WriteLine("\n\n_________________________________________________" +
           "_______________________________________________________________________\n\n");
            Environment.Exit(0);
            return;
        }

        public static void AccountAnswer()
        {
            string accountAnswer;
            Console.WriteLine("Please any key to continue");
            accountAnswer = Console.ReadLine().ToLower();
        }
    }
}
