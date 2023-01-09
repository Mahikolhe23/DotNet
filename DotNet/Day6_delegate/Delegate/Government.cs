namespace Govern;

//delegate member
public delegate void Tax(int amount);

public class Government
{
    public void it(int amount)
    {
        Console.WriteLine("20% Tax ");
    }

    public void st(int amount)
    {
        Console.WriteLine("15% Tax");
    }

    public void pt(int amount)
    {
        Console.WriteLine("10% Tax");
    }
}
