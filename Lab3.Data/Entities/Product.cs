using System.ComponentModel.DataAnnotations;

namespace Lab3.DAL.Entities;

public class Product : BaseEntity
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    [Range(0, int.MaxValue)]
    public int InStock { get; set; }

    public decimal Price { get; set; }

    [Range(1, 100)]
    public int Discount { get; set; }

    // Nav properties
    public IEnumerable<Supplier> Suppliers { get; set; } = [];
}
