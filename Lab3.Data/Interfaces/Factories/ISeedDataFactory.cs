using Lab3.DAL.Entities;

namespace Lab3.DAL.Interfaces.Factories;

public interface ISeedDataFactory
{
    IEnumerable<Product> GetProducts();
    IEnumerable<Supplier> GetSuppliers();
    IEnumerable<object> GetProductSupplierRelations();
}
