namespace AURA.Models;

public sealed record Product(
    int Id,
    string Name,
    string Description,
    decimal Price,
    Category Category,
    string ImageUrl,
    bool IsAvailable);
