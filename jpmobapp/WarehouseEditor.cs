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

                foreach (var product in products)
                {
                    Debug.WriteLine(product.Name);
                    AddProductToList(product);
                }

                Debug.WriteLine("Products listing updated");
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Adding product: " + ProductNameBox.Text);

            var name = ProductNameBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("You must enter product name.", "Product Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var price = 0.0;
            if (!Double.TryParse(ProductPriceBox.Text, out price))
            {
                MessageBox.Show("You must enter product price.", "Product Price Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (var context = new WarehouseContext())
            {
                var product = new Product { Name = name, Price = price, ProducedQuantity = 1 };
                context.Products.Add(product);
                context.SaveChanges();
                AddProductToList(product);
            }

            ProductNameBox.Clear();
            ProductPriceBox.Clear();
        }

        public void AddProductToList(Product product)
        {
            Debug.WriteLine("Adding product to list: " + product.Name);
            
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

            ProductList.Items.Add(item);
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedItems.Count > 0)
            {
                var item = ProductList.SelectedItems[ProductList.SelectedItems.Count - 1];
                Debug.WriteLine("Secelcted product: " + item.ToString());
                ProductNameBox.Text = item.SubItems[1].Text;
                ProductPriceBox.Text = item.SubItems[2].Text;
            }
            else
            {
                Debug.WriteLine("Product selection cleared");
                ProductNameBox.Text = "";
                ProductPriceBox.Text = "";
            }    
        }
    }
}
