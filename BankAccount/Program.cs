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
            Intro intro1 = new Intro();  //Instantiated an object for the Sign in page
            MainMenu menu1 = new MainMenu();  //Instantiated an object for main menu
            MainMenu CheckSav = new MainMenu(); //Instantiated an object for the different
                                                 //checking and saving menus

            Client client1 = new Client("Capone", "Al", 6, " Feet Under Park",
                        2120010001, 0001, 1899, 1292094, 1359982); //Instantiated a new client object

            CheckingAccount account3 = new CheckingAccount();//Instantiated a new checking acct object
            SavingsAccount account2 = new SavingsAccount();//Instantiated a new savings acct object
            account3.AccountType = "Checking";
            account2.AccountType = "Savings";
            double deposit;
            double withdraw;
            string selectionKey = " ";
            int number = 0;

            intro1.Introduction();//Called the sign on screen method

            do    //ran entire program through a do-while loop, so the user can not exit until  
            {     //pressing the number 5
                Console.Clear();               
                menu1.MenuMethod();//called the method for the sign on page
                selectionKey = Console.ReadLine();
                Console.Clear();
                bool intResultTryParse = int.TryParse(selectionKey, out number);

                if (selectionKey == "1") // used an If Else-If condition for the 5 choices on main menu
                {
                    client1.ClientInfo();//called the method from the client class for their info
                    AccountAnswer();
                }
                else if (selectionKey == "2")
                {
                    CheckSav.ChckSavMenu(); // this method calls the menu to choose between checking and savings
                    selectionKey = Console.ReadLine();
                    Console.Clear();

                    switch (selectionKey)  // used the switch case for user to choose between checking/savings
                    {
                        case "a":                           
                            menu1.TopLine();  //called this method several times during program for top line on screen            
                            Console.WriteLine("\n\n\t\t\t\tYour Checking Account Balance: " 
                                + account3.GetChkBalance().ToString("C2"));  //used this method from the CheckingAccount 
                                                                              //to get the account balance
                            menu1.BottomLine();  //called this method several times during program for bottom line on screen
                            AccountAnswer(); //Method from below to ask user to press any key to continue
                            break;


                        case "b":                           
                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\t\tYour Savings Account Balance: " + 
                                account2.GetSavBalance().ToString("C2")); //used this method from the CheckingAccount 
                                                                          //to get the account balance
                            menu1.BottomLine();
                            AccountAnswer();
                            break;

                        default:
                            break;
                    }
                }
                else if (selectionKey == "3")
                {
                    CheckSav.ChckSavMenuDeposit(); //different method for menu selection
                    string checkOrSave = Console.ReadLine().ToLower();
                    Console.Clear();
                    switch (checkOrSave) //used a switch case for user to pick between check/savings
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
                            account3.CheckingAccountBalance = account3.AddToChecking(deposit);//used this operation to save the checking account balance
                            Console.WriteLine("\n\n\t\t\tYour new balance is: " +
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
                            account2.SavingsAccountBalance = account2.AddToSavingsAccount(deposit);//used this to save the savings balance
                            Console.WriteLine("\n\n\t\t\tYour new balance is: " +
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
                    CheckSav.ChckSavMenuWithdraw(); //different method for withdrawal selection
                    string checkOrSave = Console.ReadLine().ToLower();
                    Console.Clear();
                    switch (checkOrSave) //same case for withdrawals as was for checking
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

                            do  //used this conditional to check for insufficient funds
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
                            //if sufficient funds then I subtracted from the account  ^^^
                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tYour New Balance: " +
                                account3.CheckingAccountBalance.ToString("C2"));
                            menu1.BottomLine();

                            AccountAnswer();
                            break;

                        case "b":
                            double minSavBal = account2.SavingsAccountBalance - 500; //equation to find minimum balance
                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tHow much would you like to withdraw " +
                                "today in your savings account?");
                            Console.Write("\n\n\t\t\tWithdraw Amount: ");
                            withdraw = double.Parse(Console.ReadLine());
                            menu1.BottomLine();

                            Console.Clear();
                            do    // used this conditional to check for insufficient funds
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
                            //if sufficient funds then I subtracted from the account  ^^^
                            menu1.TopLine();
                            Console.WriteLine("\n\n\t\t\tYour New Balance: " +
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

        public static void Exit()  //used when user pressed '5' on main menu
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

        public static void AccountAnswer()  //used throughout program
        {
            string accountAnswer;
            Console.WriteLine("Please any key to continue");
            accountAnswer = Console.ReadLine().ToLower();
        }
    }
}
