namespace QuanLyBenhNhan
{
    partial class TraCuuBenhAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaBenhNhan = new System.Windows.Forms.ComboBox();
            this.bntTimKIem = new System.Windows.Forms.Button();
            this.dataGridViewTraCuu = new System.Windows.Forms.DataGridView();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiDoKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienSuBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuyetAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhietDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntHienThi = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Bệnh Án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // cboMaBenhNhan
            // 
            this.cboMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaBenhNhan.FormattingEnabled = true;
            this.cboMaBenhNhan.Location = new System.Drawing.Point(136, 29);
            this.cboMaBenhNhan.Name = "cboMaBenhNhan";
            this.cboMaBenhNhan.Size = new System.Drawing.Size(121, 28);
            this.cboMaBenhNhan.TabIndex = 2;
            this.cboMaBenhNhan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMaBenhNhan_KeyUp);
            // 
            // bntTimKIem
            // 
            this.bntTimKIem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKIem.Location = new System.Drawing.Point(282, 25);
            this.bntTimKIem.Name = "bntTimKIem";
            this.bntTimKIem.Size = new System.Drawing.Size(99, 34);
            this.bntTimKIem.TabIndex = 3;
            this.bntTimKIem.Text = "Tìm Kiếm";
            this.bntTimKIem.UseVisualStyleBackColor = true;
            this.bntTimKIem.Click += new System.EventHandler(this.bntTimKIem_Click);
            // 
            // dataGridViewTraCuu
            // 
            this.dataGridViewTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBA,
            this.MaBN,
            this.TenBN,
            this.MaBS,
            this.NgayKham,
            this.LiDoKham,
            this.MaTT,
            this.TienSuBenh,
            this.HuyetAp,
            this.CanNang,
            this.NhietDo,
            this.MaPA,
            this.TienKham});
            this.dataGridViewTraCuu.Location = new System.Drawing.Point(122, 351);
            this.dataGridViewTraCuu.Name = "dataGridViewTraCuu";
            this.dataGridViewTraCuu.RowHeadersWidth = 51;
            this.dataGridViewTraCuu.RowTemplate.Height = 24;
            this.dataGridViewTraCuu.Size = new System.Drawing.Size(870, 287);
            this.dataGridViewTraCuu.TabIndex = 4;
            // 
            // MaBA
            // 
            this.MaBA.DataPropertyName = "MaBA";
            this.MaBA.HeaderText = "Mã Bệnh Án";
            this.MaBA.MinimumWidth = 6;
            this.MaBA.Name = "MaBA";
            this.MaBA.Width = 49;
            // 
            // MaBN
            // 
            this.MaBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã Bệnh Nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            // 
            // TenBN
            // 
            this.TenBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenBN.DataPropertyName = "TenBN";
            this.TenBN.HeaderText = "Tên Bệnh Nhân";
            this.TenBN.MinimumWidth = 6;
            this.TenBN.Name = "TenBN";
            // 
            // MaBS
            // 
            this.MaBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBS.DataPropertyName = "MaBS";
            this.MaBS.HeaderText = "Mã Bác Sĩ";
            this.MaBS.MinimumWidth = 6;
            this.MaBS.Name = "MaBS";
            // 
            // NgayKham
            // 
            this.NgayKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "Ngày Khám";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            // 
            // LiDoKham
            // 
            this.LiDoKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LiDoKham.DataPropertyName = "LiDoKham";
            this.LiDoKham.HeaderText = "Lí Do Khám";
            this.LiDoKham.MinimumWidth = 6;
            this.LiDoKham.Name = "LiDoKham";
            // 
            // MaTT
            // 
            this.MaTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTT.DataPropertyName = "MaTT";
            this.MaTT.HeaderText = "Mã Tình Trạng";
            this.MaTT.MinimumWidth = 6;
            this.MaTT.Name = "MaTT";
            // 
            // TienSuBenh
            // 
            this.TienSuBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienSuBenh.DataPropertyName = "TienSuBenh";
            this.TienSuBenh.HeaderText = "Tiền Sử Bệnh";
            this.TienSuBenh.MinimumWidth = 6;
            this.TienSuBenh.Name = "TienSuBenh";
            // 
            // HuyetAp
            // 
            this.HuyetAp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HuyetAp.DataPropertyName = "HuyetAp";
            this.HuyetAp.HeaderText = "Huyết Áp";
            this.HuyetAp.MinimumWidth = 6;
            this.HuyetAp.Name = "HuyetAp";
            // 
            // CanNang
            // 
            this.CanNang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CanNang.DataPropertyName = "CanNang";
            this.CanNang.HeaderText = "Cân Nặng";
            this.CanNang.MinimumWidth = 6;
            this.CanNang.Name = "CanNang";
            // 
            // NhietDo
            // 
            this.NhietDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhietDo.DataPropertyName = "NhietDo";
            this.NhietDo.HeaderText = "Nhiệt Độ";
            this.NhietDo.MinimumWidth = 6;
            this.NhietDo.Name = "NhietDo";
            // 
            // MaPA
            // 
            this.MaPA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPA.DataPropertyName = "MaPA";
            this.MaPA.HeaderText = "Mã Phương Án";
            this.MaPA.MinimumWidth = 6;
            this.MaPA.Name = "MaPA";
            // 
            // TienKham
            // 
            this.TienKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienKham.DataPropertyName = "TienKham";
            this.TienKham.HeaderText = "Tiền Khám";
            this.TienKham.MinimumWidth = 6;
            this.TienKham.Name = "TienKham";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cboMaBenhNhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bntTimKIem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(128, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách bệnh án của bệnh nhân";
            // 
            // bntHienThi
            // 
            this.bntHienThi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntHienThi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHienThi.Location = new System.Drawing.Point(131, 253);
            this.bntHienThi.Name = "bntHienThi";
            this.bntHienThi.Size = new System.Drawing.Size(144, 34);
            this.bntHienThi.TabIndex = 36;
            this.bntHienThi.Text = "Hiển thị lại tất cả";
            this.bntHienThi.UseVisualStyleBackColor = false;
            this.bntHienThi.Click += new System.EventHandler(this.bntHienThi_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bntThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntThoat.Location = new System.Drawing.Point(806, 168);
            this.bntThoat.Margin = new System.Windows.Forms.Padding(4);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(106, 42);
            this.bntThoat.TabIndex = 35;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // TraCuuBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 650);
            this.Controls.Add(this.bntHienThi);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTraCuu);
            this.Controls.Add(this.label1);
            this.Name = "TraCuuBenhAn";
            this.Text = "Tra Cứu Bệnh Án";
            this.Load += new System.EventHandler(this.TraCuuBenhAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaBenhNhan;
        private System.Windows.Forms.Button bntTimKIem;
        private System.Windows.Forms.DataGridView dataGridViewTraCuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDoKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienSuBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HuyetAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhietDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKham;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntHienThi;
    }
}