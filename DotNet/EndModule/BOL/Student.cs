namespace BOL;

public class Student
{
    public int Rollno { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? City { get; set; }

    public Student() { }

    public Student(int rollno, string name, string email, string city)
    {
        this.Rollno = rollno;
        this.Name = name;
        this.Email = email;
        this.City = city;
    }
}
