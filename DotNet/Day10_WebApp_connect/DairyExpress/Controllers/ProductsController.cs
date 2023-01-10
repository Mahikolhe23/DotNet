using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DairyExpress.Models;
using BLL;
using BOL;


namespace DairyExpress.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index(){

        CatalogManager p= new CatalogManager();
        List<Product> allProducts= p.GetProductFromFile();
        this.ViewData["products"]=allProducts;
        return View();
    }
    public IActionResult Detail(int id){
    CatalogManager p= new CatalogManager();
    Product product=p.GetProductByID(id);
    this.ViewData["product"]=product;
    return View(); 
    }
    public IActionResult Postinsert(int id,string name,string category,double price,string date,string desc){
        CatalogManager p= new CatalogManager();
        p.insert(id,name,category,price,date,desc);
        return Redirect("/Home/Index");
    }
    public IActionResult insert(){
        return View();
    }
}