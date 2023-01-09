namespace Mgr;

public delegate void Bal(int amount);

public class Bankmgr
{
    public void blockacc(int amount)
    {
        Console.WriteLine("Acc is Block");
    }

    public void email(int amount)
    {
        Console.WriteLine("Email Send");
    }

    public void sms(int amount)
    {
        Console.WriteLine("SMS Send");
    }
}
