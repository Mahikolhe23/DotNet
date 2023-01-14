namespace BLL;
using BOL;
using DAL;

public class CatalogManager
{
    public List<Product> GetAllProducts()
    {
        List<Product> allProducts = new List<Product>();
        allProducts = ProductsManager.GetAllProductsFromDB();
        return allProducts;
    }

    public Product GetProductById(int id)
    {
        Product product = new Product();
        product = ProductsManager.GetProductByIdFromDB(id);
        return product;
    }

    public bool InsertProduct(string title, string category, double unitPrice, DateOnly expDate)
    {
        return ProductsManager.InsertProduct(title, category, unitPrice, expDate);
    }
}
