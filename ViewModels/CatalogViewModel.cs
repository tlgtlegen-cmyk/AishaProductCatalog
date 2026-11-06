using AURA.Models;

namespace AURA.ViewModels;

public sealed record CatalogViewModel(
    IReadOnlyList<Product> Products,
    IReadOnlyList<Category> Categories,
    string SearchTerm,
    string SelectedCategory);
