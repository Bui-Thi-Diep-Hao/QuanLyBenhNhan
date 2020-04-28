using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using QuanLyBenhNhan;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenhNhan.DanhMuc
{
    public partial class DanhMucBacSi : Form
    {
        DataTable tblBacSi;
        public DanhMucBacSi()
        {
            InitializeComponent();
        }

        private void DanhMucBacSi_Load(object sender, EventArgs e)
        {
            DAO.connect();
            txtMaBacSi.Enabled = false;
            DAO.FillCombo("SELECT MaQ, TenQ FROM Que", cboQueQuan, "MaQ", "TenQ");
            cboQueQuan.SelectedIndex = -1;
            DAO.FillCombo("SELECT MaCM, TenCM FROM ChuyenMon", cboChuyenMon, "MaCM", "TenCM");
            cboChuyenMon.SelectedIndex = -1;
            DAO.FillCombo("SELECT MaTĐ, TenTĐ FROM TrinhĐo", cboTrinhDo, "MaTĐ", "TenTĐ");
            cboTrinhDo.SelectedIndex = -1;
            ResetValues();
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtMaBacSi.Text = "";
            txtTenBacSi.Text = "";
            mskNgSinhBS.Text = "";
            txtSDT.Text = "";
            ckbGioiTinh.Checked = false;
        }
        private void LoadDataGridView()
        {
            DAO.connect();
            
            String SQL = "select * from BacSi ";
            tblBacSi = DAO.LoadDataToTable(SQL);
            dataGridViewBacSi.DataSource = tblBacSi;
            dataGridViewBacSi.Columns[0].HeaderText = "Mã bác sĩ";
            dataGridViewBacSi.Columns[1].HeaderText = "Tên bác sĩ";
            dataGridViewBacSi.Columns[2].HeaderText = "Ngày sinh";
            dataGridViewBacSi.Columns[3].HeaderText = "Giới tính";
            dataGridViewBacSi.Columns[4].HeaderText = "Quê quán";
            dataGridViewBacSi.Columns[5].HeaderText = "Chuyên môn";
            dataGridViewBacSi.Columns[6].HeaderText = "Trình độ";
            dataGridViewBacSi.Columns[7].HeaderText = "Số điện thoại";
            dataGridViewBacSi.AllowUserToAddRows = false;
            dataGridViewBacSi.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntBoQua.Enabled = true;
            bntLuu.Enabled = true;
            bntThem.Enabled = false;
            ResetValues();
            txtMaBacSi.Enabled = true;
            txtMaBacSi.Focus();
        }

        private void dataGridViewBacSi_Click(object sender, EventArgs e)
        {
            string ma;
            if (bntThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBacSi.Focus();
                return;
            }
            if (tblBacSi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaBacSi.Text = dataGridViewBacSi.CurrentRow.Cells["MaBS"].Value.ToString();
            txtTenBacSi.Text = dataGridViewBacSi.CurrentRow.Cells["TenBS"].Value.ToString();
            mskNgSinhBS.Text = dataGridViewBacSi.CurrentRow.Cells["NS"].Value.ToString();
            if (dataGridViewBacSi.CurrentRow.Cells["GT"].Value.ToString() == "Nam")
                ckbGioiTinh.Checked = true;
            else
                ckbGioiTinh.Checked = false;
            txtSDT.Text = dataGridViewBacSi.CurrentRow.Cells["SĐT"].Value.ToString();
     
            ma = dataGridViewBacSi.CurrentRow.Cells["MaQ"].Value.ToString();
            cboQueQuan.Text = DAO.GetFieldValues("select TenQ from Que where MaQ='" + ma + "'");
            ma = dataGridViewBacSi.CurrentRow.Cells["MaCM"].Value.ToString();
            cboChuyenMon.Text = DAO.GetFieldValues("select TenCM from ChuyenMon where MaCM='" + ma + "'");
            ma = dataGridViewBacSi.CurrentRow.Cells["MaTĐ"].Value.ToString();
            cboTrinhDo.Text = DAO.GetFieldValues("select TenTĐ from TrinhĐo where MaTĐ='" + ma + "'");
            bntSua.Enabled = true;       
            bntXoa.Enabled = true;
            bntBoQua.Enabled = true;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            DAO.connect();
            string SQL;
            if (tblBacSi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBacSi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SQL = "delete from BacSi where MaBS='" + txtMaBacSi.Text + "'";
                
                DAO.RunSqlDel(SQL);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            DAO.connect();
            string SQL, gt;
            if (tblBacSi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBacSi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenBacSi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ckbGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (mskNgSinhBS.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgSinhBS.Focus();
                return;
            }
            if (!DAO.IsDate(mskNgSinhBS.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgSinhBS.Text = "";
                mskNgSinhBS.Focus();
                return;
            }
            if (cboChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChuyenMon.Focus();
                return;
            }
            if (cboTrinhDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập trình độ bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrinhDo.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (cboQueQuan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQueQuan.Focus();
                return;
            }
            SQL= "update BacSi set TenBS='" + txtTenBacSi.Text.Trim().ToString() + "',NS='" + DAO.ConvertDateTime(mskNgSinhBS.Text) + "',GT='" + gt + "',MaCM='" + cboChuyenMon.SelectedValue.ToString() + "',MaTĐ='" + cboTrinhDo.SelectedValue.ToString() + "',MaQ='" + cboQueQuan.SelectedValue.ToString() + "',SĐT='" +txtSDT.Text.ToString() + "' WHERE MaBS='" + txtMaBacSi.Text + "'";
   
            DAO.RunSql(SQL);
            DAO.LoadDataToTable(SQL);
            LoadDataGridView();
            ResetValues();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            DAO.connect();
            string SQL, gt;
            if (tblBacSi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBacSi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenBacSi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ckbGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (mskNgSinhBS.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgSinhBS.Focus();
                return;
            }
            if (!DAO.IsDate(mskNgSinhBS.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgSinhBS.Text = "";
                mskNgSinhBS.Focus();
                return;
            }
            if (cboChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChuyenMon.Focus();
                return;
            }
            if (cboTrinhDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập trình độ bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrinhDo.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (cboQueQuan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQueQuan.Focus();
                return;
            }
            SQL = "insert into BacSi(MaBS, TenBS, NS, GT,MaQ, MaCM, MaTĐ, SĐT) values (N'" + txtMaBacSi.Text.Trim() + "',N'" + txtTenBacSi.Text.Trim() + "',N'"
            + DAO.ConvertDateTime(mskNgSinhBS.Text) + "',N'" + gt + "',N'" + cboQueQuan.SelectedValue.ToString() +"',N'"+ cboChuyenMon.SelectedValue.ToString() + "',N'" + cboTrinhDo.SelectedValue.ToString() + "',N'"  + txtSDT.Text.ToString() + "')"; 
            DAO.LoadDataToTable(SQL);
            DAO.RunSql(SQL);
            LoadDataGridView();
            ResetValues();
            bntXoa.Enabled = true;
            bntThem.Enabled = true;
            bntSua.Enabled = true;
            bntBoQua.Enabled = false;
            bntLuu.Enabled = false;
            txtMaBacSi.Enabled = false;
        }

        private void bntBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntBoQua.Enabled = false;
            bntThem.Enabled = true;
            bntXoa.Enabled = true;
            bntSua.Enabled = true;
            bntLuu.Enabled = false;
            txtMaBacSi.Enabled = false;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose();
            }    
        }

        private void txtMaBacSi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
