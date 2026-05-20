using BranchSalesAutomation.DatabaseContext;
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
    public partial class FormReports : Form
    {
        BranchSalesDbContext db = new BranchSalesDbContext();
        public FormReports()
        {
            InitializeComponent();
        }
         
        private void btn_top_products_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_reports.DataSource = db.Sales
                    .GroupBy(x => x.stock_id)
                    .Select(g => new
                    {
                        Ürün = db.Stocks
                            .Where(s => s.stock_id == g.Key)
                            .Select(s => s.Product.product_name)
                            .FirstOrDefault(),

                        Toplam_Satış = g.Sum(x => x.quantity)
                    })
                    .OrderByDescending(x => x.Toplam_Satış)
                    .ToList();

                dgv_reports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_reports.ReadOnly = true;

                dgv_reports.AllowUserToAddRows = false;
                dgv_reports.AllowUserToDeleteRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_low_products_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_reports.DataSource = db.Sales
                    .GroupBy(x => x.stock_id)
                    .Select(g => new
                    {
                        Ürün = db.Stocks
                            .Where(s => s.stock_id == g.Key)
                            .Select(s => s.Product.product_name)
                            .FirstOrDefault(),

                        Toplam_Satış = g.Sum(x => x.quantity)
                    })
                    .OrderBy(x => x.Toplam_Satış)
                    .ToList();

                dgv_reports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_reports.ReadOnly = true;

                dgv_reports.AllowUserToAddRows = false;
                dgv_reports.AllowUserToDeleteRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_critical_stock_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_reports.DataSource = db.Stocks
                    .Where(x => x.quantity < 20)
                    .Select(x => new
                    {
                        Şube = x.Branch.branch_name,

                        Ürün = x.Product.product_name,

                        Kalan_Stok = x.quantity
                    })
                    .ToList();

                dgv_reports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_reports.ReadOnly = true;

                dgv_reports.AllowUserToAddRows = false;
                dgv_reports.AllowUserToDeleteRows = false;

                foreach (DataGridViewRow row in dgv_reports.Rows)
                {

                    int stok =
                        Convert.ToInt32(row.Cells["Kalan_Stok"].Value);

                    if (stok < 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (stok < 20)
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_branch_sales_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_reports.DataSource = db.Sales
                    .GroupBy(x => new
                    {
                        Şube = db.Stocks
                            .Where(s => s.stock_id == x.stock_id)
                            .Select(s => s.Branch.branch_name)
                            .FirstOrDefault(),

                        Ürün = db.Stocks
                            .Where(s => s.stock_id == x.stock_id)
                            .Select(s => s.Product.product_name)
                            .FirstOrDefault()
                    })
                    .Select(g => new
                    {
                        Şube = g.Key.Şube,

                        Ürün = g.Key.Ürün,

                        Toplam_Satış = g.Sum(x => x.quantity)
                    })
                    .OrderByDescending(x => x.Toplam_Satış)
                    .ToList();

                dgv_reports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_reports.ReadOnly = true;

                dgv_reports.AllowUserToAddRows = false;
                dgv_reports.AllowUserToDeleteRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_high_stock_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_reports.DataSource = db.Stocks
                    .Where(x => x.quantity > 100)
                    .Select(x => new
                    {
                        Şube = x.Branch.branch_name,

                        Ürün = x.Product.product_name,

                        Stok_Miktarı = x.quantity
                    })
                    .OrderByDescending(x => x.Stok_Miktarı)
                    .ToList();

                dgv_reports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv_reports.ReadOnly = true;

                dgv_reports.AllowUserToAddRows = false;
                dgv_reports.AllowUserToDeleteRows = false;

                foreach (DataGridViewRow row in dgv_reports.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
