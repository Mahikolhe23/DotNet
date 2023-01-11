namespace DAL;
using System.Text.Json;
using BOL;

public class ProductsManager
{
    //Sample data for operation
    static string filepath =
        @"H:\Mahendra_Sujay\DotNet\DotNet\Day10_WebApp_connect\DairyExpress\wwwroot\databases\products.json";

    public static List<Product> GetAllProductsHARDCODE()
    {
        List<Product> allProduct = new List<Product>();
        allProduct.Add(new Product(1, "Mother Dairy Tadka Chach", "Milk", "Best Buttermilk", 60, "2 days"));
        allProduct.Add(new Product(2, "Mother Dairy Lassi", "Lassi", "Tastiest Lassi", 20, "12 days"));
        allProduct.Add(new Product(3, "Amul Premium Dahi", "Dahi", " Creamiest Packaged Dahi", 65, "2 days"));
        allProduct.Add(new Product(4,"Mother Dairy Fresh Paneer","Paneer"," Creamiest And Tastiest Paneer",50,"5 days"));
        allProduct.Add(new Product(5, "Amul Cheese Slices", "Paneer", " Best Cheese Slices", 100, "15 days"));
        allProduct.Add(new Product(6,"Mother Dairy Kesar Elaichi Flavored Milk","Milk"," Creamiest Milk",150,"5 days"));
        return allProduct;
    }

    public static bool storeProductTOFile(List<Product> list)
    {
        //store data to file
        var options = new JsonSerializerOptions { IncludeFields = true };
        var productlist = JsonSerializer.Serialize(list, options);
        File.WriteAllText(filepath, productlist);
        return true;
    }

    public static List<Product> GetProductFromFile()
    {
        //restore data from file
        string products = File.ReadAllText(filepath);
        List<Product>? list = JsonSerializer.Deserialize<List<Product>>(products);
        return list;
    }

    public static Product GetProductByID(int id)
    {
        List<Product> list = GetProductFromFile();
        Product? product = list.Find((productfind) => productfind.Id == id);
        // foreach(Product p in list){
        //     if(p.Id==id)
        //     return p;
        // }
        return product;
    }

    public static bool insert(int id,string name,string category,double price,string date,string desc)
    {

         List<Product> list =GetProductFromFile();
        list.Add(new Product(id, category, name, desc, price, date));
        return  storeProductTOFile(list);
    }
}
