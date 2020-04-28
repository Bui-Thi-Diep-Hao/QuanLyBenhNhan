using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using QuanLyBenhNhan;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenhNhan.BaoCao
{
    public partial class BaoCaoBenhAn : Form
    {
        DataTable tblHoSoBenhAn;
        public BaoCaoBenhAn()
        {
            InitializeComponent();
        }

        private void BaoCaoBenhAn_Load(object sender, EventArgs e)
        {

            DAO.connect();
            fillcbo("select  distinct MaBA from HoSoBenhAn", cboMaBenhAn, "MaBA");
            cboMaBenhAn.SelectedIndex = -1;
            loadDataTimKiem();
        }
        private void fillcbo(string SQL, ComboBox cbo, string ma)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(SQL, DAO.Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.DisplayMember = ma;
        }
        private void loadDataTimKiem()
        {
            DAO.connect();
            String SQL = "select MaBA, MaBN,  MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From  HoSoBenhAn  ";
            tblHoSoBenhAn = DAO.LoadDataToTable(SQL);
            dataGridViewTimKiem.DataSource = tblHoSoBenhAn;
            dataGridViewTimKiem.Columns[0].HeaderText = " Mã bệnh án";
            dataGridViewTimKiem.Columns[1].HeaderText = " Mã bệnh nhân";
            dataGridViewTimKiem.Columns[2].HeaderText = " Mã bác sĩ";
            dataGridViewTimKiem.Columns[3].HeaderText = " Ngày khám";
            dataGridViewTimKiem.Columns[4].HeaderText = " Lí do khám";
            dataGridViewTimKiem.Columns[5].HeaderText = " Mã tình trạng";
            dataGridViewTimKiem.Columns[6].HeaderText = " Tiền sử bệnh";
            dataGridViewTimKiem.Columns[7].HeaderText = " Huyết áp";
            dataGridViewTimKiem.Columns[8].HeaderText = " Cân nặng";
            dataGridViewTimKiem.Columns[9].HeaderText = " nhiệt độ";
            dataGridViewTimKiem.Columns[10].HeaderText = " Mã phương án";
            dataGridViewTimKiem.Columns[11].HeaderText = " Tiền khám";
            dataGridViewTimKiem.AllowUserToAddRows = false;
            dataGridViewTimKiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            DAO.connect();

            if (cboMaBenhAn.Text == "")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBenhAn.Focus();
                return;
            }
            string SQL = "select MaBA, HoSoBenhAn.MaBN, MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From HoSoBenhAn Where 1=1";
            if (cboMaBenhAn.Text != "")
                SQL = SQL + " AND HoSoBenhAn.MaBA Like N'%" + cboMaBenhAn.Text + "%'";
            tblHoSoBenhAn = DAO.LoadDataToTable(SQL);
            if (tblHoSoBenhAn.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                MessageBox.Show("Có " + tblHoSoBenhAn.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridViewTimKiem.DataSource = tblHoSoBenhAn;
        }

        private void cboMaBenhAn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
