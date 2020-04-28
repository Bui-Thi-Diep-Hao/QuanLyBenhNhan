namespace QuanLyBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMBacSi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuuBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCThongTInBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCThongTinThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDanhSachBenhAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormMain = new System.Windows.Forms.MenuStrip();
            this.mnuFormMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMBenhNhan,
            this.mnuDMBacSi,
            this.mnuDMThuoc});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "Danh Mục";
            // 
            // mnuDMBenhNhan
            // 
            this.mnuDMBenhNhan.Name = "mnuDMBenhNhan";
            this.mnuDMBenhNhan.Size = new System.Drawing.Size(164, 26);
            this.mnuDMBenhNhan.Text = "Bệnh Nhân";
            this.mnuDMBenhNhan.Click += new System.EventHandler(this.mnuDMBenhNhan_Click);
            // 
            // mnuDMBacSi
            // 
            this.mnuDMBacSi.Name = "mnuDMBacSi";
            this.mnuDMBacSi.Size = new System.Drawing.Size(164, 26);
            this.mnuDMBacSi.Text = "Bác Sĩ";
            this.mnuDMBacSi.Click += new System.EventHandler(this.mnuDMBacSi_Click);
            // 
            // mnuDMThuoc
            // 
            this.mnuDMThuoc.Name = "mnuDMThuoc";
            this.mnuDMThuoc.Size = new System.Drawing.Size(164, 26);
            this.mnuDMThuoc.Text = "Thuốc";
            // 
            // mnuTraCuuBenhAn
            // 
            this.mnuTraCuuBenhAn.Name = "mnuTraCuuBenhAn";
            this.mnuTraCuuBenhAn.Size = new System.Drawing.Size(132, 24);
            this.mnuTraCuuBenhAn.Text = "Tra Cứu Bệnh Án";
            this.mnuTraCuuBenhAn.Click += new System.EventHandler(this.mnuTraCuuBenhAn_Click);
            // 
            // mnuThongTinBenhAn
            // 
            this.mnuThongTinBenhAn.Name = "mnuThongTinBenhAn";
            this.mnuThongTinBenhAn.Size = new System.Drawing.Size(152, 24);
            this.mnuThongTinBenhAn.Text = "Thông Tin  Bệnh Án";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTKBenhNhan,
            this.mnuTKBenhAn});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(86, 24);
            this.mnuTimKiem.Text = "Tìm Kiếm";
            // 
            // mnuTKBenhNhan
            // 
            this.mnuTKBenhNhan.Name = "mnuTKBenhNhan";
            this.mnuTKBenhNhan.Size = new System.Drawing.Size(164, 26);
            this.mnuTKBenhNhan.Text = "Bệnh Nhân";
            // 
            // mnuTKBenhAn
            // 
            this.mnuTKBenhAn.Name = "mnuTKBenhAn";
            this.mnuTKBenhAn.Size = new System.Drawing.Size(164, 26);
            this.mnuTKBenhAn.Text = "Bệnh Án";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCThongTInBenhAn,
            this.mnuBCThongTinThuoc,
            this.mnuBCDanhSachBenhAn});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(79, 24);
            this.mnuBaoCao.Text = "Báo Cáo";
            // 
            // mnuBCThongTInBenhAn
            // 
            this.mnuBCThongTInBenhAn.Name = "mnuBCThongTInBenhAn";
            this.mnuBCThongTInBenhAn.Size = new System.Drawing.Size(221, 26);
            this.mnuBCThongTInBenhAn.Text = "Thông Tin Bệnh Án";
            this.mnuBCThongTInBenhAn.Click += new System.EventHandler(this.mnuBCThongTInBenhAn_Click);
            // 
            // mnuBCThongTinThuoc
            // 
            this.mnuBCThongTinThuoc.Name = "mnuBCThongTinThuoc";
            this.mnuBCThongTinThuoc.Size = new System.Drawing.Size(221, 26);
            this.mnuBCThongTinThuoc.Text = "Thông Tin Thuốc";
            // 
            // mnuBCDanhSachBenhAn
            // 
            this.mnuBCDanhSachBenhAn.Name = "mnuBCDanhSachBenhAn";
            this.mnuBCDanhSachBenhAn.Size = new System.Drawing.Size(221, 26);
            this.mnuBCDanhSachBenhAn.Text = "Danh Sách Bệnh Án";
            this.mnuBCDanhSachBenhAn.Click += new System.EventHandler(this.mnuBCDanhSachBenhAn_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuFormMain
            // 
            this.mnuFormMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuTraCuuBenhAn,
            this.mnuThongTinBenhAn,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuThoat});
            this.mnuFormMain.Location = new System.Drawing.Point(0, 0);
            this.mnuFormMain.Name = "mnuFormMain";
            this.mnuFormMain.Size = new System.Drawing.Size(975, 28);
            this.mnuFormMain.TabIndex = 0;
            this.mnuFormMain.Text = "Quản Lý Bệnh Nhân";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(975, 613);
            this.Controls.Add(this.mnuFormMain);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.mnuFormMain;
            this.Name = "FormMain";
            this.Text = "Quản Lý Bệnh Nhân";
            this.mnuFormMain.ResumeLayout(false);
            this.mnuFormMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDMBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDMBacSi;
        private System.Windows.Forms.ToolStripMenuItem mnuDMThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuuBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTKBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuTKBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBCThongTInBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuBCThongTinThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuBCDanhSachBenhAn;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.MenuStrip mnuFormMain;
    }
}