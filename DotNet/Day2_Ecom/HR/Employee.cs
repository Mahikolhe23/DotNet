namespace HR;

public abstract class Employee
{
    //setter and getter for employee
    public int ID { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public float DA { get; set; }
    public float HRA { get; set; }
    public float BasicSalary { get; set; }

    //default constructor
    public Employee()
        : this(1, "Mahi", "Kolhe", "mkolhe23@gmail.com", "7350458043", 1000, 10000, 15000) { }

    //parameterized constructor
    public Employee(
        int id,
        string firstname,
        string lastname,
        string email,
        string mobile,
        float da,
        float hra,
        float basic
    )
    {
        this.ID = id;
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Email = email;
        this.Mobile = mobile;
        this.DA = da;
        this.HRA = hra;
        this.BasicSalary = basic;
    }

    //abstract method
    public abstract void DoWork();

    //salary calculation method
    public virtual float ComputeSalary()
    {
        float pay = (DA * 25) + BasicSalary + HRA;
        return pay;
    }

    //display all method
    public override string ToString()
    {
        string str = string.Format(
            "ID = {0}, FirstName = {1}, LastName = {2}, Email = {3}, Mobile = {4}",
            ID,
            Firstname,
            Lastname,
            Email,
            Mobile
        );
        return str;
    }
}
