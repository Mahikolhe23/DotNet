namespace BLL;
using DAL;

public class Manager
{
    public bool validateBL(string email, string password)
    {
        if (DbManager.validateDL(email, password))
            return true;
        return false;
    }

    public bool RegisterBL(string name, string email, string password, int mobile)
    {
        if (DbManager.RegisterBL(name, email, password, mobile))
            return true;
        return false;
    }
}
