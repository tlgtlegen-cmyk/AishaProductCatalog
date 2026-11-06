using AURA.Models;
using AURA.Repositories;
using AURA.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AURA.Controllers;

public class HomeController : Controller
{
    private readonly ProductRepository _products;

    public HomeController(ProductRepository products)
    {
        _products = products;
    }

    public IActionResult Index()
    {
        var categories = _products.GetCategories();
        var featuredProducts = _products.GetAll().Take(3).ToList();

        return View(new HomeViewModel(featuredProducts, categories));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
