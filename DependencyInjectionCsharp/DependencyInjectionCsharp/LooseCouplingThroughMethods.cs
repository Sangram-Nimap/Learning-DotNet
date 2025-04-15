using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dependency injection through Methods 

namespace DependencyInjectionCsharp
{
    public interface IAccount2
    {
        void PrintDetails();
    }
    class SavingAccounts : IAccount2
    {
        public void PrintDetails()
        {
            Console.WriteLine("class SavingAccount");
        }
    }
    class CurrentAccounts : IAccount2
    {
        public void PrintDetails()
        {
            Console.WriteLine("here is Current Accounts ");
        }
    }

    class Accounts
    {

        public void Display(IAccount2 account)
        {
            account.PrintDetails();

        }
    }
    internal class LooseCouplingThroughMethods
    {

    }
}

