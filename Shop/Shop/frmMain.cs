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
            var product1 = new Product("first Product","کالای دوم");
            var product2 = new Product("first Product", "کالای دوم");
            var product3 = new Product("first Product", "کالای دوم");

            var productService = new ProductService();

            productService.AddProduct(product1);
            productService.AddProduct(product2);
            productService.AddProduct(product3);


            MessageBox.Show(productService.Products_Count.ToString());
            
            var poo = new Buyer();
             
          
        }

        private void btnExpensiveProduct_Click(object sender, EventArgs e)
        {
            var productService = new ProductService();
            productService.ExpensiveProduct(productService.Products_Array);
        }

        

        
        
    }
}
