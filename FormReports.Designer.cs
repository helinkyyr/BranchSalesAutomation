namespace BranchSalesAutomation
{
    partial class FormReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_reports = new System.Windows.Forms.DataGridView();
            this.btn_top_products = new System.Windows.Forms.Button();
            this.btn_low_products = new System.Windows.Forms.Button();
            this.btn_critical_stock = new System.Windows.Forms.Button();
            this.btn_branch_sales = new System.Windows.Forms.Button();
            this.btn_high_stock = new System.Windows.Forms.Button();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panelAdminIkon = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.panel_pie = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_summary = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            this.panel_sidebar.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel_chart.SuspendLayout();
            this.panel_pie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_products)).BeginInit();
            this.panel_summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_reports
            // 
            this.dgv_reports.BackgroundColor = System.Drawing.Color.White;
            this.dgv_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reports.Location = new System.Drawing.Point(1074, 31);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.RowHeadersWidth = 51;
            this.dgv_reports.RowTemplate.Height = 24;
            this.dgv_reports.Size = new System.Drawing.Size(116, 58);
            this.dgv_reports.TabIndex = 0;
            this.dgv_reports.Visible = false;
            // 
            // btn_top_products
            // 
            this.btn_top_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btn_top_products.FlatAppearance.BorderSize = 0;
            this.btn_top_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_top_products.ForeColor = System.Drawing.Color.White;
            this.btn_top_products.Location = new System.Drawing.Point(858, 35);
            this.btn_top_products.Name = "btn_top_products";
            this.btn_top_products.Size = new System.Drawing.Size(20, 10);
            this.btn_top_products.TabIndex = 1;
            this.btn_top_products.Text = "En Çok Satan Ürünler";
            this.btn_top_products.UseVisualStyleBackColor = false;
            this.btn_top_products.Visible = false;
            this.btn_top_products.Click += new System.EventHandler(this.btn_top_products_Click);
            // 
            // btn_low_products
            // 
            this.btn_low_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btn_low_products.FlatAppearance.BorderSize = 0;
            this.btn_low_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_low_products.ForeColor = System.Drawing.Color.White;
            this.btn_low_products.Location = new System.Drawing.Point(858, 81);
            this.btn_low_products.Name = "btn_low_products";
            this.btn_low_products.Size = new System.Drawing.Size(20, 10);
            this.btn_low_products.TabIndex = 2;
            this.btn_low_products.Text = "En Az Satan Ürünler";
            this.btn_low_products.UseVisualStyleBackColor = false;
            this.btn_low_products.Visible = false;
            this.btn_low_products.Click += new System.EventHandler(this.btn_low_products_Click);
            // 
            // btn_critical_stock
            // 
            this.btn_critical_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btn_critical_stock.FlatAppearance.BorderSize = 0;
            this.btn_critical_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_critical_stock.ForeColor = System.Drawing.Color.White;
            this.btn_critical_stock.Location = new System.Drawing.Point(897, 35);
            this.btn_critical_stock.Name = "btn_critical_stock";
            this.btn_critical_stock.Size = new System.Drawing.Size(20, 10);
            this.btn_critical_stock.TabIndex = 3;
            this.btn_critical_stock.Text = "Azalan Stoklar";
            this.btn_critical_stock.UseVisualStyleBackColor = false;
            this.btn_critical_stock.Visible = false;
            this.btn_critical_stock.Click += new System.EventHandler(this.btn_critical_stock_Click);
            // 
            // btn_branch_sales
            // 
            this.btn_branch_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btn_branch_sales.FlatAppearance.BorderSize = 0;
            this.btn_branch_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_branch_sales.ForeColor = System.Drawing.Color.White;
            this.btn_branch_sales.Location = new System.Drawing.Point(897, 81);
            this.btn_branch_sales.Name = "btn_branch_sales";
            this.btn_branch_sales.Size = new System.Drawing.Size(20, 10);
            this.btn_branch_sales.TabIndex = 4;
            this.btn_branch_sales.Text = "Şubelere Göre Satış";
            this.btn_branch_sales.UseVisualStyleBackColor = false;
            this.btn_branch_sales.Visible = false;
            this.btn_branch_sales.Click += new System.EventHandler(this.btn_branch_sales_Click);
            // 
            // btn_high_stock
            // 
            this.btn_high_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btn_high_stock.FlatAppearance.BorderSize = 0;
            this.btn_high_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_high_stock.ForeColor = System.Drawing.Color.White;
            this.btn_high_stock.Location = new System.Drawing.Point(885, 54);
            this.btn_high_stock.Name = "btn_high_stock";
            this.btn_high_stock.Size = new System.Drawing.Size(20, 10);
            this.btn_high_stock.TabIndex = 5;
            this.btn_high_stock.Text = "Stok Fazlası Ürünler";
            this.btn_high_stock.UseVisualStyleBackColor = false;
            this.btn_high_stock.Visible = false;
            this.btn_high_stock.Click += new System.EventHandler(this.btn_high_stock_Click);
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel_sidebar.Controls.Add(this.panelAdmin);
            this.panel_sidebar.Controls.Add(this.button9);
            this.panel_sidebar.Controls.Add(this.panel1);
            this.panel_sidebar.Controls.Add(this.button4);
            this.panel_sidebar.Controls.Add(this.label4);
            this.panel_sidebar.Controls.Add(this.button3);
            this.panel_sidebar.Controls.Add(this.button1);
            this.panel_sidebar.Controls.Add(this.button2);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(244, 967);
            this.panel_sidebar.TabIndex = 10;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panelAdmin.Controls.Add(this.label28);
            this.panelAdmin.Controls.Add(this.label27);
            this.panelAdmin.Controls.Add(this.panelAdminIkon);
            this.panelAdmin.Location = new System.Drawing.Point(12, 871);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(220, 80);
            this.panelAdmin.TabIndex = 10;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(220)))));
            this.label28.Location = new System.Drawing.Point(70, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 19);
            this.label28.TabIndex = 2;
            this.label28.Text = "Sistem Yöneticisi";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(70, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 25);
            this.label27.TabIndex = 1;
            this.label27.Text = "Helin Kayar";
            // 
            // panelAdminIkon
            // 
            this.panelAdminIkon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.panelAdminIkon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAdminIkon.BackgroundImage")));
            this.panelAdminIkon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAdminIkon.Location = new System.Drawing.Point(13, 17);
            this.panelAdminIkon.Name = "panelAdminIkon";
            this.panelAdminIkon.Size = new System.Drawing.Size(44, 44);
            this.panelAdminIkon.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(12, 367);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(210, 50);
            this.button9.TabIndex = 9;
            this.button9.Text = "Satışlar ";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(270, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 638);
            this.panel1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 441);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(210, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Raporlar";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(23, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 70);
            this.label4.TabIndex = 0;
            this.label4.Text = " Branch Sales\nAutomation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 296);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(210, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Stok";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 156);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(210, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ana Sayfa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 223);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(210, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ürünler";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.btn_top_products);
            this.panelTop.Controls.Add(this.btn_low_products);
            this.panelTop.Controls.Add(this.btn_branch_sales);
            this.panelTop.Controls.Add(this.dgv_reports);
            this.panelTop.Controls.Add(this.btn_high_stock);
            this.panelTop.Controls.Add(this.btn_critical_stock);
            this.panelTop.Location = new System.Drawing.Point(250, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1510, 120);
            this.panelTop.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(28, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rapor işlemlerinizi yönetin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Raporlar";
            // 
            // panel_chart
            // 
            this.panel_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_chart.BackColor = System.Drawing.Color.White;
            this.panel_chart.Controls.Add(this.chart_sales);
            this.panel_chart.Controls.Add(this.label1);
            this.panel_chart.Location = new System.Drawing.Point(250, 129);
            this.panel_chart.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(791, 580);
            this.panel_chart.TabIndex = 12;
            // 
            // panel_pie
            // 
            this.panel_pie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_pie.BackColor = System.Drawing.Color.White;
            this.panel_pie.Controls.Add(this.label2);
            this.panel_pie.Controls.Add(this.chart_products);
            this.panel_pie.Location = new System.Drawing.Point(1044, 129);
            this.panel_pie.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_pie.Name = "panel_pie";
            this.panel_pie.Size = new System.Drawing.Size(716, 580);
            this.panel_pie.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış Toplamı (Günlük)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Bazlı Satış Dağılımı";
            // 
            // chart_sales
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_sales.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_sales.Legends.Add(legend5);
            this.chart_sales.Location = new System.Drawing.Point(45, 94);
            this.chart_sales.Name = "chart_sales";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_sales.Series.Add(series5);
            this.chart_sales.Size = new System.Drawing.Size(710, 461);
            this.chart_sales.TabIndex = 1;
            this.chart_sales.Text = "chart1";
            // 
            // chart_products
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_products.ChartAreas.Add(chartArea6);
            this.chart_products.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.Name = "Legend1";
            this.chart_products.Legends.Add(legend6);
            this.chart_products.Location = new System.Drawing.Point(0, 0);
            this.chart_products.Name = "chart_products";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart_products.Series.Add(series6);
            this.chart_products.Size = new System.Drawing.Size(716, 580);
            this.chart_products.TabIndex = 2;
            this.chart_products.Text = "chart1";
            this.chart_products.Click += new System.EventHandler(this.chart_products_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(729, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rapor Özeti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(371, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Toplam Satış :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(367, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Toplam İşlem :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(918, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "En Çok Satan Ürün :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(893, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ortalama İşlem Tutarı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(619, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "0 ₺";
            // 
            // panel_summary
            // 
            this.panel_summary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_summary.BackColor = System.Drawing.Color.White;
            this.panel_summary.Controls.Add(this.label14);
            this.panel_summary.Controls.Add(this.label13);
            this.panel_summary.Controls.Add(this.label12);
            this.panel_summary.Controls.Add(this.label11);
            this.panel_summary.Controls.Add(this.label10);
            this.panel_summary.Controls.Add(this.label9);
            this.panel_summary.Controls.Add(this.label8);
            this.panel_summary.Controls.Add(this.label7);
            this.panel_summary.Controls.Add(this.label6);
            this.panel_summary.Location = new System.Drawing.Point(250, 715);
            this.panel_summary.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_summary.Name = "panel_summary";
            this.panel_summary.Size = new System.Drawing.Size(1502, 236);
            this.panel_summary.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(619, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "0 ₺";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(1190, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "0 ₺";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1190, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "-";
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1757, 967);
            this.Controls.Add(this.panel_summary);
            this.Controls.Add(this.panel_pie);
            this.Controls.Add(this.panel_chart);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel_sidebar);
            this.Name = "FormReports";
            this.Text = "Satış ve Stok Raporları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            this.panel_sidebar.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel_chart.ResumeLayout(false);
            this.panel_chart.PerformLayout();
            this.panel_pie.ResumeLayout(false);
            this.panel_pie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_products)).EndInit();
            this.panel_summary.ResumeLayout(false);
            this.panel_summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reports;
        private System.Windows.Forms.Button btn_top_products;
        private System.Windows.Forms.Button btn_low_products;
        private System.Windows.Forms.Button btn_critical_stock;
        private System.Windows.Forms.Button btn_branch_sales;
        private System.Windows.Forms.Button btn_high_stock;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panelAdminIkon;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.Panel panel_pie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_products;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_summary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}