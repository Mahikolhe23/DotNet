using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dairyexpress.Models;
using BLL;
using BOL;

namespace dairyexpress.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Catalog()
    {
        ProductMGRBLL mgr = new ProductMGRBLL();
        List<Product> list = mgr.GetAllProducts();
        ViewData["products"] = list;
        return View();
    }

    public IActionResult Detail(int id)
    {
        ProductMGRBLL mgr = new ProductMGRBLL();
        Product product = mgr.GetProduct(id);
        this.ViewData["product"] = product;
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id, string name, string category, double unit, string exp)
    {
        ProductMGRBLL mgr = new ProductMGRBLL();
        bool ans = mgr.insert(id, name, category, unit, exp);
        if (ans)
            return RedirectToAction("Catalog");
        return Redirect("/Home/Welcome");
    }

    public IActionResult Update(int id)
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(int id, string name, string category, double unit, string exp)
    {
        ProductMGRBLL mgr = new ProductMGRBLL();
        mgr.Update(id, name, category, unit, exp);
        return RedirectToAction("Catalog");
    }

    public IActionResult Delete(int id)
    {
        ProductMGRBLL mgr = new ProductMGRBLL();
        mgr.Delete(id);
        return RedirectToAction("Catalog");
    }
}
