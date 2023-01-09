namespace HR;

public class SalesEmp : Employee
{
    public float Target { get; set; }
    public float Sales { get; set; }
    public float Incetive { get; set; }

    //default constructor
    public SalesEmp() : base()
    {
        this.Target = 0;
        this.Sales = 0;
        this.Incetive = 0;
    }

    //parameterized constructor
    public SalesEmp(
        int id,
        string firstname,
        string lastname,
        string email,
        string mobile,
        float da,
        float hra,
        float basic,
        float target,
        float sales
    ) : base(id, firstname, lastname, email, mobile, da, hra, basic)
    {
        this.Target = target;
        this.Sales = sales;
        this.Incetive = 0;
    }

    //over ride Dowork method to meet sales target
    public override void DoWork()
    {
        if (Sales >= Target)
            this.Incetive = 5000;
        else
            this.Incetive = 0;
    }

    //over ride salary calculation method from parent
    public override float ComputeSalary()
    {
        return base.ComputeSalary() + Incetive;
    }

    //over ride to string to display method
    public override string ToString()
    {
        return base.ToString() + " Incetive = " + Incetive + " Target = " + Target;
    }
}
