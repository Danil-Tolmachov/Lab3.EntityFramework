namespace Lab3
{
    partial class Store
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suppliersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            productBindingSource = new BindingSource(components);
            panel2 = new Panel();
            productSupplientInputNBox = new TextBox();
            productSupplientLabel = new Label();
            addSupplierButon = new Button();
            discountInputBox = new TextBox();
            discountLabel = new Label();
            inStockInputBox = new TextBox();
            inStockLabel = new Label();
            PriceInputBox = new TextBox();
            DescriptionInputBox = new TextBox();
            PriceLabel = new Label();
            DescriptionLabel = new Label();
            ProductNameInputBox = new TextBox();
            SupplierInputBox = new TextBox();
            addProductButton = new Button();
            productNameLabel = new Label();
            supplierNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(959, 616);
            splitContainer1.SplitterDistance = 511;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 616);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, suppliersDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn });
            dataGridView1.ContextMenuStrip = contextMenuStrip;
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(511, 616);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliersDataGridViewTextBoxColumn
            // 
            suppliersDataGridViewTextBoxColumn.DataPropertyName = "Suppliers";
            suppliersDataGridViewTextBoxColumn.HeaderText = "Suppliers";
            suppliersDataGridViewTextBoxColumn.Name = "suppliersDataGridViewTextBoxColumn";
            suppliersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            inStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(106, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(105, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DAL.Entities.Product);
            // 
            // panel2
            // 
            panel2.Controls.Add(productSupplientInputNBox);
            panel2.Controls.Add(productSupplientLabel);
            panel2.Controls.Add(addSupplierButon);
            panel2.Controls.Add(discountInputBox);
            panel2.Controls.Add(discountLabel);
            panel2.Controls.Add(inStockInputBox);
            panel2.Controls.Add(inStockLabel);
            panel2.Controls.Add(PriceInputBox);
            panel2.Controls.Add(DescriptionInputBox);
            panel2.Controls.Add(PriceLabel);
            panel2.Controls.Add(DescriptionLabel);
            panel2.Controls.Add(ProductNameInputBox);
            panel2.Controls.Add(SupplierInputBox);
            panel2.Controls.Add(addProductButton);
            panel2.Controls.Add(productNameLabel);
            panel2.Controls.Add(supplierNameLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 616);
            panel2.TabIndex = 4;
            // 
            // productSupplientInputNBox
            // 
            productSupplientInputNBox.Location = new Point(45, 517);
            productSupplientInputNBox.Name = "productSupplientInputNBox";
            productSupplientInputNBox.Size = new Size(299, 22);
            productSupplientInputNBox.TabIndex = 16;
            // 
            // productSupplientLabel
            // 
            productSupplientLabel.AutoSize = true;
            productSupplientLabel.Location = new Point(45, 491);
            productSupplientLabel.Name = "productSupplientLabel";
            productSupplientLabel.Size = new Size(85, 13);
            productSupplientLabel.TabIndex = 15;
            productSupplientLabel.Text = "Product Supplier";
            // 
            // addSupplierButon
            // 
            addSupplierButon.Location = new Point(275, 90);
            addSupplierButon.Name = "addSupplierButon";
            addSupplierButon.Size = new Size(137, 39);
            addSupplierButon.TabIndex = 14;
            addSupplierButon.Text = "Add Supplier";
            addSupplierButon.UseVisualStyleBackColor = true;
            addSupplierButon.Click += addSupplierButon_Click;
            // 
            // discountInputBox
            // 
            discountInputBox.Location = new Point(44, 451);
            discountInputBox.Name = "discountInputBox";
            discountInputBox.Size = new Size(299, 22);
            discountInputBox.TabIndex = 13;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(44, 425);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(49, 13);
            discountLabel.TabIndex = 12;
            discountLabel.Text = "Discount";
            // 
            // inStockInputBox
            // 
            inStockInputBox.Location = new Point(45, 387);
            inStockInputBox.Name = "inStockInputBox";
            inStockInputBox.Size = new Size(299, 22);
            inStockInputBox.TabIndex = 11;
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Location = new Point(45, 361);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(88, 13);
            inStockLabel.TabIndex = 10;
            inStockLabel.Text = "Quantity in Stock";
            // 
            // PriceInputBox
            // 
            PriceInputBox.Location = new Point(45, 321);
            PriceInputBox.Name = "PriceInputBox";
            PriceInputBox.Size = new Size(299, 22);
            PriceInputBox.TabIndex = 9;
            // 
            // DescriptionInputBox
            // 
            DescriptionInputBox.Location = new Point(45, 251);
            DescriptionInputBox.Name = "DescriptionInputBox";
            DescriptionInputBox.Size = new Size(299, 22);
            DescriptionInputBox.TabIndex = 8;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(45, 295);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(31, 13);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Price";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(45, 221);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(60, 13);
            DescriptionLabel.TabIndex = 6;
            DescriptionLabel.Text = "Description";
            // 
            // ProductNameInputBox
            // 
            ProductNameInputBox.Location = new Point(45, 182);
            ProductNameInputBox.Name = "ProductNameInputBox";
            ProductNameInputBox.Size = new Size(299, 22);
            ProductNameInputBox.TabIndex = 5;
            // 
            // SupplierInputBox
            // 
            SupplierInputBox.Location = new Point(45, 49);
            SupplierInputBox.Name = "SupplierInputBox";
            SupplierInputBox.Size = new Size(299, 22);
            SupplierInputBox.TabIndex = 4;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(275, 556);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(137, 39);
            addProductButton.TabIndex = 3;
            addProductButton.Text = "Add Product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(45, 156);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(75, 13);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Product Name";
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new Point(45, 19);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new Size(76, 13);
            supplierNameLabel.TabIndex = 0;
            supplierNameLabel.Text = "Supplier Name";
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 616);
            Controls.Add(splitContainer1);
            Name = "Store";
            Text = "Store";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button addProductButton;
        private Label productNameLabel;
        private Label supplierNameLabel;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox ProductNameInputBox;
        private TextBox SupplierInputBox;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private BindingSource productBindingSource;
        private TextBox inStockInputBox;
        private Label inStockLabel;
        private TextBox PriceInputBox;
        private TextBox DescriptionInputBox;
        private Label PriceLabel;
        private Label DescriptionLabel;
        private TextBox discountInputBox;
        private Label discountLabel;
        private Button addSupplierButon;
        private TextBox productSupplientInputNBox;
        private Label productSupplientLabel;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suppliersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}
