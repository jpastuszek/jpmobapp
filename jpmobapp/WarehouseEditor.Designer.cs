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
            this.ColumnProductDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleProductName = new System.Windows.Forms.TextBox();
            this.SaleQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaleEntryGroup = new System.Windows.Forms.GroupBox();
            this.Sale = new System.Windows.Forms.Button();
            this.SaleHistory = new System.Windows.Forms.ListView();
            this.ColumnSaleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSaleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSaleQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSaleDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.Salesman = new System.Windows.Forms.ComboBox();
            this.SyncButton = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.magazynioDataSet = new jpmobapp.MagazynioDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new jpmobapp.MagazynioDataSetTableAdapters.ProductTableAdapter();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new jpmobapp.MagazynioDataSetTableAdapters.SaleTableAdapter();
            this.magazynioDataSet1 = new jpmobapp.MagazynioDataSet();
            this.salesmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesmanTableAdapter = new jpmobapp.MagazynioDataSetTableAdapters.SalesmanTableAdapter();
            this.productsSaledProducedAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsSaledProducedAvailableTableAdapter = new jpmobapp.MagazynioDataSetTableAdapters.ProductsSaledProducedAvailableTableAdapter();
            this.SaleEntryGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnProductId,
            this.ColumnProductName,
            this.ColumnProductPrice,
            this.ColumnAvailableQuantity,
            this.ColumnProductDescription});
            this.ProductList.FullRowSelect = true;
            this.ProductList.GridLines = true;
            this.ProductList.Location = new System.Drawing.Point(6, 34);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(362, 183);
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
            this.ColumnProductName.Width = 71;
            // 
            // ColumnProductPrice
            // 
            this.ColumnProductPrice.Text = "Price";
            this.ColumnProductPrice.Width = 58;
            // 
            // ColumnAvailableQuantity
            // 
            this.ColumnAvailableQuantity.Text = "Available Quantity";
            this.ColumnAvailableQuantity.Width = 74;
            // 
            // ColumnProductDescription
            // 
            this.ColumnProductDescription.Text = "Description";
            // 
            // SaleProductName
            // 
            this.SaleProductName.Location = new System.Drawing.Point(61, 22);
            this.SaleProductName.Name = "SaleProductName";
            this.SaleProductName.ReadOnly = true;
            this.SaleProductName.Size = new System.Drawing.Size(295, 20);
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
            this.SaleEntryGroup.Location = new System.Drawing.Point(6, 223);
            this.SaleEntryGroup.Name = "SaleEntryGroup";
            this.SaleEntryGroup.Size = new System.Drawing.Size(362, 80);
            this.SaleEntryGroup.TabIndex = 7;
            this.SaleEntryGroup.TabStop = false;
            this.SaleEntryGroup.Text = "Sale";
            // 
            // Sale
            // 
            this.Sale.Location = new System.Drawing.Point(281, 46);
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
            this.ColumnSaleQuantity,
            this.ColumnSaleDate});
            this.SaleHistory.FullRowSelect = true;
            this.SaleHistory.GridLines = true;
            this.SaleHistory.Location = new System.Drawing.Point(6, 309);
            this.SaleHistory.Name = "SaleHistory";
            this.SaleHistory.Size = new System.Drawing.Size(362, 171);
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
            this.ColumnSaleName.Width = 81;
            // 
            // ColumnSaleQuantity
            // 
            this.ColumnSaleQuantity.Text = "Quantity";
            this.ColumnSaleQuantity.Width = 58;
            // 
            // ColumnSaleDate
            // 
            this.ColumnSaleDate.Text = "Date";
            this.ColumnSaleDate.Width = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salesman";
            // 
            // Salesman
            // 
            this.Salesman.FormattingEnabled = true;
            this.Salesman.Location = new System.Drawing.Point(67, 7);
            this.Salesman.Name = "Salesman";
            this.Salesman.Size = new System.Drawing.Size(244, 21);
            this.Salesman.TabIndex = 10;
            this.Salesman.SelectedIndexChanged += new System.EventHandler(this.Salesman_SelectedIndexChanged);
            // 
            // SyncButton
            // 
            this.SyncButton.Image = global::jpmobapp.Properties.Resources._1358455773_arrow_circle_double;
            this.SyncButton.Location = new System.Drawing.Point(6, 6);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(360, 474);
            this.SyncButton.TabIndex = 11;
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(380, 512);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProductList);
            this.tabPage1.Controls.Add(this.SaleEntryGroup);
            this.tabPage1.Controls.Add(this.Salesman);
            this.tabPage1.Controls.Add(this.SaleHistory);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SyncButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(372, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sync";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // magazynioDataSet
            // 
            this.magazynioDataSet.DataSetName = "MagazynioDataSet";
            this.magazynioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.magazynioDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.magazynioDataSet;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // magazynioDataSet1
            // 
            this.magazynioDataSet1.DataSetName = "MagazynioDataSet";
            this.magazynioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesmanBindingSource
            // 
            this.salesmanBindingSource.DataMember = "Salesman";
            this.salesmanBindingSource.DataSource = this.magazynioDataSet1;
            // 
            // salesmanTableAdapter
            // 
            this.salesmanTableAdapter.ClearBeforeFill = true;
            // 
            // productsSaledProducedAvailableBindingSource
            // 
            this.productsSaledProducedAvailableBindingSource.DataMember = "ProductsSaledProducedAvailable";
            this.productsSaledProducedAvailableBindingSource.DataSource = this.magazynioDataSet;
            // 
            // productsSaledProducedAvailableTableAdapter
            // 
            this.productsSaledProducedAvailableTableAdapter.ClearBeforeFill = true;
            // 
            // WarehouseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "WarehouseEditor";
            this.Text = "Warehouse Editor";
            this.Load += new System.EventHandler(this.WarehouseEditor_Load);
            this.SaleEntryGroup.ResumeLayout(false);
            this.SaleEntryGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSaledProducedAvailableBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Salesman;
        private System.Windows.Forms.ColumnHeader ColumnSaleDate;
        private System.Windows.Forms.ColumnHeader ColumnProductDescription;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MagazynioDataSet magazynioDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MagazynioDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private MagazynioDataSetTableAdapters.SaleTableAdapter saleTableAdapter;
        private MagazynioDataSet magazynioDataSet1;
        private System.Windows.Forms.BindingSource salesmanBindingSource;
        private MagazynioDataSetTableAdapters.SalesmanTableAdapter salesmanTableAdapter;
        private System.Windows.Forms.BindingSource productsSaledProducedAvailableBindingSource;
        private MagazynioDataSetTableAdapters.ProductsSaledProducedAvailableTableAdapter productsSaledProducedAvailableTableAdapter;
    }
}

