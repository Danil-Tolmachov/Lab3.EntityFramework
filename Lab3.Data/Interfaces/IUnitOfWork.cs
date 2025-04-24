using Lab3.DAL.Interfaces.Repositories;

namespace Lab3.DAL.Interfaces;

public interface IUnitOfWork
{
    public ISupplierRepository SupplierRepository { get; init; }
    public IProductRepository ProductRepository { get; init; }

    public void SaveChanges();
    public Task SaveChangesAsync();
}
