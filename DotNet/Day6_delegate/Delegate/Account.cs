namespace Bank;
using Govern;
using Mgr;

//POCO class
public class Account
{
    public event Tax overbal;
    public event Bal underBal;
    public int Balance { get; set; }

    //parameterized constructor
    public Account(int amount)
    {
        this.Balance = amount;
    }

    //deposit method
    public void deposit(int amount)
    {
        this.Balance += amount;
    }

    //withdraw method
    public void withdraw(int amount)
    {
        if (this.Balance < 5000)
            underBal(this.Balance);
        this.Balance -= amount;
    }

    //Tax Checking condition
    public void Process()
    {
        if (this.Balance >= 250000)
            overbal(this.Balance);
    }

    //dispplay balance
    public override string ToString()
    {
        return "Balance - " + this.Balance;
    }
}
