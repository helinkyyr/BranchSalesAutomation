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
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int stockId = Convert.ToInt32(combo_stock.SelectedValue);
               

                int salesQuantity = Convert.ToInt32(txt_quantity.Text);

                Stock stock = db.Stocks.Find(stockId);

                if (stock.quantity < salesQuantity)
                {
                    MessageBox.Show("Yetersiz stok!");

                    return;
                }

                Sales sales = new Sales()
                {
                    stock_id = stockId,
                    quantity = salesQuantity,
                    sale_date = DateTime.Now ,
                    country_id = 1
                };
                 
                db.Sales.Add(sales);

                stock.quantity -= salesQuantity;


                db.SaveChanges();

                MessageBox.Show("Satış kaydedildi!");

                btn_list.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {

            dgv_sales.DataSource = db.Sales.Select(x => new
            {
                İşlem_Sayısı = x.sale_id,


                Şube = db.Stocks
            .Where(s => s.stock_id == x.stock_id)
            .Select(s => db.Branches
                .Where(b => b.branch_id == s.branch_id)
                .Select(b => b.branch_name)
                .FirstOrDefault())
            .FirstOrDefault(),

                Ürün = db.Stocks
            .Where(s => s.stock_id == x.stock_id)
            .Select(s => db.Products
                .Where(p => p.product_id == s.product_id)
                .Select(p => p.product_name)
                .FirstOrDefault())
            .FirstOrDefault(),

                Satılan_Adet = x.quantity,

                Satış_Tarihi = x.sale_date
            }).ToList();

            dgv_sales.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                int saleId = Convert.ToInt32(
                    dgv_sales.CurrentRow.Cells["İşlem_Sayısı"].Value);

                Sales sales = db.Sales.Find(saleId);

                Stock stock = db.Stocks.Find(sales.stock_id);

                stock.quantity += sales.quantity;

                db.Sales.Remove(sales);

                db.SaveChanges();

                MessageBox.Show("İade işlemi yapıldı");

                btn_list.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_sales.DataSource = db.Sales.Select(x => new
            {
                x.stock_id,

                Şube = db.Stocks
    .Where(s => s.stock_id == x.stock_id)
    .Select(s => db.Branches
        .Where(b => b.branch_id == s.branch_id)
        .Select(b => b.branch_name)
        .FirstOrDefault())
    .FirstOrDefault(),

                Ürün = db.Stocks
    .Where(s => s.stock_id == x.stock_id)
    .Select(s => db.Products
        .Where(p => p.product_id == s.product_id)
        .Select(p => p.product_name)
        .FirstOrDefault())
    .FirstOrDefault(),

                Satılan_Adet = x.quantity,

                Satış_Tarihi = x.sale_date
            }).ToList();

            dgv_sales.Columns["stock_id"].Visible = false;

            dgv_sales.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
