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

namespace QuanLyBenhNhan
{
    public partial class TraCuuBenhAn : Form
    {
        public TraCuuBenhAn()
        {
            InitializeComponent();
        }
        DataTable tblHSBA;
        private void TraCuuBenhAn_Load(object sender, EventArgs e)
        {
            DAO.connect();
            fillcbo("select  distinct MaBN from HoSoBenhAn", cboMaBenhNhan, "MaBN");
            cboMaBenhNhan.SelectedIndex = -1;
            loadDataTraCuu();
            
        }
        private void loadDataTraCuu()
        {
            DAO.connect();
            String SQL = "select MaBA, HoSoBenhAn.MaBN, TenBN, MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From BenhNhan join HoSoBenhAn on HoSoBenhAn.MaBN= BenhNhan.MaBN ";
            tblHSBA = DAO.LoadDataToTable(SQL);
            dataGridViewTraCuu.DataSource = tblHSBA;
            dataGridViewTraCuu.Columns[0].HeaderText = " Mã bệnh án";
            dataGridViewTraCuu.Columns[1].HeaderText = " Mã bệnh nhân";
            dataGridViewTraCuu.Columns[2].HeaderText = " Tên bệnh nhân";
            dataGridViewTraCuu.Columns[3].HeaderText = " Mã bác sĩ";
            dataGridViewTraCuu.Columns[4].HeaderText = " Ngày khám";
            dataGridViewTraCuu.Columns[5].HeaderText = " Lí do khám";
            dataGridViewTraCuu.Columns[6].HeaderText = " Mã tình trạng";
            dataGridViewTraCuu.Columns[7].HeaderText = " Tiền sử bệnh";
            dataGridViewTraCuu.Columns[8].HeaderText = " Huyết áp";
            dataGridViewTraCuu.Columns[9].HeaderText = " Cân nặng";
            dataGridViewTraCuu.Columns[10].HeaderText = " nhiệt độ";
            dataGridViewTraCuu.Columns[11].HeaderText = " Mã phương án";
            dataGridViewTraCuu.Columns[12].HeaderText = " Tiền khám";
            dataGridViewTraCuu.AllowUserToAddRows = false;
            dataGridViewTraCuu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void fillcbo(string SQL, ComboBox cbo, string ma)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(SQL, DAO.Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.DisplayMember = ma;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void bntTimKIem_Click(object sender, EventArgs e)
        {
            DAO.connect();
           
            if(cboMaBenhNhan.Text=="")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBenhNhan.Focus();
                return;
            }
            string SQL = "select MaBA, HoSoBenhAn.MaBN, TenBN, MaBS, NgayKham, LiDoKham, MaTT, TienSuBenh, HuyetAp, CanNang, NhietDo, MaPA, TienKham From BenhNhan join HoSoBenhAn on HoSoBenhAn.MaBN= BenhNhan.MaBN Where 1=1";
            if(cboMaBenhNhan.Text!= "")
                SQL = SQL + " AND HoSoBenhAn.MaBN Like N'%" + cboMaBenhNhan.Text + "%'";
            tblHSBA = DAO.LoadDataToTable(SQL);
            if (tblHSBA.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                MessageBox.Show("Có " + tblHSBA.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridViewTraCuu.DataSource = tblHSBA;
            
        }

        private void cboMaBenhNhan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void bntHienThi_Click(object sender, EventArgs e)
        {
            loadDataTraCuu();
        }
    }
}
