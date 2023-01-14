namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DbManager
{
    static string connectPath =
        @"server=localhost;port=3307;user=root;password=root123;database=DairyExpress;";

    //get all user from db
    public static List<User> GetAlluser()
    {
        List<User> users = new List<User>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectPath;
        try
        {
            con.Open();
            string querry = "select* from user";
            MySqlCommand cmd = new MySqlCommand(querry, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["Name"].ToString();
                string email = reader["Email"].ToString();
                string password = reader["Password"].ToString();
                int mobile = int.Parse(reader["Mobile"].ToString());
                User u = new User(id, name, email, password, mobile);
                users.Add(u);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return users;
    }

    public static bool validateDL(string email, string password)
    {
        List<User> users = GetAlluser();
        foreach (User user in users)
        {
            if (user.Email.Equals(email) && user.Password.Equals(password))
                return true;
        }
        return false;
    }

    public static bool RegisterBL(string name, string email, string password, int mobile)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectPath;
        bool status = false;
        try
        {
            con.Open();
            string querry =
                "insert into user(name,email,password,mobile) values(' "
                + name
                + "','"
                + email
                + "','"
                + password
                + "','"
                + mobile
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
