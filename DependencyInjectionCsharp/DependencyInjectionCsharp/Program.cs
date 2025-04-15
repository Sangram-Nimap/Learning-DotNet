


using DependencyInjectionCsharp;

internal class Program
{
    // Using the tightly coupled Account class
    public static void Main(string[] args)
        {
            //Account ac = new Account();
            //ac.PrintAccounts();

        // Using the loosely coupled Account2 class
        IAccount savingAccount = new SavingAccount2();
        IAccount currentAccount = new CurrentAccount2();
        Account2 account2 = new Account2(currentAccount);
        Account2 account1 = new Account2(savingAccount);
        //acc.PrintDetails();
        account1.PrintAccounts();
        account2.PrintAccounts();
        Accounts n = new Accounts();
        n.Display(new SavingAccounts()); // Method Injection we have clla the object  of Saving  Accounts in our Methods 
        n.Display(new CurrentAccounts());
        




    }
                  
    
}