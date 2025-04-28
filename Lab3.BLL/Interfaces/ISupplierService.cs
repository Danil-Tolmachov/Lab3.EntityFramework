using Lab3.DAL.Entities;

namespace Lab3.BLL.Interfaces;

public interface ISupplierService
{
    Task<List<Supplier>> GetAll();
    Task AddSupplier(Supplier supplier);
}
