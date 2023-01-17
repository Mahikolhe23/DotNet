namespace DAL;
using BOL;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class ProductMGRDAL
{
    static string conpath =
        @"server=localhost;port=3306;user=root;password=root123;database=dairyexpress;";

    public static List<Product> GetAllProducts()
    {
        List<Product> list = new List<Product>();
        //connection to db
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        //fire query
        try
        {
            con.Open();
            string query = "select* from products";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString());
                string? name = reader["title"].ToString();
                string? category = reader["Category"].ToString();
                double unitPrice = double.Parse(reader["UnitPrice"].ToString());
                string? expDate = reader["expDate"].ToString();
                Product p = new Product(id, name, category, unitPrice, expDate);
                list.Add(p);
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
        return list;
    }

    public static Product GetProduct(int id)
    {
        List<Product> list = GetAllProducts();
        foreach (Product p in list)
        {
            if (p.Id == id)
                return p;
        }
        return null;
    }

    public static bool insert(int id, string name, string category, double unit, string exp)
    {
        //connect to db
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        //fire query
        bool ans = false;
        try
        {
            con.Open();
            string query =
                "insert into products(id,title,category,unitprice,expdate) values('"
                + id
                + "','"
                + name
                + "','"
                + category
                + "','"
                + unit
                + "','"
                + exp
                + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            ans = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return ans;
    }

    public static void Delete(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        try
        {
            con.Open();
            string query = "delete from products where id=" + id;
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

    public static void Update(int id, string name, string category, double unit, string exp)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        try
        {
            con.Open();
            string query =
                "update products set title='"
                + name
                + "',category='"
                + category
                + "',unitprice='"
                + unit
                + "',expdate='"
                + exp
                + "' where Id="
                + id;
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }
}
