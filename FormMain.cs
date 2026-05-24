using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace BranchSalesAutomation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
          
            this.Size = new Size(1400, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            MakePanelCircular(panel_icon_products);

        }


        private void btn_product_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();

            formProduct.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();

            formStock.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();

            formSales.Show();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();

            formReports.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, panel2.Width - 1, panel2.Height - 1);
            panel2.Region = new Region(gp);

            GraphicsPath gp1 = new GraphicsPath();
            gp1.AddEllipse(0, 0, panel5.Width - 1, panel5.Height - 1);
            panel5.Region = new Region(gp1);

            GraphicsPath gp2 = new GraphicsPath();
            gp2.AddEllipse(0, 0, panel17.Width - 1, panel17.Height - 1);
            panel17.Region = new Region(gp2);

            GraphicsPath pathSummary = new GraphicsPath();

            pathSummary.AddArc(0, 0, 20, 20, 180, 90);
            pathSummary.AddArc(panelSummaryBackground.Width - 20, 0, 20, 20, 270, 90);
            pathSummary.AddArc(panelSummaryBackground.Width - 20, panelSummaryBackground.Height - 20, 20, 20, 0, 90);
            pathSummary.AddArc(0, panelSummaryBackground.Height - 20, 20, 20, 90, 90);

            pathSummary.CloseFigure();

            panelSummaryBackground.Region = new Region(pathSummary);

            GraphicsPath paneltotalproduct = new GraphicsPath();

            paneltotalproduct.AddArc(0, 0, 15, 15, 180, 90);
            paneltotalproduct.AddArc(panelTotalProduct.Width - 15, 0, 15, 15, 270, 90);
            paneltotalproduct.AddArc(panelTotalProduct.Width - 15, panelTotalProduct.Height - 15, 15, 15, 0, 90);
            paneltotalproduct.AddArc(0, panelTotalProduct.Height - 15, 15, 15, 90, 90);

            paneltotalproduct.CloseFigure();

            panelTotalProduct.Region = new Region(paneltotalproduct);
            GraphicsPath panel3Path = new GraphicsPath();

            panel3Path.AddArc(0, 0, 15, 15, 180, 90);
            panel3Path.AddArc(panel3.Width - 15, 0, 15, 15, 270, 90);
            panel3Path.AddArc(panel3.Width - 15, panel3.Height - 15, 15, 15, 0, 90);
            panel3Path.AddArc(0, panel3.Height - 15, 15, 15, 90, 90);

            panel3Path.CloseFigure();

            panel3.Region = new Region(panel3Path);



            GraphicsPath panel8Path = new GraphicsPath();

            panel8Path.AddArc(0, 0, 15, 15, 180, 90);
            panel8Path.AddArc(panel8.Width - 15, 0, 15, 15, 270, 90);
            panel8Path.AddArc(panel8.Width - 15, panel8.Height - 15, 15, 15, 0, 90);
            panel8Path.AddArc(0, panel8.Height - 15, 15, 15, 90, 90);

            panel8Path.CloseFigure();

            panel8.Region = new Region(panel8Path);
            GraphicsPath panel9Path = new GraphicsPath();

            panel9Path.AddArc(0, 0, 15, 15, 180, 90);
            panel9Path.AddArc(panel9.Width - 15, 0, 15, 15, 270, 90);
            panel9Path.AddArc(panel9.Width - 15, panel9.Height - 15, 15, 15, 0, 90);
            panel9Path.AddArc(0, panel9.Height - 15, 15, 15, 90, 90);

            panel9Path.CloseFigure();

            panel9.Region = new Region(panel9Path);

            GraphicsPath adminPath = new GraphicsPath();

            adminPath.AddArc(0, 0, 18, 18, 180, 90);
            adminPath.AddArc(panelAdmin.Width - 18, 0, 18, 18, 270, 90);
            adminPath.AddArc(panelAdmin.Width - 18, panelAdmin.Height - 18, 18, 18, 0, 90);
            adminPath.AddArc(0, panelAdmin.Height - 18, 18, 18, 90, 90);

            adminPath.CloseFigure();

            panelAdmin.Region = new Region(adminPath);

            GraphicsPath iconPath = new GraphicsPath();

            iconPath.AddEllipse(0, 0, panelAdminIkon.Width - 1, panelAdminIkon.Height - 1);

            panelAdminIkon.Region = new Region(iconPath);

        }
        private void MakePanelCircular(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(0, 0, panel.Width, panel.Height);

            panel.Region = new Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelStockIcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_products_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(0, 0, 20, 20, 180, 90);
            gp.AddArc(panel_products.Width - 20, 0, 20, 20, 270, 90);
            gp.AddArc(panel_products.Width - 20, panel_products.Height - 20, 20, 20, 0, 90);
            gp.AddArc(0, panel_products.Height - 20, 20, 20, 90, 90);

            gp.CloseFigure();

            panel_products.Region = new Region(gp);
        }

        private void panel_stock_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(0, 0, 20, 20, 180, 90);
            gp.AddArc(panel_stock.Width - 20, 0, 20, 20, 270, 90);
            gp.AddArc(panel_stock.Width - 20, panel_stock.Height - 20, 20, 20, 0, 90);
            gp.AddArc(0, panel_stock.Height - 20, 20, 20, 90, 90);

            gp.CloseFigure();

            panel_stock.Region = new Region(gp);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(0, 0, 20, 20, 180, 90);
            gp.AddArc(panel4.Width - 20, 0, 20, 20, 270, 90);
            gp.AddArc(panel4.Width - 20, panel4.Height - 20, 20, 20, 0, 90);
            gp.AddArc(0, panel4.Height - 20, 20, 20, 90, 90);

            gp.CloseFigure();

            panel4.Region = new Region(gp);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(0, 0, 20, 20, 180, 90);
            gp.AddArc(panel6.Width - 20, 0, 20, 20, 270, 90);
            gp.AddArc(panel6.Width - 20, panel6.Height - 20, 20, 20, 0, 90);
            gp.AddArc(0, panel6.Height - 20, 20, 20, 90, 90);

            gp.CloseFigure();

            panel6.Region = new Region(gp);
        }

        private void panel_products_MouseEnter(object sender, EventArgs e)
        {
            panel_products.BackColor = Color.FromArgb(245, 247, 255);
        }

        private void panel_products_MouseLeave(object sender, EventArgs e)
        {
            panel_products.BackColor = Color.White;
        }

        private void panel_stock_MouseEnter(object sender, EventArgs e)
        {
            panel_stock.BackColor = Color.FromArgb(245, 247, 255);
        }

        private void panel_stock_MouseLeave(object sender, EventArgs e)
        {
            panel_stock.BackColor = Color.White;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(245, 247, 255);
        }


        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(245, 247, 255);
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.White;
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAdmin_MouseEnter(object sender, EventArgs e)
        {
            panelAdmin.BackColor = Color.FromArgb(25, 40, 75);
        }

        private void panelAdmin_MouseLeave(object sender, EventArgs e)
        {
            panelAdmin.BackColor = Color.FromArgb(20, 30, 60);
        }
    }
}
