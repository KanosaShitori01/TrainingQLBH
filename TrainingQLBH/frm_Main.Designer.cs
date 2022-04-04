namespace TrainingQLBH
{
    partial class frm_Main
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
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NDL_menuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngHopwjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDanhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.NDL_menuToolStrip,
            this.tổngHopwjToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngKýToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // NDL_menuToolStrip
            // 
            this.NDL_menuToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDanhSáchNhânViênToolStripMenuItem,
            this.nhậpPhòngBanToolStripMenuItem});
            this.NDL_menuToolStrip.Enabled = false;
            this.NDL_menuToolStrip.Name = "NDL_menuToolStrip";
            this.NDL_menuToolStrip.Size = new System.Drawing.Size(91, 20);
            this.NDL_menuToolStrip.Text = "Nhập Dữ Liệu";
            // 
            // tổngHopwjToolStripMenuItem
            // 
            this.tổngHopwjToolStripMenuItem.Enabled = false;
            this.tổngHopwjToolStripMenuItem.Name = "tổngHopwjToolStripMenuItem";
            this.tổngHopwjToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tổngHopwjToolStripMenuItem.Text = "Tổng Hợp";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngKýToolStripMenuItem.Text = "Đăng Ký";
            // 
            // nhậpDanhSáchNhânViênToolStripMenuItem
            // 
            this.nhậpDanhSáchNhânViênToolStripMenuItem.Name = "nhậpDanhSáchNhânViênToolStripMenuItem";
            this.nhậpDanhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.nhậpDanhSáchNhânViênToolStripMenuItem.Text = "Nhập danh sách nhân viên";
            // 
            // nhậpPhòngBanToolStripMenuItem
            // 
            this.nhậpPhòngBanToolStripMenuItem.Name = "nhậpPhòngBanToolStripMenuItem";
            this.nhậpPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.nhậpPhòngBanToolStripMenuItem.Text = "Nhập phòng ban";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 145);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngHopwjToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nhậpDanhSáchNhânViênToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem NDL_menuToolStrip;
        public System.Windows.Forms.ToolStripMenuItem nhậpPhòngBanToolStripMenuItem;
    }
}

