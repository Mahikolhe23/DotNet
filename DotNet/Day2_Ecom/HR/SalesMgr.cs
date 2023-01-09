namespace HR;

public class SalesMgr : SalesEmp
{
    public float Bonus{get;set;}

    //default constructor
    public SalesMgr() : base()
    {
        this.Bonus = 0;
    }

    //parameterised constructor
    public SalesMgr(
        int id,
        string firstname,
        string lastname,
        string email,
        string mobile,
        float da,
        float hra,
        float basic,
        float target,
        float sales,
        float bonus
    ) : base(id, firstname, lastname, email, mobile, da, hra, basic, target, sales)
    {
        this.Bonus = bonus;
    }
    //over ride compute method
    public override float ComputeSalary()
    {
        return base.ComputeSalary() + Bonus;
    }
    //over ride dowork
    public override void DoWork()
    {
        base.DoWork();
    }
    //over ride to string
    public override string ToString()
    {
        return base.ToString() + " Bonus = " + Bonus;
    }
}
