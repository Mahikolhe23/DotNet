namespace BLL;
using DAL;
using BOL;
public class StudentBLL
{
    public bool Insert(int roll, string name, string email, string city)
    {
        return StudentDAL.Insert(roll, name, email, city);
    }
    public void Update(int rollno, string name, string email, string city)
    {
        StudentDAL.Update(rollno, name, email, city);
    }

    public List<Student> Display(){
        return StudentDAL.Display();
    }
    public Student GetStudentByRollNo(int rollno){
        return StudentDAL.GetStudentByRollNo(rollno);
    }
    public void Delete(int rollno){
        StudentDAL.Delete(rollno);
    }
}
