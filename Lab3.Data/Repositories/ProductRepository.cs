using Lab3.DAL.Entities;
using Lab3.DAL.Interfaces.Repositories;

namespace Lab3.DAL.Repositories;

public class ProductRepository(ShopContext context) : AbstractCrudRepository<Product>(context), IProductRepository
{
}
