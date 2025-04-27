using Lab3.BLL.Interfaces;
using Lab3.DAL.Entities;
using Lab3.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab3.BLL.Services;

public class ProductService(IUnitOfWork unitOfWork) : IProductService
{
    public Task<List<Product>> GetAll()
    {
        return unitOfWork.ProductRepository.GetAll().ToListAsync();
    }

    public async Task AddProduct(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));

        unitOfWork.ProductRepository.Create(product);
        await unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteProduct(Guid id)
    {
        await unitOfWork.ProductRepository.Delete(id);
        await unitOfWork.SaveChangesAsync();
    }
}
