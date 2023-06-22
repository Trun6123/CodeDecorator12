namespace QuanLy
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thẻKMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnVậnChuyểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.quảnLýKHToolStripMenuItem,
            this.orderToolStripMenuItem2,
            this.productToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem1});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.orderToolStripMenuItem.Text = "Tài khoản";
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.orderToolStripMenuItem1.Text = "User";
            this.orderToolStripMenuItem1.Click += new System.EventHandler(this.orderToolStripMenuItem1_Click);
            // 
            // quảnLýKHToolStripMenuItem
            // 
            this.quảnLýKHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHangToolStripMenuItem});
            this.quảnLýKHToolStripMenuItem.Name = "quảnLýKHToolStripMenuItem";
            this.quảnLýKHToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.quảnLýKHToolStripMenuItem.Text = "Quản lý KH";
            // 
            // kháchHangToolStripMenuItem
            // 
            this.kháchHangToolStripMenuItem.Name = "kháchHangToolStripMenuItem";
            this.kháchHangToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.kháchHangToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHangToolStripMenuItem.Click += new System.EventHandler(this.kháchHangToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem2
            // 
            this.orderToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtHàngToolStripMenuItem});
            this.orderToolStripMenuItem2.Name = "orderToolStripMenuItem2";
            this.orderToolStripMenuItem2.Size = new System.Drawing.Size(110, 20);
            this.orderToolStripMenuItem2.Text = "Quản lý đặt hàng";
            // 
            // đặtHàngToolStripMenuItem
            // 
            this.đặtHàngToolStripMenuItem.Name = "đặtHàngToolStripMenuItem";
            this.đặtHàngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đặtHàngToolStripMenuItem.Text = "Đặt hàng";
            this.đặtHàngToolStripMenuItem.Click += new System.EventHandler(this.đặtHàngToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.thẻKMToolStripMenuItem,
            this.tiềnVậnChuyểnToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.productToolStripMenuItem.Text = "Quản lý NCC";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addProductToolStripMenuItem.Text = "Nhà Cung cấp";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // thẻKMToolStripMenuItem
            // 
            this.thẻKMToolStripMenuItem.Name = "thẻKMToolStripMenuItem";
            this.thẻKMToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.thẻKMToolStripMenuItem.Text = "Thẻ KM";
            this.thẻKMToolStripMenuItem.Click += new System.EventHandler(this.thẻKMToolStripMenuItem_Click);
            // 
            // tiềnVậnChuyểnToolStripMenuItem
            // 
            this.tiềnVậnChuyểnToolStripMenuItem.Name = "tiềnVậnChuyểnToolStripMenuItem";
            this.tiềnVậnChuyểnToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tiềnVậnChuyểnToolStripMenuItem.Text = "Tiền Vận chuyển";
            this.tiềnVậnChuyểnToolStripMenuItem.Click += new System.EventHandler(this.tiềnVậnChuyểnToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem đặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thẻKMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnVậnChuyểnToolStripMenuItem;
    }
}