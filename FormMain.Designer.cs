namespace BranchSalesAutomation
{
    partial class FormMain
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
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(42, 365);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(291, 58);
            this.btn_product.TabIndex = 0;
            this.btn_product.Text = "ÜRÜN YÖNETİMİ";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(370, 365);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(291, 58);
            this.btn_stock.TabIndex = 1;
            this.btn_stock.Text = "ŞUBE STOK YÖNETİMİ";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(708, 365);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(291, 58);
            this.btn_sales.TabIndex = 2;
            this.btn_sales.Text = "SATIŞ İŞLEMLERİ";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Location = new System.Drawing.Point(1038, 365);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(291, 58);
            this.btn_reports.TabIndex = 3;
            this.btn_reports.Text = "SATIŞ VE STOK RAPORLARI";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 505);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_product);
            this.Name = "FormMain";
            this.Text = "Şube Satış ve Stok Takip Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_reports;
    }
}