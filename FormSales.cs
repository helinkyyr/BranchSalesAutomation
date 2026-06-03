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

namespace BranchSalesAutomation
{
    public partial class FormSales : Form
    {

        BranchSalesDbContext db = new BranchSalesDbContext();
        public FormSales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormSales_Load(object sender, EventArgs e)
        {
          
            combo_stock.DataSource = db.Stocks
        .Select(x => new
        {
            x.stock_id,
            Text =
            db.Products
        .Where(p => p.product_id == x.product_id)
        .Select(p => p.product_name)
        .FirstOrDefault()

             + " - Stok: " +

            x.quantity
        })
        .ToList();

            combo_stock.DisplayMember = "Text";

            combo_stock.ValueMember = "stock_id";

            dgv_sales.ReadOnly = true;

            dgv_sales.AllowUserToAddRows = false;

            dgv_sales.AllowUserToDeleteRows = false;

            dgv_sales.EditMode =
        DataGridViewEditMode.EditProgrammatically;

            dgv_sales.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv_sales.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_sales.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            dgv_sales.ColumnHeadersHeight = 40;

            dgv_sales.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv_sales.RowTemplate.Height = 35;

            dgv_sales.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(245, 245, 245);

            dgv_sales.DefaultCellStyle.SelectionForeColor =
                Color.Black;
            dgv_sales.BorderStyle = BorderStyle.None;

            dgv_sales.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgv_sales.GridColor =
                Color.FromArgb(235, 235, 235);

            dgv_sales.BackgroundColor = Color.White;

            dgv_sales.RowHeadersVisible = false;

            dgv_sales.EnableHeadersVisualStyles = false;

            dgv_sales.ColumnHeadersDefaultCellStyle.BackColor =
                Color.White;
            dgv_sales.AutoGenerateColumns = false;

            dgv_sales.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.Black;

            dgv_sales.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 11);

            dgv_sales.ColumnHeadersHeight = 40;

            dgv_sales.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv_sales.RowTemplate.Height = 35;

            dgv_sales.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(245, 245, 245);

            dgv_sales.DefaultCellStyle.SelectionForeColor =
                Color.Black;
            dgv_sales.AutoGenerateColumns = false;

            dgv_sales.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(249, 249, 249);
            dgv_sales.Columns.Clear();

            dgv_sales.Columns.Add("Şube", "Şube");
            dgv_sales.Columns.Add("Ürün", "Ürün");
            dgv_sales.Columns.Add("Satılan_Adet", "Satılan Adet");
            dgv_sales.Columns.Add("Satış_Tarihi", "Satış Tarihi");

            dgv_sales.Columns["Şube"].DataPropertyName = "Şube";
            dgv_sales.Columns["Ürün"].DataPropertyName = "Ürün";
            dgv_sales.Columns["Satılan_Adet"].DataPropertyName = "Satılan_Adet";
            dgv_sales.Columns["Satış_Tarihi"].DataPropertyName = "Satış_Tarihi";
            LoadSales();
            LoadStockCombo();
            GetTotalSales();
            GetTotalRevenue();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
                int stockId =
         Convert.ToInt32(combo_stock.SelectedValue);

                if (string.IsNullOrWhiteSpace(txt_quantity.Text))
                {
                    MessageBox.Show("Miktar giriniz");
                    return;
                }

                int quantity;

                if (!int.TryParse(txt_quantity.Text, out quantity))
                {
                    MessageBox.Show("Geçerli sayı giriniz");
                    return;
                }

                var stock = db.Stocks
                    .FirstOrDefault(x => x.stock_id == stockId);

                if (stock == null)
                {
                    MessageBox.Show("Stok bulunamadı");
                    return;
                }

                if (stock.quantity < quantity)
                {
                    MessageBox.Show("Yetersiz stok");
                    return;
                }

                Sales sale = new Sales();

                sale.stock_id = stockId;
                sale.quantity = quantity;
                sale.sale_date = DateTime.Now;
                var product = db.Products.Find(stock.product_id);

                sale.unit_price = product.product_price;
                sale.total = quantity * product.product_price;
                db.Sales.Add(sale);

                stock.quantity -= quantity;

                db.SaveChanges();
            FormReports reportsForm =
            Application.OpenForms["FormReports"] as FormReports;

            if (reportsForm != null)
            {
                reportsForm.RefreshReports();
            }
            FormMain mainForm =
            Application.OpenForms["FormMain"] as FormMain;

            if (mainForm != null)
            {
                mainForm.RefreshDashboard();
            }

            MessageBox.Show("Satış kaydedildi");
                LoadSales();

                dgv_sales.Refresh();
            LoadSales();
                LoadStockCombo();
                GetTotalSales();
                GetTotalRevenue();

            txt_quantity.Clear();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            FormReports frm = new FormReports();

            frm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormMain.DashboardData();
            Program.FormMain.Show();

            this.Close();
        }
    
       void LoadSales()
        {

            dgv_sales.DataSource = db.Sales
                .Where(x => x.stock_id != 10)
                .Select(x => new
         {
             sale_id = x.sale_id,

             Şube = db.Stocks
                 .Where(s => s.stock_id == x.stock_id)
                 .Select(s => s.Branch.branch_name)
                 .FirstOrDefault(),

             Ürün = db.Stocks
                 .Where(s => s.stock_id == x.stock_id)
                 .Select(s => s.Product.product_name)
                 .FirstOrDefault(),

             Satılan_Adet = x.quantity,

             Satış_Tarihi = x.sale_date


         })
         .ToList();
            if (dgv_sales.Columns["sale_id"] != null)
            {
                dgv_sales.Columns["sale_id"].Visible = false;
            }

          
            dgv_sales.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadStockCombo()
        {
            combo_stock.DataSource = db.Stocks
                .Select(x => new
                {
                    x.stock_id,
                    Text = x.Product.product_name + " - Stok: " + x.quantity
                })
                .ToList();

            combo_stock.DisplayMember = "Text";

            combo_stock.ValueMember = "stock_id";
        }

        void GetTotalSales()
        {
            lblTotalSales.Text =
                db.Sales.Count().ToString();
        }

        void GetTotalRevenue()
        {
            decimal total = db.Sales
        .Sum(x => (decimal?)x.quantity * 100) ?? 0;

            lblTotalCiro.Text =
                total.ToString("N0") + " ₺";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_sales.DataSource = null;

            LoadSales();

            dgv_sales.Refresh();

            MessageBox.Show("Liste yenilendi");
        }
    }
}