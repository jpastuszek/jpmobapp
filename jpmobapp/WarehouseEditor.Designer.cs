namespace jpmobapp
{
    partial class WarehouseEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ProductList = new System.Windows.Forms.ListView();
            this.ColumnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductPriceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductEntryGroup = new System.Windows.Forms.GroupBox();
            this.SaveProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.ProductEntryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnPrice});
            this.ProductList.FullRowSelect = true;
            this.ProductList.GridLines = true;
            this.ProductList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ProductList.Location = new System.Drawing.Point(12, 12);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(305, 183);
            this.ProductList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ProductList.TabIndex = 0;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnId
            // 
            this.ColumnId.Text = "Id";
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 162;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.Text = "Price";
            this.ColumnPrice.Width = 58;
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(46, 22);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(148, 20);
            this.ProductNameBox.TabIndex = 1;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(179, 154);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 2;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProductPriceBox
            // 
            this.ProductPriceBox.Location = new System.Drawing.Point(46, 48);
            this.ProductPriceBox.Name = "ProductPriceBox";
            this.ProductPriceBox.Size = new System.Drawing.Size(90, 20);
            this.ProductPriceBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // ProductEntryGroup
            // 
            this.ProductEntryGroup.Controls.Add(this.SaveProduct);
            this.ProductEntryGroup.Controls.Add(this.label2);
            this.ProductEntryGroup.Controls.Add(this.label1);
            this.ProductEntryGroup.Controls.Add(this.ProductPriceBox);
            this.ProductEntryGroup.Controls.Add(this.AddProduct);
            this.ProductEntryGroup.Controls.Add(this.ProductNameBox);
            this.ProductEntryGroup.Location = new System.Drawing.Point(323, 12);
            this.ProductEntryGroup.Name = "ProductEntryGroup";
            this.ProductEntryGroup.Size = new System.Drawing.Size(260, 183);
            this.ProductEntryGroup.TabIndex = 7;
            this.ProductEntryGroup.TabStop = false;
            this.ProductEntryGroup.Text = "Product Entry";
            // 
            // SaveProduct
            // 
            this.SaveProduct.Location = new System.Drawing.Point(98, 154);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Size = new System.Drawing.Size(75, 23);
            this.SaveProduct.TabIndex = 7;
            this.SaveProduct.Text = "Save";
            this.SaveProduct.UseVisualStyleBackColor = true;
            // 
            // WarehouseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 452);
            this.Controls.Add(this.ProductEntryGroup);
            this.Controls.Add(this.ProductList);
            this.Name = "WarehouseEditor";
            this.Text = "Warehouse Editor";
            this.Load += new System.EventHandler(this.WarehouseEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ProductEntryGroup.ResumeLayout(false);
            this.ProductEntryGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ColumnHeader ColumnId;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader ColumnPrice;
        private System.Windows.Forms.TextBox ProductPriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ProductEntryGroup;
        private System.Windows.Forms.Button SaveProduct;
    }
}

