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
using System.Windows.Forms.DataVisualization.Charting;
namespace BranchSalesAutomation
{
    public partial class FormReports : Form
    {
        BranchSalesDbContext db = new BranchSalesDbContext();
            public FormReports()
        {
            InitializeComponent();

            dgv_reports.BorderStyle = BorderStyle.None;

            dgv_reports.BackgroundColor = Color.White;

            dgv_reports.RowHeadersVisible = false;

            dgv_reports.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv_reports.EnableHeadersVisualStyles = false;

            dgv_reports.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(99, 102, 241);

            dgv_reports.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv_reports.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv_reports.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv_reports.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(224, 231, 255);

            dgv_reports.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgv_reports.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgv_reports.GridColor =
                Color.FromArgb(230, 230, 230);
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
            chart_sales.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_sales.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart_products.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_products.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_products.Series[0]["PieLabelStyle"] = "Disabled";
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            LoadSalesChart();
            LoadProductChart();
            LoadSummary();
        }
        void LoadSalesChart()
        {
            chart_sales.Series.Clear();

            Series s = new Series();
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s.Color = Color.FromArgb(79, 70, 229);

            var data = db.Sales
              .AsEnumerable()
              .GroupBy(x => x.sale_date.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    Total = g.Sum(x => x.total)
                })
                .ToList();
            s["PointWidth"] = "0.5";

            foreach (var item in data)
            {
                s.Points.AddXY(
                    item.Date.ToString("dd.MM"),
                    item.Total );
            }

            chart_sales.Series.Add(s);
        }
        void LoadProductChart()
        {
            chart_products.Series.Clear();

            Series s = new Series();
            s.ChartType = SeriesChartType.Doughnut;
            s["PieLabelStyle"] = "Outside";
            s.BorderWidth = 2;

            var data = db.Sales
                .GroupBy(x => x.Stock.Product.product_name)
                .Select(g => new
                {
                    Product = g.Key,
                    Total = g.Sum(x => x.quantity)
                })
                .Take(5)
                .ToList();
            chart_products.Legends[0].Font =
             new Font("Segoe UI", 9);

            chart_products.Palette =
                ChartColorPalette.BrightPastel;

            foreach (var item in data)
            {
                s.Points.AddXY(item.Product, item.Total);
            }

            chart_products.Series.Add(s);
        }
        void LoadSummary()
        {
            decimal total =
                db.Sales.Sum(x => (decimal?)x.total) ?? 0;

            int process =
                db.Sales.Count();

            string topProduct =
                db.Sales
                .GroupBy(x => x.Stock.Product.product_name)
                .OrderByDescending(g => g.Sum(x => x.quantity))
                .Select(g => g.Key)
                .FirstOrDefault();

            decimal average =
                process > 0 ? total / process : 0;

            label11.Text = total.ToString("N0") + " ₺";
            label12.Text = process.ToString();
            label14.Text = topProduct;
            label13.Text = average.ToString("N0") + " ₺";
        }

        private void chart_products_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProduct frm = new FormProduct();

            frm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormStock frm = new FormStock();

            frm.Show();

            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormSales frm = new FormSales();

            frm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Program.FormMain.DashboardData();
            Program.FormMain.Show();

            this.Close();
        }
    }
    
}
