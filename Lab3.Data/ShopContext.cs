using Lab3.DAL.Entities;
using Lab3.DAL.Factories;
using Lab3.DAL.Interfaces.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace Lab3.DAL;

public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; init; }

    public DbSet<Supplier> Suppliers { get; init; }

    public ISeedDataFactory? SeedFactory { get; init; }

    public ShopContext()
    {
        SeedFactory = new TestDataFactory();
    }

    public ShopContext(DbContextOptions<ShopContext> options) : base(options)
    {
        SeedFactory = new TestDataFactory();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.HasData(SeedFactory?.GetProducts() ?? []);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.HasMany(e => e.Products)
                  .WithMany(e => e.Suppliers)
                  .UsingEntity(j => j.ToTable("ProductSuppliers"));

            entity.HasData(SeedFactory?.GetSuppliers() ?? []);
        });

        // Many-to-many relation seed data.
        modelBuilder.Entity("ProductSupplier")
                    .HasData(SeedFactory?.GetProductSupplierRelations() ?? []);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=shop.db");

        base.OnConfiguring(optionsBuilder);
    }
}
