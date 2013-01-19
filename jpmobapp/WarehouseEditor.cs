using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace jpmobapp
{
    public partial class WarehouseEditor : Form
    {
        public WarehouseEditor()
        {
            InitializeComponent();
        }

        private void WarehouseEditor_Load(object sender, EventArgs e)
        {
            RefreshProducts();
            RefreshSales();
        }

        public void RefreshProducts()
        {
            using (var context = new WarehouseContext())
            {
                Debug.WriteLine("Products listing obtained");

                var products =
                    from product in context.Products
                    orderby product.Name
                    select product;

                Debug.WriteLine("Products listing obtained");
                Debug.WriteLine("Found products: " + products.Count().ToString());

                ProductList.Items.Clear();

                foreach (var product in products)
                {
                    Debug.WriteLine(product.Name);

                    var item = new ListViewItem();
                    item.Name = "Product";
                    item.Tag = product.Id;
                    item.Text = product.Id.ToString();

                    var subItem = new ListViewItem.ListViewSubItem(item, "Name");
                    subItem.Name = "Name";
                    subItem.Text = product.Name;
                    item.SubItems.Add(subItem);

                    subItem = new ListViewItem.ListViewSubItem(item, "Price");
                    subItem.Name = "Price";
                    subItem.Text = product.Price.ToString();
                    item.SubItems.Add(subItem);

                    subItem = new ListViewItem.ListViewSubItem(item, "Available Quantity");
                    subItem.Name = "Available Quantity";
                    subItem.Text = product.AvailableQuantity.ToString();
                    item.SubItems.Add(subItem);

                    ProductList.Items.Add(item);
                }

                Debug.WriteLine("Products listing updated");
            }
        }

        public void RefreshSales()
        {
            using (var context = new WarehouseContext())
            {
                Debug.WriteLine("Sales listing obtained");

                var sales =
                    from sale in context.Sales
                    join product in context.Products on sale.Product_Id equals product.Id
                    orderby sale.Id descending
                    select new
                    {
                        Id = sale.Id,
                        Name = product.Name,
                        Quantity = sale.Quantity
                    };

                Debug.WriteLine("Sale history listing obtained");
                Debug.WriteLine("Found sales: " + sales.Count().ToString());

                SaleHistory.Items.Clear();

                foreach (var sale in sales)
                {
                    Debug.WriteLine(sale.Name);

                    var item = new ListViewItem();
                    item.Name = "Sale";
                    item.Tag = sale.Id;
                    item.Text = sale.Id.ToString();

                    var subItem = new ListViewItem.ListViewSubItem(item, "Name");
                    subItem.Name = "Name";
                    subItem.Text = sale.Name;
                    item.SubItems.Add(subItem);

                    subItem = new ListViewItem.ListViewSubItem(item, "Quantity");
                    subItem.Name = "Quantity";
                    subItem.Text = sale.Quantity.ToString();
                    item.SubItems.Add(subItem);

                    SaleHistory.Items.Add(item);
                }

                Debug.WriteLine("Sale listing updated");
            }
        }
        
        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedItems.Count > 0)
            {
                var item = ProductList.SelectedItems[ProductList.SelectedItems.Count - 1];
                Debug.WriteLine("Secelcted product: " + item.ToString());
                SaleProductName.Text = item.SubItems[1].Text;
                SaleQuantity.Text = "1";
            }
            else
            {
                Debug.WriteLine("Product selection cleared");
                SaleProductName.Text = "";
                SaleQuantity.Text = "";
            }
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            if (ProductList.SelectedItems.Count > 0)
            {
                var quantity = 0;
                if (!Int32.TryParse(SaleQuantity.Text, out quantity))
                {
                    MessageBox.Show("Incorrect Quantity value. Not a number.", "Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (quantity <= 0)
                {
                    MessageBox.Show("Incorrect Quantity value. Non positive numebr.", "Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var item = ProductList.SelectedItems[ProductList.SelectedItems.Count - 1];
                var item_id = Int32.Parse(item.SubItems[0].Text);
                Debug.WriteLine("Sale of product ID: " + item_id.ToString());

                using (var context = new WarehouseContext())
                {
                    var product_to_sale =
                    from product in context.Products
                    where product.Id == item_id
                    select product;

                    if (product_to_sale.First().AvailableQuantity < quantity)
                    {
                        MessageBox.Show("Incorrect Quantity value. Not enough available items left.", "Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    var sale_item = new Sale { Product_Id = product_to_sale.First().Id, Quantity = quantity, Salesman_Id = 0 };
                    context.Sales.Add(sale_item);

                    product_to_sale.First().AvailableQuantity = product_to_sale.First().AvailableQuantity - quantity;

                    context.SaveChanges();
                }

                SaleProductName.Text = "";
                SaleQuantity.Text = "";

                RefreshSales();
                RefreshProducts();
            }
            else
            {
                Debug.WriteLine("No product selected");
                MessageBox.Show("You must select product.", "Sale Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
    