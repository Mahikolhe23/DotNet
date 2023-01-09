namespace store.Models;
using store.Models;
using System.Collections.Generic;

public class ProductManager
{
    //sample data prodcuts
    public List<Product> sample()
    {
        Product p1 = new Product(1, "Milk", "Milk", "Dairy Req", 60);
        Product p2 = new Product(2, "Paneer", "Paneer", "test", 560);
        Product p3 = new Product(3, "Butter", "Butter", "mast", 200);
        Product p4 = new Product(4, "basundi", "basundi", "sweet", 360);
        List<Product> list = new List<Product>();
        list.Add(p1);
        list.Add(p2);
        list.Add(p3);
        list.Add(p4);
        return list;
    }
}
