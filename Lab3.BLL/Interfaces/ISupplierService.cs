using Lab3.DAL.Entities;
using Mysqlx.Resultset;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab3.BLL.Interfaces;

public interface ISupplierService
{
    Task<List<Supplier>> GetAll();
    Task AddSupplier(Supplier supplier);
    Task<Supplier?> GetByName(string name);
}
