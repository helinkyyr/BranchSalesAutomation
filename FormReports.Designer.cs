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
            this.dgv_reports = new System.Windows.Forms.DataGridView();
            this.btn_top_products = new System.Windows.Forms.Button();
            this.btn_low_products = new System.Windows.Forms.Button();
            this.btn_critical_stock = new System.Windows.Forms.Button();
            this.btn_branch_sales = new System.Windows.Forms.Button();
            this.btn_high_stock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reports
            // 
            this.dgv_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reports.Location = new System.Drawing.Point(1, 0);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.RowHeadersWidth = 51;
            this.dgv_reports.RowTemplate.Height = 24;
            this.dgv_reports.Size = new System.Drawing.Size(1389, 373);
            this.dgv_reports.TabIndex = 0;
            // 
            // btn_top_products
            // 
            this.btn_top_products.Location = new System.Drawing.Point(89, 398);
            this.btn_top_products.Name = "btn_top_products";
            this.btn_top_products.Size = new System.Drawing.Size(204, 48);
            this.btn_top_products.TabIndex = 1;
            this.btn_top_products.Text = "En Çok Satan Ürünler";
            this.btn_top_products.UseVisualStyleBackColor = true;
            this.btn_top_products.Click += new System.EventHandler(this.btn_top_products_Click);
            // 
            // btn_low_products
            // 
            this.btn_low_products.Location = new System.Drawing.Point(89, 452);
            this.btn_low_products.Name = "btn_low_products";
            this.btn_low_products.Size = new System.Drawing.Size(204, 48);
            this.btn_low_products.TabIndex = 2;
            this.btn_low_products.Text = "En Az Satan Ürünler";
            this.btn_low_products.UseVisualStyleBackColor = true;
            this.btn_low_products.Click += new System.EventHandler(this.btn_low_products_Click);
            // 
            // btn_critical_stock
            // 
            this.btn_critical_stock.Location = new System.Drawing.Point(354, 424);
            this.btn_critical_stock.Name = "btn_critical_stock";
            this.btn_critical_stock.Size = new System.Drawing.Size(204, 48);
            this.btn_critical_stock.TabIndex = 3;
            this.btn_critical_stock.Text = "Azalan Stoklar";
            this.btn_critical_stock.UseVisualStyleBackColor = true;
            this.btn_critical_stock.Click += new System.EventHandler(this.btn_critical_stock_Click);
            // 
            // btn_branch_sales
            // 
            this.btn_branch_sales.Location = new System.Drawing.Point(597, 424);
            this.btn_branch_sales.Name = "btn_branch_sales";
            this.btn_branch_sales.Size = new System.Drawing.Size(204, 48);
            this.btn_branch_sales.TabIndex = 4;
            this.btn_branch_sales.Text = "Şubelere Göre Satış";
            this.btn_branch_sales.UseVisualStyleBackColor = true;
            this.btn_branch_sales.Click += new System.EventHandler(this.btn_branch_sales_Click);
            // 
            // btn_high_stock
            // 
            this.btn_high_stock.Location = new System.Drawing.Point(835, 424);
            this.btn_high_stock.Name = "btn_high_stock";
            this.btn_high_stock.Size = new System.Drawing.Size(197, 48);
            this.btn_high_stock.TabIndex = 5;
            this.btn_high_stock.Text = "Stok Fazlası Ürünler";
            this.btn_high_stock.UseVisualStyleBackColor = true;
            this.btn_high_stock.Click += new System.EventHandler(this.btn_high_stock_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 583);
            this.Controls.Add(this.btn_high_stock);
            this.Controls.Add(this.btn_branch_sales);
            this.Controls.Add(this.btn_critical_stock);
            this.Controls.Add(this.btn_low_products);
            this.Controls.Add(this.btn_top_products);
            this.Controls.Add(this.dgv_reports);
            this.Name = "FormReports";
            this.Text = "Satış ve Stok Raporları";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reports;
        private System.Windows.Forms.Button btn_top_products;
        private System.Windows.Forms.Button btn_low_products;
        private System.Windows.Forms.Button btn_critical_stock;
        private System.Windows.Forms.Button btn_branch_sales;
        private System.Windows.Forms.Button btn_high_stock;
    }
}