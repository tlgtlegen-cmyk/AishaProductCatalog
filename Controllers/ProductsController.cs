using AURA.Repositories;
using AURA.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AURA.Controllers;

public class ProductsController : Controller
{
    private readonly ProductRepository _products;

    public ProductsController(ProductRepository products)
    {
        _products = products;
    }

    public IActionResult Index(string? q, string? category)
    {
        var products = _products.GetAll();
        var categories = _products.GetCategories();
        var selectedCategory = categories.FirstOrDefault(item =>
            string.Equals(item.Slug, category, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(category) && selectedCategory is null)
        {
            return NotFound();
        }

        if (!string.IsNullOrWhiteSpace(q))
        {
            products = products.Where(product =>
                product.Name.Contains(q, StringComparison.CurrentCultureIgnoreCase) ||
                product.Description.Contains(q, StringComparison.CurrentCultureIgnoreCase) ||
                product.Category.Name.Contains(q, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        if (selectedCategory is not null)
        {
            products = products.Where(product => product.Category.Slug == selectedCategory.Slug).ToList();
        }

        return View(new CatalogViewModel(products, categories, q?.Trim() ?? "", selectedCategory?.Slug ?? ""));
    }

    public IActionResult Details(int id)
    {
        var product = _products.GetById(id);
        return product is null ? NotFound() : View(product);
    }
}
