using Lab3.DAL.Entities;
using Lab3.DAL.Interfaces.Repositories;

namespace Lab3.DAL.Repositories;

public class SupplierRepository(ShopContext context) : AbstractCrudRepository<Supplier>(context), ISupplierRepository
{
}
