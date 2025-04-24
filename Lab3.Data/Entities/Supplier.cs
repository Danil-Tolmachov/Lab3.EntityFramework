namespace Lab3.DAL.Entities;

public class Supplier : BaseEntity
{
    public required string Name { get; set; }


    // Nav properties
    public IEnumerable<Product> Products { get; set; } = [];
}
