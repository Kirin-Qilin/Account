using System.Dynamic;
using System.Globalization;

public class Account
{
    private float balance;
    private string ownerAcc;

    public float Balance
    {
        get { return balance; }
        set{if (value >= 0){balance = value;} }
    }
    public string OwnerAcc
    {
        get{ return ownerAcc; }
    }
    

    public Account(float balance, string ownerAcc)
    {
        this.balance = balance;
        this.ownerAcc = ownerAcc;
    }

    public void Show()
    {
        Console.WriteLine($"Balance: {balance}  Account Name:  {ownerAcc}");
        Console.WriteLine("yoasdfasfsdfasdfasdf i gott=a change more ig asdfooo");
        Console.WriteLine("another line added ig");
    }
    public float Deposit(float amount)
    {
        balance += amount;
        return balance;
    }

    public float GetBalance()
    {
        return balance;
    }

    public bool Withdraw(float amount)
    {
        if (balance - amount < 0)
        {
            //Console.WriteLine("insufficiant funds");
            return false;
        }

        else
        {
            balance -= amount;
            return true;
        }

    }

    

 


    public bool Transfer(Account accountDos, float amount)
    {
        if (balance - amount < 0)
        {
            return false;
        }
        else
        {
            balance = balance - amount;
            accountDos.balance += amount;
            return true;
        }
    }
}
