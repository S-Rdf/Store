using System;
using System.Windows.Forms;
using Shop.Service;


namespace Shop
{
    public partial class frmMain : Form
    {
        public object ExpensiveProduct { get; private set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product("first Prosuct" , "کالای اول");

            //ProductService.ExpensiveProduct(product);

            "".ToString();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            var product = new Product("first Product","کالای اول");
            ProductService.AddProduct(product);
            MessageBox.Show(ProductService.Products_Count.ToString());
        }

        private void btnExpensiveProduct_Click(object sender, EventArgs e)
        {
            ProductService.ExpensiveProduct(ProductService.Products_Array);
        }
    }
}
