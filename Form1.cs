using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BranchSalesAutomation.DatabaseContext;
using BranchSalesAutomation.Models;
using System.Linq;

namespace BranchSalesAutomation
{
    public partial class Form1 : Form
    {
        BranchSalesDbContext db = new BranchSalesDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            cmb_category.DataSource = db.Categories.ToList();
            cmb_category.DisplayMember = "category_name";
            cmb_category.ValueMember = "category_id";
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            dgv_product.DataSource = db.Products.ToList();
        }
    }
}
