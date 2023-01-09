namespace store.Models;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public  string Desc { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, string type, string desc, double price)
    {
        this.ID = id;
        this.Name = name;
        this.Type = type;
        this.Desc = desc;
        this.Price = price;
    }
}
