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
            using (var context = new WarehouseContext())
            {
                Debug.WriteLine("Products listing obtained");

                var products =
                    from product in context.Products
                    orderby product.Name
                    select product;
                Debug.WriteLine("Products listing obtained");
                foreach (var product in products)
                {
                    Debug.WriteLine(product.Name);
                }

                //Debug.WriteLine("Found products: " + products.Count().ToString());
                Debug.WriteLine("Products listing updated");

            }
        }
    }
}
