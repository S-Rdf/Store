using System;
using System.Windows.Forms;
using Shop.Service;


namespace Shop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product("first Prosuct" , "کالای اول");           

            "".ToString();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            var product = new Product();
            ProductService.AddProduct(product);
            MessageBox.Show(ProductService.Products_Count.ToString());
        }
    }
}
