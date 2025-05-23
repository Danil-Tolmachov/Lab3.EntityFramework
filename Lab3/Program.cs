using Lab3.BLL.Interfaces;
using Lab3.BLL.Services;
using Lab3.DAL;
using Lab3.DAL.Factories;
using Lab3.DAL.Interfaces;
using Lab3.DAL.Interfaces.Factories;
using Lab3.DAL.Interfaces.Repositories;
using Lab3.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.App;

internal static class Program
{
    [STAThread]
    static async Task Main()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Please specify \"DefaultConnection\" connection string.");

        var builder = new ServiceCollection();

        builder.AddScoped<ISeedDataFactory, TestDataFactory>();
        builder.AddDbContext<ShopContext>(opt => opt.UseSqlite(connectionString));

        builder.AddScoped<IProductRepository, ProductRepository>();
        builder.AddScoped<ISupplierRepository, SupplierRepository>();
        builder.AddScoped<IUnitOfWork, UnitOfWork>();

        builder.AddScoped<IProductService, ProductService>();
        builder.AddScoped<ISupplierService, SupplierService>();

        builder.AddTransient<Store>();

        var provider = builder.BuildServiceProvider();


        using (var scope = provider.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<ShopContext>();
            await dbContext.Database.MigrateAsync();
        }

        ApplicationConfiguration.Initialize();
        var mainForm = provider.GetRequiredService<Store>();
        Application.Run(mainForm);
    }
}