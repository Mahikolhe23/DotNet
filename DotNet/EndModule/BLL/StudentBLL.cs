namespace BLL;
using DAL;

public class StudentBLL
{
    public bool Insert(int roll, string name, string email, string city)
    {
        return StudentDAL.Insert(roll, name, email, city);
    }
}
