using BranchSalesAutomation.DatabaseContext;
using BranchSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BranchSalesAutomation
{
    public partial class FormProduct : Form
    {
        
        int selectedProductId = 0;
        bool dragging = false;

        Point dragCursorPoint;

        Point dragFormPoint;
        Color defaultRowColor = Color.White;
        bool isEditMode = false;
        BranchSalesDbContext db = new BranchSalesDbContext();
        public FormProduct()
        {
            InitializeComponent();
            groupBox1.MouseDown += groupBox1_MouseDown;
            groupBox1.MouseMove += groupBox1_MouseMove;
            groupBox1.MouseUp += groupBox1_MouseUp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" ||
                    textBox2.Text == "" ||
                    cmb_category.SelectedIndex == -1)
                {
                    MessageBox.Show("Tüm alanları doldurun");
                    return;
                }

                if (isEditMode == false)
                {

                    Product product = new Product();

                    product.product_name = textBox1.Text;

                    product.product_price =
                        decimal.Parse(textBox2.Text);

                    product.category_id =
                        Convert.ToInt32(cmb_category.SelectedValue);

                    db.Products.Add(product);

                    MessageBox.Show("Ürün eklendi");
                     
                }
                else
                {
                    Product product =
                        db.Products.Find(selectedProductId);

                    product.product_name = textBox1.Text;

                    product.product_price =
                        decimal.Parse(textBox2.Text);

                    product.category_id =
                        Convert.ToInt32(cmb_category.SelectedValue);

                    MessageBox.Show("Ürün güncellendi");
                }

                db.SaveChanges();

                btn_list.PerformClick();

                groupBox1.Visible = false;

                groupBox1.Text = "Ürün Ekle";

                isEditMode = false;

                selectedProductId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    ID = x.product_id,
                    Ürün_Adı = x.product_name,
                    Kategori = x.Category.category_name,
                    Ürün_Fiyatı = x.product_price,

                }).ToList();
                dgv_product.Columns["ID"].DisplayIndex = 0;
                dgv_product.Columns["ID"].Visible = false;

                dgv_product.Columns["Ürün_Adı"].DisplayIndex = 1;
                dgv_product.Columns["Ürün_Adı"].HeaderText = "ÜRÜN ADI";

                dgv_product.Columns["Kategori"].DisplayIndex = 2;
                dgv_product.Columns["Kategori"].HeaderText = "KATEGORİ";

                dgv_product.Columns["Ürün_Fiyatı"].DisplayIndex = 3;
                dgv_product.Columns["Ürün_Fiyatı"].HeaderText = "ÜRÜN FİYATI";

                dgv_product.Columns["colEdit"].DisplayIndex = 4;
                dgv_product.Columns["colEdit"].HeaderText = "DÜZENLE";

                dgv_product.Columns["colDelete"].DisplayIndex = 5;
                dgv_product.Columns["colDelete"].HeaderText = "SİL";

                dgv_product.Columns["ID"].FillWeight = 20;

                dgv_product.Columns["Ürün_Adı"].FillWeight = 80;

                dgv_product.Columns["Kategori"].FillWeight = 55;

                dgv_product.Columns["Ürün_Fiyatı"].FillWeight = 40;

                dgv_product.Columns["colEdit"].FillWeight = 15;

                dgv_product.Columns["colDelete"].FillWeight = 15;

                dgv_product.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_product.ReadOnly = true;

                dgv_product.AllowUserToAddRows = false;
                dgv_product.AllowUserToDeleteRows = false;

                dgv_product.AllowUserToResizeColumns = false;
                dgv_product.AllowUserToResizeRows = false;
                lblTotalRecord.Text = "Toplam " + dgv_product.Rows.Count + " ürün bulunmaktadır.";
                for (int i = 0; i < dgv_product.Rows.Count; i++)
                {
                    dgv_product.Rows[i].Cells["colEdit"].Value =
                        Properties.Resources.icons8_edit_24;

                    dgv_product.Rows[i].Cells["colDelete"].Value =
                        Properties.Resources.icons8_delete_24;
                }
                dgv_product.RowTemplate.Height = 40;
                dgv_product.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

                dgv_product.MultiSelect = false;

                dgv_product.RowHeadersVisible = false;

                dgv_product.DefaultCellStyle.SelectionBackColor = Color.White;

                dgv_product.DefaultCellStyle.SelectionForeColor = Color.Black;
                 
                dgv_product.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);

                dgv_product.ColumnHeadersHeight = 45;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            textBox1.Clear();

            textBox2.Clear();

            cmb_category.SelectedIndex = -1;

            textBox1.Focus();
        }
        
        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dgv_product.CurrentRow.Cells["Ürün_Adı"].Value.ToString();

                textBox2.Text = dgv_product.CurrentRow.Cells["Ürün_Fiyatı"].Value.ToString();

                cmb_category.SelectedIndex =
                cmb_category.FindStringExact(
                dgv_product.Rows[e.RowIndex]
                .Cells["Kategori"].Value.ToString());
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

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_product.Columns["colDelete"].Index)
            {
                DialogResult result = MessageBox.Show(
                "Bu ürünü silmek istediğinizden emin misiniz?",
                "Ürün Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(
                        dgv_product.Rows[e.RowIndex].Cells["ID"].Value);

                    var deletedProduct = db.Products.Find(ID);

                    var stockList = db.Stocks
                        .Where(x => x.product_id == ID)
                        .ToList();

                    db.Stocks.RemoveRange(stockList);

                    db.Products.Remove(deletedProduct);

                    db.SaveChanges();

                    btn_list.PerformClick();
                }
            }

            if (e.ColumnIndex == dgv_product.Columns["colEdit"].Index)
            {
                selectedProductId = Convert.ToInt32(
                    dgv_product.Rows[e.RowIndex].Cells["ID"].Value);
                isEditMode = true;
                groupBox1.Text = "Ürün Güncelle";

                textBox1.Text =
                    dgv_product.Rows[e.RowIndex]
                    .Cells["Ürün_Adı"].Value.ToString();

                textBox2.Text =
                    dgv_product.Rows[e.RowIndex]
                    .Cells["Ürün_Fiyatı"].Value.ToString();

                cmb_category.SelectedIndex =
                    cmb_category.FindStringExact(
                     dgv_product.Rows[e.RowIndex]
                    .Cells["Kategori"].Value.ToString());

                groupBox1.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedProductId = 0;
            isEditMode = false;
            groupBox1.Text = "Ürün Ekle";

            groupBox1.Visible = true;

            textBox1.Clear();

            textBox2.Clear();

            cmb_category.SelectedIndex = -1;

            textBox1.Focus();
            groupBox1.Text = "Ürün Ekle";
        }
        private void dgv_product_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_product.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    Color.FromArgb(245, 247, 255);
            }
        }
        private void dgv_product_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_product.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    defaultRowColor;
            }
        }
        private void groupBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;

            dragCursorPoint = Cursor.Position;

            dragFormPoint = groupBox1.Location;
        }
        private void groupBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position,
                    new Size(dragCursorPoint));

                groupBox1.Location =
                    Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void groupBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            isEditMode = false;

            selectedProductId = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormMain.DashboardData();
            Program.FormMain.Show();

            this.Close();
        }
    }
    
}
