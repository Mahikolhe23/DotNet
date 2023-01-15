namespace DAL;
using dairyexpressAPI;
using MySql.Data.MySqlClient;

public class DbManager{

    static string connectPath =
        @"server=localhost;port=3306;user=root;password=root123;database=DairyExpress;";

    //get all user from db
    public static List<Product> GetAlluser()
    {
        List<Product> products = new List<Product>();
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
                Product u = new Product(id, name, email, password, mobile);
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
}