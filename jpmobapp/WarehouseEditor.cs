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
            // TODO: This line of code loads data into the '_MyDatabase_1DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._MyDatabase_1DataSet.Products);
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
            Debug.WriteLine("Adding product: " + ProductName.Text);
            using (var context = new WarehouseContext())
            {
                var product = new Product { Name = ProductName.Text, Price = 0 };
                context.Products.Add(product);
                context.SaveChanges();
                AddProductToList(product);
            }
        }

        public void AddProductToList(Product product)
        {
            ListViewItem item = new ListViewItem();
            item.Name = "Product";
            item.Tag = product.Id;
            item.Text = product.Id.ToString();

            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, "Name");
            subItem.Name = "Name";
            subItem.Text = product.Name;
            item.SubItems.Add(subItem);

            subItem = new ListViewItem.ListViewSubItem(item, "Price");
            subItem.Name = "Price";
            subItem.Text = product.Price.ToString();
            item.SubItems.Add(subItem);

            ProductList.Items.Add(item);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
