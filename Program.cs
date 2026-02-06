using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
public class Program
{//simualted cage frmo teamate o github
            public static void doIt(Account a, int total)
    {
        a.Withdraw(50);
        total--;
    }
    
        public static void Test(int? x)
    {
        if (x != null)
        {
            Console.WriteLine(x);
        }
        else
            Console.WriteLine("x does not havce a value");
    }
    static void Main(string[] args)
    {
        /*Console.WriteLine("Testing account one");
        Account myAccount = new Account(300, "Account1");
        myAccount.Show();
        Console.WriteLine("Going to withdraw 400 from account 1");
        myAccount.Withdraw(400);
        myAccount.Show();
        myAccount.Withdraw(200);
        myAccount.Show();
        myAccount.Deposit(600);
        myAccount.Show();
        Console.WriteLine("Testing account 2");
        Account account2 = new Account(500, "Account2");
        myAccount.Transfer(account2, 10000);
        myAccount.Show();
        account2.Show();
        myAccount.Transfer(account2, 100);
        account2.Show();
        myAccount.Show();*/

        // Account testAccount = new Account(400, "ACC TEST");
        // testAccount.Balance = 10;
        // Console.WriteLine(testAccount.Balance);
        // testAccount.Balance = -10;
        // Console.WriteLine(testAccount.Balance);
        // Console.WriteLine(testAccount.OwnerAcc);





        /* Account a1 = new Account(100, "bob");
         int totalAssets = 1000;
         doIt(a1, totalAssets);
         Console.WriteLine("after doIt:");
         a1.Show();
         Console.WriteLine($"total assets is now {totalAssets}");*/

        /* int? x1 = 20;
         int? x2 = null;
         Test(x1);
         Test(x2);8*/

        Account? referenceVar = null;
        Console.WriteLine("mainchange branch :(");
        Console.WriteLine("rat");
        

    }


}

