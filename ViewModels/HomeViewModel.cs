using AURA.Models;

namespace AURA.ViewModels;

public sealed record HomeViewModel(
    IReadOnlyList<Product> FeaturedProducts,
    IReadOnlyList<Category> Categories);
