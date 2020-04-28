namespace QuanLyBenhNhan.BaoCao
{
    partial class BaoCaoBenhAn
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
            this.cboMaBenhAn = new System.Windows.Forms.ComboBox();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.MaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bntInBaoCao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo Cáo Bệnh Án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bệnh án";
            // 
            // cboMaBenhAn
            // 
            this.cboMaBenhAn.FormattingEnabled = true;
            this.cboMaBenhAn.Location = new System.Drawing.Point(457, 157);
            this.cboMaBenhAn.Name = "cboMaBenhAn";
            this.cboMaBenhAn.Size = new System.Drawing.Size(111, 24);
            this.cboMaBenhAn.TabIndex = 3;
            this.cboMaBenhAn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMaBenhAn_KeyUp);
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimKiem.Location = new System.Drawing.Point(316, 214);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(113, 39);
            this.bntTimKiem.TabIndex = 4;
            this.bntTimKiem.Text = "Tìm kiếm";
            this.bntTimKiem.UseVisualStyleBackColor = true;
            this.bntTimKiem.Click += new System.EventHandler(this.bntTimKiem_Click);
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBA,
            this.MaBN,
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
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(88, 311);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.RowHeadersWidth = 51;
            this.dataGridViewTimKiem.RowTemplate.Height = 24;
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(870, 287);
            this.dataGridViewTimKiem.TabIndex = 5;
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
            // bntInBaoCao
            // 
            this.bntInBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInBaoCao.Location = new System.Drawing.Point(477, 214);
            this.bntInBaoCao.Name = "bntInBaoCao";
            this.bntInBaoCao.Size = new System.Drawing.Size(113, 39);
            this.bntInBaoCao.TabIndex = 10;
            this.bntInBaoCao.Text = "In báo cáo";
            this.bntInBaoCao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(131, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hiển thị thông tin của bệnh án";
            // 
            // BaoCaoBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 712);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntInBaoCao);
            this.Controls.Add(this.dataGridViewTimKiem);
            this.Controls.Add(this.bntTimKiem);
            this.Controls.Add(this.cboMaBenhAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoBenhAn";
            this.Text = "BaoCaoBenhAn";
            this.Load += new System.EventHandler(this.BaoCaoBenhAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaBenhAn;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
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
        private System.Windows.Forms.Button bntInBaoCao;
        private System.Windows.Forms.Label label3;
    }
}