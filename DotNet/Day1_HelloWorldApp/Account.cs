namespace Banking;

//create class of account
public class Account
{
    //declare data member
    private float balance = 1000;

    //create getter method
    public float getBalance()
    {
        return this.balance;
    }

    //creating setter method
    public void setBalance(float amount)
    {
        this.balance = amount;
    }

    //constructor overloading
    public Account()
    {
        this.balance = 1000;
    }

    public Account(float balance)
    {
        this.balance = balance;
    }

    //deposit method
    public void Deposit(float amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be greater than 0");
        }
        this.balance += amount;
    }

    //withdraw method
    public void Withdraw(float amount)
    {
        if (amount <= 0 || amount > balance)
        {
            Console.WriteLine("Amount must be greater than 0");
        }
        this.balance -= amount;
    }

    //destructor for class
    ~Account()
    {
        //deinitialization
    }
}
