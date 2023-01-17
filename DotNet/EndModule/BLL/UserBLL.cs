namespace BLL;
using DAL;
using BOL;
public class UserBLL
{
    public bool Login(string email,string password){
     return UserDAL.Login(email,password);
    }
    public bool Register(string name,string email,string password){
        return UserDAL.Register(name,email,password);
    }
}
