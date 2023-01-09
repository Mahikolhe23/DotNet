namespace USERNAME;

public class User
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Contactnumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string firstname, string lastname, int contactnumber, string email, string password)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Contactnumber = contactnumber;
        this.Email = email;
        this.Password = password;
    }
}
