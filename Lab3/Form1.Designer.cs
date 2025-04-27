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
            panel2 = new Panel();
            inputSecondNameBox = new TextBox();
            inputFirstNameBox = new TextBox();
            addButton = new Button();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip.SuspendLayout();
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
            splitContainer1.Size = new Size(931, 465);
            splitContainer1.SplitterDistance = 497;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 465);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(497, 465);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(inputSecondNameBox);
            panel2.Controls.Add(inputFirstNameBox);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 465);
            panel2.TabIndex = 4;
            // 
            // inputSecondNameBox
            // 
            inputSecondNameBox.Location = new Point(70, 216);
            inputSecondNameBox.Name = "inputSecondNameBox";
            inputSecondNameBox.Size = new Size(299, 22);
            inputSecondNameBox.TabIndex = 5;
            // 
            // inputFirstNameBox
            // 
            inputFirstNameBox.Location = new Point(69, 136);
            inputFirstNameBox.Name = "inputFirstNameBox";
            inputFirstNameBox.Size = new Size(299, 22);
            inputFirstNameBox.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(258, 302);
            addButton.Name = "addButton";
            addButton.Size = new Size(137, 39);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 190);
            label2.Name = "label2";
            label2.Size = new Size(44, 13);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 106);
            label1.Name = "label1";
            label1.Size = new Size(45, 13);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
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
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 465);
            Controls.Add(splitContainer1);
            Name = "Store";
            Text = "Store";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button addButton;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox inputSecondNameBox;
        private TextBox inputFirstNameBox;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
