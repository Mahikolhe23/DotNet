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

    public IActionResult Index()
    {
        CatalogManager p = new CatalogManager();
        List<Product> allProducts = p.GetAllProducts();
        this.ViewData["products"] = allProducts;
        return View();
    }

    public IActionResult Detail(int id)
    {
        CatalogManager p = new CatalogManager();
        Product product = p.GetProductById(id);
        this.ViewData["product"] = product;
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Postinsert(string title, string category, double unitPrice, DateOnly Date)
    {
        CatalogManager p = new CatalogManager();
        bool ans = p.InsertProduct(title, category, unitPrice, Date);
        if (ans)
            return Redirect("/Home/Index");
        return RedirectToAction("Insert");
    }
}
