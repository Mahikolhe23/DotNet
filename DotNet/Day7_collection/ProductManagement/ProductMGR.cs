using Products;
using System.Collections.Generic;

namespace ProductMGRS;

public class ProductMGR
{
    //sample data to perform Querry
    public List<Product> sampleData()
    {
        List<Product> products = new List<Product>();
        Product p1 = new Product(); //using default constructor
        products.Add(p1);
        products.Add(new Product(16, "Abc2", "Abc2", 100)); //using parameterise constructor
        products.Add(new Product(13, "Abc3", "Abc3", 500));
        products.Add(new Product(41, "Abc4", "Abc4", 1030));
        products.Add(new Product(5, "Abc5", "Abc5", 1400));
        products.Add(new Product(2, "Abc6", "Abc6", 50));
        return products;
    }
}
