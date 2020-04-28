using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using QuanLyBenhNhan;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenhNhan.BaoCao
{ 
    public partial class BaoCaoBenhAnTheoBS : Form
    {
        DataTable tblBenhAnTheoBS;
        public BaoCaoBenhAnTheoBS()
        {
            InitializeComponent();
        }

        private void BaoCaoBenhAnTheoBS_Load(object sender, EventArgs e)
        {
            DAO.connect();
            fillcbo("select  distinct MaBS from HoSoBenhAn", cboMaBacSi, "MaBS");
            cboMaBacSi.SelectedIndex = -1;
            loadDataTimKiemBA();
        }
        private void fillcbo(string SQL, ComboBox cbo, string ma)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(SQL, DAO.Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.DisplayMember = ma;
        }
        private void loadDataTimKiemBA()
        {
            DAO.connect();
            String SQL = "select MaBA, MaBN,  HoSoBenhAn.MaBS,TenBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From BacSi join HoSoBenhAn on HoSoBenhAn.MaBS= BacSi.MaBS ";
            tblBenhAnTheoBS = DAO.LoadDataToTable(SQL);
            dataGridViewBenhAnTheoBS.DataSource = tblBenhAnTheoBS;
            dataGridViewBenhAnTheoBS.Columns[0].HeaderText = " Mã bệnh án";
            dataGridViewBenhAnTheoBS.Columns[1].HeaderText = " Mã bệnh nhân";
            dataGridViewBenhAnTheoBS.Columns[2].HeaderText = " Mã bác sĩ";
            dataGridViewBenhAnTheoBS.Columns[3].HeaderText = " Tên bác sĩ";
            dataGridViewBenhAnTheoBS.Columns[4].HeaderText = " Ngày khám";
            dataGridViewBenhAnTheoBS.Columns[5].HeaderText = " Lí do khám";
            dataGridViewBenhAnTheoBS.Columns[6].HeaderText = " Mã tình trạng";
            dataGridViewBenhAnTheoBS.Columns[7].HeaderText = " Tiền sử bệnh";
            dataGridViewBenhAnTheoBS.Columns[8].HeaderText = " Huyết áp";
            dataGridViewBenhAnTheoBS.Columns[9].HeaderText = " Cân nặng";
            dataGridViewBenhAnTheoBS.Columns[10].HeaderText = " nhiệt độ";
            dataGridViewBenhAnTheoBS.Columns[11].HeaderText = " Mã phương án";
            dataGridViewBenhAnTheoBS.Columns[12].HeaderText = " Tiền khám";
            dataGridViewBenhAnTheoBS.AllowUserToAddRows = false;
            dataGridViewBenhAnTheoBS.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            DAO.connect();

            if (cboMaBacSi.Text == "")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBacSi.Focus();
                return;
            }
            string SQL = "select MaBA, MaBN, HoSoBenhAn.MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From BacSi join  HoSoBenhAn on HoSoBenhAn.MaBS= BacSi.MaBS  Where 1=1";
            if (cboMaBacSi.Text != "")
                SQL = SQL + " AND HoSoBenhAn.MaBS Like N'%" + cboMaBacSi.Text + "%'";
            tblBenhAnTheoBS = DAO.LoadDataToTable(SQL);
            if (tblBenhAnTheoBS.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                MessageBox.Show("Có " + tblBenhAnTheoBS.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridViewBenhAnTheoBS.DataSource = tblBenhAnTheoBS;
        }

        private void cboMaBacSi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void bntInBaoCao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
