using Lab3.BLL.Interfaces;
using Lab3.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Lab3
{
    public partial class Store : Form
    {
        private readonly IProductService _productService;
        private readonly IServiceProvider _serviceProvider;
        private readonly ISupplierService _supplierService;

        public Store(IProductService productService, IServiceProvider serviceProvider, ISupplierService supplierService)
        {
            InitializeComponent();

            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _supplierService = supplierService ?? throw new ArgumentNullException(nameof(supplierService));

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            this.Load += Store_Load;
        }

        private async Task LoadProductAsync()
        {
            try
            {
                List<Product> products = await _productService.GetAll();

                productBindingSource.DataSource = null;
                productBindingSource.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Store_Load(object? sender, EventArgs e)
        {
            await LoadProductAsync();
        }

        private async void addProductButton_Click(object sender, EventArgs e)
        {
            string productName = ProductNameInputBox.Text.Trim();
            string description = DescriptionInputBox.Text.Trim();
            string price = PriceInputBox.Text.Trim();
            string inStock = inStockInputBox.Text.Trim();
            string discount = discountInputBox.Text.Trim();
            string productSupplier = productSupplientInputNBox.Text.Trim();

            var fields = new Dictionary<string, string>
            {
                { "Product Name", productName },
                { "Description", description },
                { "Price", price },
                { "Quantity", inStock },
                { "Discount", discount },
                { "Product Supplier", productSupplier }
            };

            foreach (var field in fields)
            {
                if (string.IsNullOrEmpty(field.Value))
                {
                    MessageBox.Show($"{field.Key} can't be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!decimal.TryParse(price, out decimal _price) || _price < 0)
            {
                MessageBox.Show($"Invalid Price Input", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(inStock, out int _inStock) || _inStock < 0)
            {
                MessageBox.Show($"Invalid Quantity Input", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(discount, out int _discount) || _discount < 0 || _discount > 100)
            {
                MessageBox.Show($"Invalid Discount Input", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Supplier? foundSuplier = null;
            try
            {
                foundSuplier = await _supplierService.GetByName(productSupplier);
                if (foundSuplier == null)
                {
                    MessageBox.Show($"Supplier '{productSupplier}' not found. Please add the supplier first or check the name", "Supplier Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newProduct = new Product
            {
                Name = productName,
                Description = description,
                Price = _price,
                InStock = _inStock,
                Discount = _discount,
                Suppliers = new List<Supplier> { foundSuplier }
            };

            try
            {
                await _productService.AddProduct(newProduct);

                await LoadProductAsync();

                ProductNameInputBox.Clear();
                DescriptionInputBox.Clear();
                PriceInputBox.Clear();
                inStockInputBox.Clear();
                discountInputBox.Clear();
                productSupplientInputNBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void addSupplierButon_Click(object sender, EventArgs e)
        {
            string supplierName = SupplierInputBox.Text.Trim();

            if (string.IsNullOrEmpty(supplierName))
            {
                MessageBox.Show($"Supplier Name can't be empty", "Validataion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newSupplier = new Supplier { Name = supplierName };

            try
            {
                await _supplierService.AddSupplier(newSupplier);
                SupplierInputBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].DataBoundItem is Product selectedProduct)
                {
                    var confirmResult = MessageBox.Show($"Are you sure you want to delete '{selectedProduct.Name}'?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            await _productService.DeleteProduct(selectedProduct.Id);

                            // Refresh grid
                            await LoadProductAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select product to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "suppliersDataGridViewTextBoxColumn")
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Product product && product.Suppliers != null)
                {
                    e.Value = string.Join(", ", product.Suppliers.Select(s => s.Name));
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = string.Empty;
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
