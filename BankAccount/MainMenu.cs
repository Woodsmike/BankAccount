using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class MainMenu
    {
        public void MenuMethod()  //Main menu method
        {
            Console.WriteLine("________________________________________________" +
                "________________________________________________________________________\n\n");
            Console.WriteLine("\t\t\t\t\t\tMAIN MENU:\n\n\n\n\n");
            Console.WriteLine("\t\t\t\tPlease choose from the following options.\n\n");
            Console.WriteLine("\t\t\t\t1. View Client Information\n");
            Console.WriteLine("\t\t\t\t2. View Account Balance\n");
            Console.WriteLine("\t\t\t\t3. Deposit Funds\n");
            Console.WriteLine("\t\t\t\t4. Withdraw Funds\n");
            Console.WriteLine("\t\t\t\t5. Exit\n\n\n");
            Console.WriteLine("\n\n_________________________________________________" +
                "_______________________________________________________________________\n\n");
        }

        public void ChckSavMenu()  //the next 3 methods is to tell the user to choose between check/savings
        {           
            Console.WriteLine("________________________________________________" +
                "________________________________________________________________________\n\n");

            Console.WriteLine("\t\t\t\t Please choose the account to see your balance.\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t  a. Checking Account\n\n\t\t\t\t\t  b. Savings Account");
            //selectionKey = Console.ReadLine();
            Console.WriteLine("\n\n_________________________________________________" +
                "_______________________________________________________________________\n\n");
        }

        public void ChckSavMenuDeposit()
        {
            Console.WriteLine("________________________________________________" +
                "________________________________________________________________________\n\n");

            Console.WriteLine("\t\t\t\t Please choose the account to make your deposit.\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t  a. Checking Account\n\n\t\t\t\t\t  b. Savings Account");
            //selectionKey = Console.ReadLine();
            Console.WriteLine("\n\n_________________________________________________" +
                "_______________________________________________________________________\n\n");
        }

        public void ChckSavMenuWithdraw()
        {
            Console.WriteLine("________________________________________________" +
                "________________________________________________________________________\n\n");

            Console.WriteLine("\t\t\t\t Please choose the account to make your withdraw.\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t  a. Checking Account\n\n\t\t\t\t\t  b. Savings Account");
            Console.WriteLine("\n\n_________________________________________________" +
                "_______________________________________________________________________\n\n");
        }

        public void TopLine()  //used throughout program to box in sections
        {
            Console.WriteLine("________________________________________________" +
                "________________________________________________________________________\n\n");
        }

        public void BottomLine()  //used throughout program to box in sections
        {
            Console.WriteLine("\n\n________________________________________________" +
                "________________________________________________________________________\n\n");
        }
    }
}

