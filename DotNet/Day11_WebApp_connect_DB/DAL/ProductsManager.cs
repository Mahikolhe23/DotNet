namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class ProductsManager
{
    static string connectPath =
        @"server=localhost;port=3307;user=root;password=root123;database=DairyExpress;";

    public static List<Product> GetAllProductsFromDB()
    {
        List<Product> allProduct = new List<Product>();
        //1 connect to database
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectPath;
        //2 querry fire
        try
        {
            con.Open();
            string querry = "Select* from Products";
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            command.CommandText = querry;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString());
                string title = reader["title"].ToString();
                string category = reader["category"].ToString();
                double unitPrice = double.Parse(reader["unitPrice"].ToString());
                string expDate = reader["expDate"].ToString();

                Product product = new Product
                {
                    Id = id,
                    Title = title,
                    Catagory = category,
                    UnitPrice = unitPrice,
                    ExpDate = expDate
                };
                allProduct.Add(product);
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
        return allProduct;
    }

    public static Product GetProductByIdFromDB(int id)
    {
        List<Product> list = GetAllProductsFromDB();
        foreach (Product p in list)
        {
            if (p.Id == id)
                return p;
        }
        return null;
    }

    public static bool InsertProduct(
        string title,
        string category,
        double unitPrice,
        string expDate
    )
    {
        //1 connect to database
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectPath;
        bool status = false;
        //2 querry fire
        string querry =
            "insert into Products (title,category,unitPrice,expDate)"
            + "values('"
            + title
            + "','"
            + category
            + "','"
            + unitPrice
            + "','"
            + expDate
            + "')";
        try
        {
            con.Open();
            MySqlCommand command = new MySqlCommand(querry, con);
            command.ExecuteNonQuery(); //DML
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
