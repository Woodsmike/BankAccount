using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Intro
    {
        public void Introduction()
        {
            string userName;
            string password;

            do  //made this class to make the user input the correct logon information
            {
                Console.Clear();
                Console.WriteLine("________________________________________________" +
                "________________________________________________________________________\n\n");
                Console.WriteLine("\t\t\t\t\tWelcome to Steal'em Robb'em Blind Bank!\n\n\n");

                Console.WriteLine("\t\t\tPlease enter your UserName and Password\n\n\n");

                Console.Write("\t\t\tUserName: ");
                userName = Console.ReadLine();

                Console.Write("\n\n\t\t\tPassword: ");
                password = Console.ReadLine();


                Console.WriteLine("\n\n_________________________________________________" +
                "_______________________________________________________________________\n\n");
            } while (userName != "Capone" || password != "1");
        }
    }
}
