namespace Products;
using System.Collections;

//POCO Clas
public class Product : IComparable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }

    //default Constructor
    public Product()
    {
        this.Id = 1;
        this.Name = "Abc1";
        this.Type = "Abc1";
        this.Price = 100;
    }

    //parameterise constructor
    public Product(int id, string name, string type, double price)
    {
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.Price = price;
    }

    //over ride to string
    public override string ToString()
    {
        return "Id - "
            + this.Id
            + ", Name - "
            + this.Name
            + ", Type - "
            + this.Type
            + "  Price - "
            + this.Price;
    }

    //Natural ordering using IComparable interface and override compareTo method
    public int CompareTo(object? anathorProduct)
    {
        Product newProd = (Product)anathorProduct;
        if (this.Id > newProd.Id)
            return 1;
        else if (this.Id < newProd.Id)
            return -1;
        else
            return 0;
    }
}
