namespace BLL;
using DAL;
using BOL;

public class ProductMGRBLL
{
    public List<Product> GetAllProducts()
    {
        return ProductMGRDAL.GetAllProducts();
    }

    public Product GetProduct(int id)
    {
        return ProductMGRDAL.GetProduct(id);
    }

    public bool insert(string name, string category, double unit, string exp)
    {
        return ProductMGRDAL.insert(name, category, unit, exp);
    }
}
