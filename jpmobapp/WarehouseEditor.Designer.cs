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
            this.ProductList = new System.Windows.Forms.ListView();
            this.ColumnProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAvailableQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleProductName = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaleEntryGroup = new System.Windows.Forms.GroupBox();
            this.Sale = new System.Windows.Forms.Button();
            this.SaleHistory = new System.Windows.Forms.ListView();
            this.ColumnSaleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSaleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSaleQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SaleEntryGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnProductId,
            this.ColumnProductName,
            this.ColumnProductPrice,
            this.ColumnAvailableQuantity});
            this.ProductList.FullRowSelect = true;
            this.ProductList.GridLines = true;
            this.ProductList.Location = new System.Drawing.Point(12, 12);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(305, 183);
            this.ProductList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ProductList.TabIndex = 0;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.Text = "Id";
            this.ColumnProductId.Width = 33;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.Text = "Name";
            this.ColumnProductName.Width = 147;
            // 
            // ColumnProductPrice
            // 
            this.ColumnProductPrice.Text = "Price";
            this.ColumnProductPrice.Width = 58;
            // 
            // ColumnAvailableQuantity
            // 
            this.ColumnAvailableQuantity.Text = "Available Quantity";
            // 
            // SaleProductName
            // 
            this.SaleProductName.Location = new System.Drawing.Point(61, 22);
            this.SaleProductName.Name = "SaleProductName";
            this.SaleProductName.ReadOnly = true;
            this.SaleProductName.Size = new System.Drawing.Size(193, 20);
            this.SaleProductName.TabIndex = 1;
            // 
            // SaleQuantity
            // 
            this.SaleQuantity.Location = new System.Drawing.Point(61, 48);
            this.SaleQuantity.Name = "SaleQuantity";
            this.SaleQuantity.Size = new System.Drawing.Size(90, 20);
            this.SaleQuantity.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // SaleEntryGroup
            // 
            this.SaleEntryGroup.Controls.Add(this.Sale);
            this.SaleEntryGroup.Controls.Add(this.label2);
            this.SaleEntryGroup.Controls.Add(this.label1);
            this.SaleEntryGroup.Controls.Add(this.SaleQuantity);
            this.SaleEntryGroup.Controls.Add(this.SaleProductName);
            this.SaleEntryGroup.Location = new System.Drawing.Point(12, 201);
            this.SaleEntryGroup.Name = "SaleEntryGroup";
            this.SaleEntryGroup.Size = new System.Drawing.Size(305, 80);
            this.SaleEntryGroup.TabIndex = 7;
            this.SaleEntryGroup.TabStop = false;
            this.SaleEntryGroup.Text = "Sale";
            // 
            // Sale
            // 
            this.Sale.Location = new System.Drawing.Point(179, 46);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(75, 23);
            this.Sale.TabIndex = 11;
            this.Sale.Text = "Sale";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // SaleHistory
            // 
            this.SaleHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnSaleId,
            this.ColumnSaleName,
            this.ColumnSaleQuantity});
            this.SaleHistory.FullRowSelect = true;
            this.SaleHistory.GridLines = true;
            this.SaleHistory.Location = new System.Drawing.Point(12, 287);
            this.SaleHistory.Name = "SaleHistory";
            this.SaleHistory.Size = new System.Drawing.Size(305, 153);
            this.SaleHistory.TabIndex = 8;
            this.SaleHistory.UseCompatibleStateImageBehavior = false;
            this.SaleHistory.View = System.Windows.Forms.View.Details;
            // 
            // ColumnSaleId
            // 
            this.ColumnSaleId.Text = "Id";
            this.ColumnSaleId.Width = 33;
            // 
            // ColumnSaleName
            // 
            this.ColumnSaleName.Text = "Name";
            this.ColumnSaleName.Width = 162;
            // 
            // ColumnSaleQuantity
            // 
            this.ColumnSaleQuantity.Text = "Quantity";
            this.ColumnSaleQuantity.Width = 58;
            // 
            // WarehouseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 452);
            this.Controls.Add(this.SaleHistory);
            this.Controls.Add(this.SaleEntryGroup);
            this.Controls.Add(this.ProductList);
            this.Name = "WarehouseEditor";
            this.Text = "Warehouse Editor";
            this.Load += new System.EventHandler(this.WarehouseEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.SaleEntryGroup.ResumeLayout(false);
            this.SaleEntryGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.TextBox SaleProductName;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ColumnHeader ColumnProductId;
        private System.Windows.Forms.ColumnHeader ColumnProductName;
        private System.Windows.Forms.ColumnHeader ColumnProductPrice;
        private System.Windows.Forms.TextBox SaleQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SaleEntryGroup;
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.ListView SaleHistory;
        private System.Windows.Forms.ColumnHeader ColumnSaleId;
        private System.Windows.Forms.ColumnHeader ColumnSaleName;
        private System.Windows.Forms.ColumnHeader ColumnSaleQuantity;
        private System.Windows.Forms.ColumnHeader ColumnAvailableQuantity;
    }
}

