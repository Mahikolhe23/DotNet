namespace dairyexpressAPI;
public class Product{
    public int Id {get;set;}
    public string Name{get;set;}
    public string Category{get;set;}
    public double Price{get;set;}
    public string Expdate{get;set;}
    
    public Product(int id,string name,string category , double price,string expdate){
        this.Id=id;
        this.Name=name;
        this.Category=category;
        this.Price=price;
        this.Expdate=expdate;
    }
}