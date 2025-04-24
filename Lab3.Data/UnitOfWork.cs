using Lab3.DAL.Interfaces;
using Lab3.DAL.Interfaces.Repositories;
using Lab3.DAL.Repositories;

namespace Lab3.DAL;

public class UnitOfWork(ShopContext context) : IUnitOfWork
{
    public IProductRepository ProductRepository { get; init; } = new ProductRepository(context);
    public ISupplierRepository SupplierRepository { get; init; } = new SupplierRepository(context);

    public void SaveChanges()
    {
        context.SaveChanges();
    }

    public Task SaveChangesAsync()
    {
        return context.SaveChangesAsync();
    }
}
