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

namespace BranchSalesAutomation
{
    public partial class FormProduct : Form
    {
        BranchSalesDbContext db = new BranchSalesDbContext();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgv_product.CurrentRow.Cells["product_id"].Value);

                Product product = db.Products.Find(id);

                product.product_name = textBox1.Text;

                product.product_price = Convert.ToDecimal(textBox2.Text);

                product.category_id = Convert.ToInt32(cmb_category.SelectedValue);

                db.SaveChanges();

                MessageBox.Show("Ürün güncellendi");

                btn_list_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            cmb_category.DataSource = db.Categories.ToList();
            cmb_category.DisplayMember = "category_name";
            cmb_category.ValueMember = "category_id";
            btn_list_Click(sender, e);
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_product.DataSource = db.Products.Select(x => new
                {
                    x.product_id,
                    Ürün_Adı = x.product_name,
                    Ürün_Fiyatı = x.product_price,
                    Kategori = x.Category.category_name
                }).ToList();

                dgv_product.Columns["product_id"].Visible = false;

                dgv_product.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_product.ReadOnly = true;

                dgv_product.AllowUserToAddRows = false;
                dgv_product.AllowUserToDeleteRows = false;

                dgv_product.AllowUserToResizeColumns = false;
                dgv_product.AllowUserToResizeRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                product.product_name = textBox1.Text;
                product.product_price = Convert.ToDecimal(textBox2.Text);
                product.category_id = Convert.ToInt32(cmb_category.SelectedValue);

                db.Products.Add(product);
                db.SaveChanges();

                MessageBox.Show("Ürün eklendi");

                btn_list_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dgv_product.CurrentRow.Cells["Ürün_Adı"].Value.ToString();

                textBox2.Text = dgv_product.CurrentRow.Cells["Ürün_Fiyatı"].Value.ToString();

                cmb_category.Text = dgv_product.CurrentRow.Cells["Kategori"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                int id = Convert.ToInt32(dgv_product.CurrentRow.Cells["product_id"].Value);

                Product product = db.Products.Find(id);

                db.Products.Remove(product);

                db.SaveChanges();

                MessageBox.Show("Ürün silindi");

                btn_list_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
