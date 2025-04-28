using Lab3.BLL.Interfaces;
using Lab3.DAL.Entities;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using Lab3.BLL.Services;

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
                MessageBox.Show($"Error laoding products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadSupplierAsync()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error laoding suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void Store_Load(object? sender, EventArgs e)
        {
            await LoadProductAsync();
            await LoadSupplierAsync();
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

            var newProduct = new Product
            {
                Name = productName,
                Description = description,
                Price = _price,
                InStock = _inStock,
                Discount = _discount,
            };

            try
            {
                await _productService.AddProduct(newProduct);

                await LoadProductAsync();

                ProductNameInputBox.Text = string.Empty;
                DescriptionInputBox.Text = string.Empty;
                PriceInputBox.Text = string.Empty;
                inStockInputBox.Text = string.Empty;
                discountInputBox.Text = string.Empty;
                productSupplientInputNBox.Text = string.Empty;
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
                await LoadSupplierAsync();
                SupplierInputBox.Text = string.Empty;
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
    }
}
