namespace BOL;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Mobile { get; set; }

    public User(int id, string name, string email, string password, int mobile)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.Password = password;
        this.Mobile = mobile;
    }
    public User(){
        
    }
}
