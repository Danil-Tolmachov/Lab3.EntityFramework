using Lab3.BLL.Interfaces;
using Lab3.DAL.Entities;
using Lab3.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab3.BLL.Services;

public class SupplierService(IUnitOfWork unitOfWork) : ISupplierService
{
    public Task<List<Supplier>> GetAll()
    {
        return unitOfWork.SupplierRepository.GetAll().ToListAsync();
    }
    public async Task AddSupplier(Supplier supplier)
    {
        if (supplier == null) throw new ArgumentNullException(nameof(supplier));
        if (string.IsNullOrWhiteSpace(supplier.Name)) throw new ArgumentException("Supplier Name can't be empty", nameof(supplier));

        unitOfWork.SupplierRepository.Create(supplier);
        await unitOfWork.SaveChangesAsync();
    }
}
