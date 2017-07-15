using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class ClientBase
    {
        public virtual void SearchAccount(string lastName, string firstName,
          int lastFourOfSocial, int birthYear)
        {

        }
    }
}
