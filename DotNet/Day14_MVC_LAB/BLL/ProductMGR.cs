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

    public bool insert(int id, string name, string category, double unit, string exp)
    {
        return ProductMGRDAL.insert(id, name, category, unit, exp);
    }

    public void Update(int id, string name, string category, double unit, string exp)
    {
        ProductMGRDAL.Update(id, name, category, unit, exp);
    }

    public void Delete(int id)
    {
        ProductMGRDAL.Delete(id);
    }
}
