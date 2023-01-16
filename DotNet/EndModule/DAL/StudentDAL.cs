namespace DAL;
using MySql.Data.MySqlClient;
using BOL;

public class StudentDAL
{
    static string path = @"server=localhost;user=root;password=root123;port=3307;database=dotnet;";

    public static List<Student> Display()
    {
        List<Student> list = new List<Student>();
        
        
        
        
        
        
        return list;
    }

    public static bool Insert(int roll, string name, string email, string city)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = path;
        bool status = false;
        try
        {
            con.Open();
            string querry =
                "insert into student(rollno,name,email,city) values('"
                + roll
                + "','"
                + name
                + "','"
                + email
                + "','"
                + city
                + "')";
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            status = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return status;
    }
}
