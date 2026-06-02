namespace BranchSalesAutomation
{
    partial class FormStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.combo_branch = new System.Windows.Forms.ComboBox();
            this.txt_stock_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_product = new System.Windows.Forms.ComboBox();
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAddStock = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditIcon = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.panel_sidebar.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelAddStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_stock
            // 
            this.dgv_stock.AllowUserToAddRows = false;
            this.dgv_stock.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stock.BackgroundColor = System.Drawing.Color.White;
            this.dgv_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteIcon,
            this.EditIcon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_stock.EnableHeadersVisualStyles = false;
            this.dgv_stock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv_stock.Location = new System.Drawing.Point(250, 124);
            this.dgv_stock.MultiSelect = false;
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersVisible = false;
            this.dgv_stock.RowHeadersWidth = 51;
            this.dgv_stock.RowTemplate.Height = 35;
            this.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock.Size = new System.Drawing.Size(1440, 638);
            this.dgv_stock.TabIndex = 0;
            this.dgv_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_CellContentClick);
            this.dgv_stock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_stock_CellFormatting);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.White;
            this.btn_list.ForeColor = System.Drawing.Color.Black;
            this.btn_list.Location = new System.Drawing.Point(951, 955);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(159, 17);
            this.btn_list.TabIndex = 1;
            this.btn_list.Text = "LİSTELE";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Visible = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(782, 955);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(159, 17);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(1160, 89);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 40);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Kaydet";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // combo_branch
            // 
            this.combo_branch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_branch.FormattingEnabled = true;
            this.combo_branch.Location = new System.Drawing.Point(50, 93);
            this.combo_branch.Name = "combo_branch";
            this.combo_branch.Size = new System.Drawing.Size(220, 31);
            this.combo_branch.TabIndex = 4;
            // 
            // txt_stock_quantity
            // 
            this.txt_stock_quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_stock_quantity.Location = new System.Drawing.Point(787, 94);
            this.txt_stock_quantity.Name = "txt_stock_quantity";
            this.txt_stock_quantity.Size = new System.Drawing.Size(220, 30);
            this.txt_stock_quantity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şube ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(433, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(784, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stok";
            // 
            // combo_product
            // 
            this.combo_product.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_product.FormattingEnabled = true;
            this.combo_product.Location = new System.Drawing.Point(436, 93);
            this.combo_product.Name = "combo_product";
            this.combo_product.Size = new System.Drawing.Size(220, 31);
            this.combo_product.TabIndex = 5;
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
            this.panel_sidebar.Size = new System.Drawing.Size(244, 984);
            this.panel_sidebar.TabIndex = 10;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panelAdmin.Controls.Add(this.label28);
            this.panelAdmin.Controls.Add(this.label27);
            this.panelAdmin.Controls.Add(this.panelAdminIkon);
            this.panelAdmin.Location = new System.Drawing.Point(12, 873);
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
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(12, 373);
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
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 438);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(210, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Raporlar";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 70);
            this.label4.TabIndex = 0;
            this.label4.Text = " Branch Sales\nAutomation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 306);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(210, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Stok";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
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
            this.button1.Location = new System.Drawing.Point(13, 169);
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
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(120)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 235);
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
            this.panelTop.Controls.Add(this.txt_search);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1443, 120);
            this.panelTop.TabIndex = 11;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(1141, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(293, 30);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.MouseEnter += new System.EventHandler(this.txt_search_MouseEnter);
            this.txt_search.MouseLeave += new System.EventHandler(this.txt_search_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(28, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stokları görüntüle, ekle ve düzenle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(24, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stok";
            // 
            // panelAddStock
            // 
            this.panelAddStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAddStock.Controls.Add(this.label7);
            this.panelAddStock.Controls.Add(this.combo_branch);
            this.panelAddStock.Controls.Add(this.label1);
            this.panelAddStock.Controls.Add(this.combo_product);
            this.panelAddStock.Controls.Add(this.btn_add);
            this.panelAddStock.Controls.Add(this.label2);
            this.panelAddStock.Controls.Add(this.txt_stock_quantity);
            this.panelAddStock.Controls.Add(this.label3);
            this.panelAddStock.Location = new System.Drawing.Point(293, 765);
            this.panelAddStock.Name = "panelAddStock";
            this.panelAddStock.Size = new System.Drawing.Size(1317, 188);
            this.panelAddStock.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yeni Stok Ekle";
            // 
            // DeleteIcon
            // 
            this.DeleteIcon.HeaderText = "sil";
            this.DeleteIcon.Image = ((System.Drawing.Image)(resources.GetObject("DeleteIcon.Image")));
            this.DeleteIcon.MinimumWidth = 6;
            this.DeleteIcon.Name = "DeleteIcon";
            // 
            // EditIcon
            // 
            this.EditIcon.HeaderText = "Düzenle";
            this.EditIcon.Image = ((System.Drawing.Image)(resources.GetObject("EditIcon.Image")));
            this.EditIcon.MinimumWidth = 6;
            this.EditIcon.Name = "EditIcon";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 984);
            this.Controls.Add(this.panelAddStock);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_stock);
            this.Name = "FormStock";
            this.Text = "Şube Stok Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.panel_sidebar.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelAddStock.ResumeLayout(false);
            this.panelAddStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox combo_branch;
        private System.Windows.Forms.TextBox txt_stock_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_product;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panelAddStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panelAdminIkon;
        private System.Windows.Forms.DataGridViewImageColumn DeleteIcon;
        private System.Windows.Forms.DataGridViewImageColumn EditIcon;
    }
}