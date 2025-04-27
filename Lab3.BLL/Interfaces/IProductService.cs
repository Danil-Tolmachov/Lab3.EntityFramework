using Lab3.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab3.BLL.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAll();
    Task AddProduct(Product product);
    Task DeleteProduct(Guid id);
}
