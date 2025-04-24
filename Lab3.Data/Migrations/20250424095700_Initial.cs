using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    InStock = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Discount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSuppliers",
                columns: table => new
                {
                    ProductsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SuppliersId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSuppliers", x => new { x.ProductsId, x.SuppliersId });
                    table.ForeignKey(
                        name: "FK_ProductSuppliers_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSuppliers_Suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "InStock", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("11edb517-bca0-4e87-b8a5-c685a4eade4f"), "Dimmable LED lamp with touch controls and USB charging port.", 12, 90, "LED Desk Lamp", 39.99m },
                    { new Guid("1808bd06-1932-47e4-bdfa-01a659b89f6e"), "High-precision RGB gaming mouse with adjustable DPI.", 15, 120, "Gaming Mouse", 59.99m },
                    { new Guid("1b9ecc60-7dc7-43d4-aff0-97f8e42fe0d9"), "Bluetooth noise-cancelling over-ear headphones.", 10, 50, "Wireless Headphones", 149.99m },
                    { new Guid("3c8a4d9d-8997-425a-8205-d46c33829b70"), "10000mAh power bank with fast charging capability.", 20, 200, "Portable Charger", 29.95m },
                    { new Guid("f201b8c9-516c-4c1b-a0a2-a83060ada90f"), "Fitness tracking smartwatch with heart-rate monitoring.", 5, 75, "Smartwatch", 199.50m }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2ff59740-8b39-42bc-8bc7-f243bcb48442"), "GadgetWorld Inc." },
                    { new Guid("eb7c5fe5-8a71-471f-99c7-4c3935b7594f"), "TechSupply Co." }
                });

            migrationBuilder.InsertData(
                table: "ProductSuppliers",
                columns: new[] { "ProductsId", "SuppliersId" },
                values: new object[,]
                {
                    { new Guid("11edb517-bca0-4e87-b8a5-c685a4eade4f"), new Guid("eb7c5fe5-8a71-471f-99c7-4c3935b7594f") },
                    { new Guid("1808bd06-1932-47e4-bdfa-01a659b89f6e"), new Guid("2ff59740-8b39-42bc-8bc7-f243bcb48442") },
                    { new Guid("1808bd06-1932-47e4-bdfa-01a659b89f6e"), new Guid("eb7c5fe5-8a71-471f-99c7-4c3935b7594f") },
                    { new Guid("1b9ecc60-7dc7-43d4-aff0-97f8e42fe0d9"), new Guid("2ff59740-8b39-42bc-8bc7-f243bcb48442") },
                    { new Guid("1b9ecc60-7dc7-43d4-aff0-97f8e42fe0d9"), new Guid("eb7c5fe5-8a71-471f-99c7-4c3935b7594f") },
                    { new Guid("3c8a4d9d-8997-425a-8205-d46c33829b70"), new Guid("eb7c5fe5-8a71-471f-99c7-4c3935b7594f") },
                    { new Guid("f201b8c9-516c-4c1b-a0a2-a83060ada90f"), new Guid("2ff59740-8b39-42bc-8bc7-f243bcb48442") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSuppliers_SuppliersId",
                table: "ProductSuppliers",
                column: "SuppliersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSuppliers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
