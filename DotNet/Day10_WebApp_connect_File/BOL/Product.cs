namespace BOL;
public class Product
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Catagory{get;set;}
    public string Description{get;set;}
    public double UnitPrice{get;set;}
    public string ExpDate{get;set;}
    
    public Product(int id,string name,string catagory,string description,double unitPrice,string expDate){
        this.Id=id;
        this.Name=name;
        this.Catagory=catagory;
        this.Description=description;
        this.UnitPrice=unitPrice;
        this.ExpDate=expDate;
    }
}
