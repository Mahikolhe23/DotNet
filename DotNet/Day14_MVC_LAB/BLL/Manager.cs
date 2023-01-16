namespace BLL;
using DAL;

public class Manager
{
    public bool validateBL(string email, string password)
    {
        return DbManager.validateDL(email, password);
    }

    public bool RegisterBL(string name, string email, string password, int mobile)
    {
        return DbManager.RegisterBL(name, email, password, mobile);
    }
}
