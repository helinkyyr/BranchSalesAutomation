using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchSalesAutomation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();

            formProduct.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();

            formStock.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();

            formSales.Show();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();

            formReports.Show();
        }
    }
}
