using System;
using System.Windows.Forms;
using Shop.Models;


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
            Product product = new Product();
        }
    }
}
