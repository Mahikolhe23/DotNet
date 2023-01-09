using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using store.Models;
using System.Collections.Generic;

namespace store.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ProductManager p1 = new ProductManager();
        List<Product> list = p1.sample();
        ViewData["catalog"] = list;
        return View();
    }
}
