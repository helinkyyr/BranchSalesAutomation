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
                       x.stock_id,
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
                     x.stock_id,
                     Ürün = x.Product.product_name,
                     Şube = x.Branch.branch_name,
                     Stok = x.quantity
                 })
                  .ToList();
                dgv_stock.Columns["stock_id"].Visible = false;

                dgv_stock.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_stock.RowTemplate.Height = 35;

                dgv_stock.ColumnHeadersHeight = 40;

                dgv_stock.EnableHeadersVisualStyles = false;

                dgv_stock.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.White;

                dgv_stock.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.Black;

                dgv_stock.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);

                dgv_stock.DefaultCellStyle.Font =
                    new Font("Segoe UI", 10);

                dgv_stock.DefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(240, 240, 240);

                dgv_stock.DefaultCellStyle.SelectionForeColor =
                    Color.Black;

                dgv_stock.BorderStyle = BorderStyle.None;

                dgv_stock.CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal;

                dgv_stock.BackgroundColor = Color.White;

                dgv_stock.Columns["DeleteIcon"].FillWeight = 20;

                dgv_stock.Columns["EditIcon"].FillWeight = 25;

                dgv_stock.Columns["Stok"].FillWeight = 30;

                dgv_stock.Columns["DeleteIcon"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgv_stock.Columns["EditIcon"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgv_stock.Columns["Stok"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                dgv_stock.Columns["DeleteIcon"].HeaderText =
                    "Sil";

                dgv_stock.Columns["EditIcon"].HeaderText =
                    "Düzenle";
                dgv_stock.Columns["Ürün"].DisplayIndex = 0;

                dgv_stock.Columns["Şube"].DisplayIndex = 1;

                dgv_stock.Columns["Stok"].DisplayIndex = 2;

                dgv_stock.Columns["DeleteIcon"].DisplayIndex = 3;

                dgv_stock.Columns["EditIcon"].DisplayIndex = 4;
                dgv_stock.Columns["DeleteIcon"].FillWeight = 20;

                dgv_stock.Columns["EditIcon"].FillWeight = 25;

                dgv_stock.Columns["Stok"].FillWeight = 25;
              
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
                    x.stock_id,
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
                        result = MessageBox.Show(
                        "Bu stoğu silmek istediğinize emin misiniz?",
                             "Silme Onayı",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            db.Stocks.Remove(stock);

                            db.SaveChanges();

                            dgv_stock.DataSource = db.Stocks
                                .Select(x => new
                                {
                                    x.stock_id,
                                    Ürün = x.Product.product_name,
                                    Şube = x.Branch.branch_name,
                                    Stok = x.quantity
                                })
                                .ToList();
                        }

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
            if (txt_search.Text == "Arama yapın..." ||
                txt_search.Text == "")
            {
                dgv_stock.DataSource = db.Stocks
                    .Select(x => new
                    {
                        x.stock_id,
                        Ürün = x.Product.product_name,
                        Şube = x.Branch.branch_name,
                        Stok = x.quantity
                    })
                    .ToList();
            }
            else
            {
                dgv_stock.DataSource = db.Stocks
                    .Where(x => x.Product.product_name
                    .Contains(txt_search.Text))
                    .Select(x => new
                    {
                        x.stock_id,
                        Ürün = x.Product.product_name,
                        Şube = x.Branch.branch_name,
                        Stok = x.quantity
                    })
                    .ToList();
            }
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
            if (dgv_stock.Columns[e.ColumnIndex].Name == "Stok")
            {
                int stock = Convert.ToInt32(e.Value);

                if (stock <= 5)
                {
                    dgv_stock.Rows[e.RowIndex]
                        .DefaultCellStyle.BackColor =
                        Color.FromArgb(255, 230, 230);
                }
                else if (stock <= 10)
                {
                    dgv_stock.Rows[e.RowIndex]
                        .DefaultCellStyle.BackColor =
                        Color.FromArgb(255, 248, 220);
                }
            }
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
        private void dgv_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_stock.Columns[e.ColumnIndex].Name == "DeleteIcon")
            {
                DialogResult cevap = MessageBox.Show(
                    "Silmek istediğinize emin misiniz?",
                    "Stok Sil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    int stockId = Convert.ToInt32(
                        dgv_stock.Rows[e.RowIndex].Cells["stock_id"].Value);

                    var stock = db.Stocks.Find(stockId);

                    if (stock != null)
                    {
                        db.Stocks.Remove(stock);

                        db.SaveChanges();

                        dgv_stock.DataSource = db.Stocks
                            .Select(x => new
                            {
                                x.stock_id,
                                Ürün = x.Product.product_name,
                                Şube = x.Branch.branch_name,
                                Stok = x.quantity
                            })
                            .ToList();

                    }
                }
            }
            if (dgv_stock.Columns[e.ColumnIndex].Name == "EditIcon")
            {
                combo_branch.Text =
                    dgv_stock.Rows[e.RowIndex].Cells["Şube"].Value.ToString();

                combo_product.Text =
                    dgv_stock.Rows[e.RowIndex].Cells["Ürün"].Value.ToString();

                txt_stock_quantity.Text =
                    dgv_stock.Rows[e.RowIndex].Cells["Stok"].Value.ToString();

                selectedStockId = Convert.ToInt32(
                    dgv_stock.Rows[e.RowIndex].Cells["stock_id"].Value);
            }
        }
    }
}
