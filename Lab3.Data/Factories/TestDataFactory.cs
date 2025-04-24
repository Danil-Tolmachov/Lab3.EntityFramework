using Lab3.DAL.Entities;
using Lab3.DAL.Interfaces.Factories;

namespace Lab3.DAL.Factories;

public class TestDataFactory : ISeedDataFactory
{
    private readonly IEnumerable<Guid> _productGuids = Enumerable.Range(0, 5)
                                                                 .Select(_ => Guid.NewGuid())
                                                                 .ToList();

    private readonly IEnumerable<Guid> _suppliersGuids = Enumerable.Range(0, 2)
                                                                   .Select(_ => Guid.NewGuid())
                                                                   .ToList();

    public IEnumerable<Product> GetProducts()
    {
        var products = new List<Product>
        {
            new() {
                Id = _productGuids.ElementAt(0),
                Name = "Wireless Headphones",
                Description = "Bluetooth noise-cancelling over-ear headphones.",
                InStock = 50,
                Price = 149.99m,
                Discount = 10,
            },
            new()
            {
                Id = _productGuids.ElementAt(1),
                Name = "Gaming Mouse",
                Description = "High-precision RGB gaming mouse with adjustable DPI.",
                InStock = 120,
                Price = 59.99m,
                Discount = 15,
            },
            new()
            {
                Id = _productGuids.ElementAt(2),
                Name = "Smartwatch",
                Description = "Fitness tracking smartwatch with heart-rate monitoring.",
                InStock = 75,
                Price = 199.50m,
                Discount = 5,
            },
            new()
            {
                Id = _productGuids.ElementAt(3),
                Name = "Portable Charger",
                Description = "10000mAh power bank with fast charging capability.",
                InStock = 200,
                Price = 29.95m,
                Discount = 20,
            },
            new()
            {
                Id = _productGuids.ElementAt(4),
                Name = "LED Desk Lamp",
                Description = "Dimmable LED lamp with touch controls and USB charging port.",
                InStock = 90,
                Price = 39.99m,
                Discount = 12,
            }
        };

        return products;
    }

    public IEnumerable<Supplier> GetSuppliers()
    {
        var suppliers = new List<Supplier>
        {
            new()
            {
                Id = _suppliersGuids.ElementAt(0),
                Name = "TechSupply Co.",
            },
            new()
            {
                Id = _suppliersGuids.ElementAt(1),
                Name = "GadgetWorld Inc.",
            }
        };

        return suppliers;
    }

    public IEnumerable<object> GetProductSupplierRelations()
    {
        var relations = new List<object>()
        {
            new { ProductsId = _productGuids.ElementAt(0), SuppliersId = _suppliersGuids.ElementAt(0) },
            new { ProductsId = _productGuids.ElementAt(1), SuppliersId = _suppliersGuids.ElementAt(0) },
            new { ProductsId = _productGuids.ElementAt(3), SuppliersId = _suppliersGuids.ElementAt(0) },
            new { ProductsId = _productGuids.ElementAt(4), SuppliersId = _suppliersGuids.ElementAt(0) },
            new { ProductsId = _productGuids.ElementAt(0), SuppliersId = _suppliersGuids.ElementAt(1) },
            new { ProductsId = _productGuids.ElementAt(1), SuppliersId = _suppliersGuids.ElementAt(1) },
            new { ProductsId = _productGuids.ElementAt(2), SuppliersId = _suppliersGuids.ElementAt(1) },
        };

        return relations;
    }
}
