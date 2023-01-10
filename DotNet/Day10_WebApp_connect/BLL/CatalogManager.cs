namespace BLL;
using BOL;
using DAL;

public class CatalogManager
{
    public List<Product> GetAllProducts()
    {
        List<Product> allProducts = new List<Product>();
        allProducts = ProductsManager.GetProductFromFile();
        return allProducts;
    }

    public Product GetProductByID(int id)
    {
        Product product = ProductsManager.GetProductByID(id);
        return product;
    }

    public List<Product> GetProductFromFile()
    {
        List<Product> allproducts = new List<Product>();
        allproducts = ProductsManager.GetProductFromFile();
        return allproducts;
    }

    public bool insert(int id, string name, string category, double price, string date, string desc)
    {
        bool ans = ProductsManager.insert(id, name, category, price, date, desc);
            return ans;
    }
}
