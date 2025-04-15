using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Loose coupling with Constructor 
namespace DependencyInjectionCsharp
{
    public interface IAccount // interface 
    {
        void PrintDetails();
    }
  public  class CurrentAccount2 : IAccount  //  first implimentation method of interface
    {
      
       public  void PrintDetails()
        {
            Console.WriteLine("details of current ");
        }

        
    }
   public class SavingAccount2 : IAccount  //  second implimentation method of interface
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of saving account  ");
        }

       
    }


    public class Account2 {
        private IAccount account;
        public Account2(IAccount account)  // parameterized  Constructor  
        {
            this.account = account;
        }
        public void PrintAccounts()
        {
          account.PrintDetails();   
        }

        
    }

    internal class LooseCouplingConstructor
    {
    }
}
/* another example of constructor injection 

public interface IAccount
{
    public void Display();
}
class a : IAccount
{
    public void Display()
    {
        Console.WriteLine("class a");
    }
}
class b : IAccount
{
    public void Display()
    {
        Console.WriteLine("class b ");
    }
}

class Program
{
    IAccount account;
    public Program(IAccount account)
    {
        this.account = account;
    }
    public void Display()
    {
        account.Display();
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        IAccount n = new b();
        IAccount g = new a();
        Program h = new Program(g);
        h.Display();
    }
}*/