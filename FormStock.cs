using BranchSalesAutomation.DatabaseContext;
using BranchSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace BranchSalesAutomation
{
    public partial class FormStock : Form
    {
        BranchSalesDbContext db = new BranchSalesDbContext();
        int selectedStockId = 0;
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            try
            {
                combo_branch.DataSource = db.Branches
                    .OrderBy(x => x.branch_name)
                    .ToList();

                combo_branch.DisplayMember = "branch_name";
                combo_branch.ValueMember = "branch_id";

                combo_product.DataSource = db.Products
                    .OrderBy(x => x.product_name)
                    .ToList();

                combo_product.DisplayMember = "product_name";
                combo_product.ValueMember = "product_id";
                dgv_stock.ReadOnly = true;

                dgv_stock.AllowUserToAddRows = false;

                dgv_stock.AllowUserToDeleteRows = false;
                dgv_stock.EditMode = DataGridViewEditMode.EditProgrammatically;

                dgv_stock.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgv_stock.DataSource = db.Stocks
                   .Select(x => new
                     {
                     Ürün = x.Product.product_name,
                     Şube = x.Branch.branch_name,
                     Stok = x.quantity
                     })
                   .ToList();
                dgv_stock.RowHeadersVisible = false;

                dgv_stock.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

                dgv_stock.MultiSelect = false;

                dgv_stock.DefaultCellStyle.SelectionBackColor = Color.White;

                dgv_stock.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgv_stock.ClearSelection();
                dgv_stock.DefaultCellStyle.SelectionBackColor = Color.White;

                dgv_stock.DefaultCellStyle.SelectionForeColor = Color.Black;
                txt_search.Text = "Arama yapın...";
                txt_search.ForeColor = Color.Gray;
                RoundPanel(panelAddStock, 20);
                dgv_stock.DataSource = db.Stocks
                 .Select(x => new
                 {
                   Ürün = x.Product.product_name,
                   Şube = x.Branch.branch_name,
                   Stok = x.quantity
                 })
                  .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock()
                {
                    branch_id = Convert.ToInt32(combo_branch.SelectedValue),

                    product_id = Convert.ToInt32(combo_product.SelectedValue),

                    quantity = Convert.ToInt32(txt_stock_quantity.Text)
                };

                db.Stocks.Add(stock);

                db.SaveChanges();

                MessageBox.Show("Stok eklendi!");

                btn_list.PerformClick();
                dgv_stock.DataSource = db.Stocks
                .Select(x => new
                {
                    Ürün = x.Product.product_name,
                    Şube = x.Branch.branch_name,
                    Stok = x.quantity
                })
                .ToList();
                dgv_stock.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_stock.DataSource = db.Stocks.Select(x => new
                {
                    x.stock_id,
                    Şube = x.Branch.branch_name,
                    Ürün = x.Product.product_name,
                    Stok_Adedi = x.quantity
                }).ToList();

                dgv_stock.Columns["stock_id"].Visible = false;

                dgv_stock.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_stock.ReadOnly = true;

                dgv_stock.AllowUserToAddRows = false;
                dgv_stock.AllowUserToDeleteRows = false;

                dgv_stock.AllowUserToResizeColumns = false;
                dgv_stock.AllowUserToResizeRows = false;
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
                DialogResult result = MessageBox.Show(
                    "Stok silinsin mi?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Stock stock = db.Stocks.Find(selectedStockId);

                    if (stock != null)
                    {
                        db.Stocks.Remove(stock);

                        db.SaveChanges();

                        Program.FormMain.DashboardData();

                        MessageBox.Show("Stok silindi!");

                        btn_list.PerformClick();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStockId = Convert.ToInt32(
            dgv_stock.CurrentRow.Cells["stock_id"].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_stock.DataSource = db.Stocks
             .Where(x => x.Product.product_name
             .Contains(txt_search.Text))
             .Select(x => new
          {
             Ürün = x.Product.product_name,
             Şube = x.Branch.branch_name,
             Stok = x.quantity
          })
             .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();

            frm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProduct frm = new FormProduct();

            frm.Show();

            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormSales frm = new FormSales();

            frm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReports frm = new FormReports();

            frm.Show();

            this.Hide();
        }

        private void dgv_stock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void txt_search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Arama yapın...")
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_MouseLeave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Arama yapın...";
                txt_search.ForeColor = Color.Gray;
            }
        }
        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }
    }
}
