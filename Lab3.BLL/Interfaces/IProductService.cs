using Lab3.DAL.Entities;

namespace Lab3.BLL.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAll();
}
