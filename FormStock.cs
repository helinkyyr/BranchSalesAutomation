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
                    x.branch_id,
                    x.product_id,
                    x.quantity
                }).ToList();

                dgv_stock.Columns["stock_id"].Visible = false;

                dgv_stock.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
    }
}
