namespace Lab3.DAL.Entities;

public class Supplier : BaseEntity
{
    public required string Name { get; set; }


    // Nav properties
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
