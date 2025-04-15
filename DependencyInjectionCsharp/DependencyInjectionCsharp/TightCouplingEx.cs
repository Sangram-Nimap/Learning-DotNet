using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionCsharp
{
    public class TightCouplingEx
    { }
    public class CurrentAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current Account ");
        }

    }
    public class SavingAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Saving Accounts");
        }
    }
    public class Account
    {
        CurrentAccount ca = new CurrentAccount();
        SavingAccount sa = new SavingAccount();

        public void PrintAccounts()
        {
            ca.PrintDetails();
            sa.PrintDetails();
        }
    }
}
