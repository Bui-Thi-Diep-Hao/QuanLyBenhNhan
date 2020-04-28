using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using QuanLyBenhNhan.DanhMuc;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyBenhNhan.BaoCao;

namespace QuanLyBenhNhan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuDMBenhNhan_Click(object sender, EventArgs e)
        {
            DanhMucBenhNhan FormDMBN = new DanhMucBenhNhan();
            FormDMBN.ShowDialog();
        }

        private void mnuDMBacSi_Click(object sender, EventArgs e)
        {
            DanhMucBacSi formDMBS = new DanhMucBacSi();
            formDMBS.ShowDialog();
        }

        private void mnuTraCuuBenhAn_Click(object sender, EventArgs e)
        {
            TraCuuBenhAn formMain = new TraCuuBenhAn();
            formMain.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuBCThongTInBenhAn_Click(object sender, EventArgs e)
        {
            BaoCaoBenhAnTheoBS formBaoCao = new BaoCaoBenhAnTheoBS();
            formBaoCao.ShowDialog();
        }

        private void mnuBCDanhSachBenhAn_Click(object sender, EventArgs e)
        {
            BaoCaoBenhAn formBA = new BaoCaoBenhAn();
            formBA.ShowDialog();
        }
    }
}
