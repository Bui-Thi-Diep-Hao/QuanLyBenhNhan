using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using QuanLyBenhNhan;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenhNhan.DanhMuc
{
    public partial class DanhMucBenhNhan : Form
    {

        DataTable tboBenhNhan;
        public DanhMucBenhNhan()
        {
            InitializeComponent();
        }

        private void DanhMucBenhNhan_Load(object sender, EventArgs e)
        {
            DAO.connect();
            txtMaBenhNhan.Enabled = false;
            DAO.FillCombo("SELECT MaDT, TenDT FROM DanToc",cboDanToc, "MaDT", "TenDT");
            cboDanToc.SelectedIndex = -1;
            DAO.FillCombo("SELECT MaĐT, TenĐT FROM ĐoiTuong", cboDoiTuong, "MaĐT", "TenĐT");
            cboDoiTuong.SelectedIndex = -1;
            DAO.FillCombo("SELECT MaNN, TenNN FROM NgheNghiep", cboNgheNghiep, "MaNN", "TenNN");
            cboNgheNghiep.SelectedIndex = -1;
            DAO.FillCombo("SELECT MaQ, TenQ FROM Que", cboQueQuan, "MaQ", "TenQ");
            cboQueQuan.SelectedIndex = -1;
            ResetValues();
            LoadDataGripView();
        }
        private void LoadDataGripView()
        {
            DAO.connect();
            //string SQL = " select MaBN, TenBN, GT, NS,TenQ, TenNN, TenDT, TenĐT from BenhNhan join Que on BenhNhan.MaQ= Que.MaQ  join NgheNghiep on BenhNhan.MaNN= NgheNghiep.MaNN  join DanToc on BenhNhan.MaDT= DanToc.MaDT join ĐoiTuong on BenhNhan.MaĐT= ĐoiTuong.MaĐT";
            String SQL = "select* from BenhNhan";
            tboBenhNhan = DAO.LoadDataToTable(SQL);
            dataGridViewDanhSachBenhNhan.DataSource = tboBenhNhan;
            dataGridViewDanhSachBenhNhan.Columns[0].HeaderText = " Mã bệnh nhân";
            dataGridViewDanhSachBenhNhan.Columns[1].HeaderText = " Tên bệnh nhân";
            dataGridViewDanhSachBenhNhan.Columns[2].HeaderText = " Giới tính";
            dataGridViewDanhSachBenhNhan.Columns[3].HeaderText = " Ngày sinh";
            dataGridViewDanhSachBenhNhan.Columns[4].HeaderText = "  Quê Quán";
            dataGridViewDanhSachBenhNhan.Columns[5].HeaderText = " Dân Tộc";
            dataGridViewDanhSachBenhNhan.Columns[6].HeaderText = " Đối Tượng";
            dataGridViewDanhSachBenhNhan.Columns[7].HeaderText = " Nghề Nghiệp";
            dataGridViewDanhSachBenhNhan.AllowUserToAddRows = false;
            dataGridViewDanhSachBenhNhan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

  

        private void bntThem_Click(object sender, EventArgs e)
        {
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
            bntBoQua.Enabled = true;
            bntLuu.Enabled = true;
            bntThem.Enabled = false;
            ResetValues();
            txtMaBenhNhan.Enabled= true;
            txtMaBenhNhan.Focus();
        }
        private void ResetValues()
        {
            txtMaBenhNhan.Text = "";
            txtTenBenhNhan.Text = "";
            mskNgaySinh.Text = "";
            ckbNam.Checked = false;
        }
       

            private void dataGridViewDanhSachBenhNhan_Click(object sender, EventArgs e)
        {
            if( bntThem.Enabled== false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBenhNhan.Focus();
                return;
            }
            if (tboBenhNhan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaBenhNhan.Text = dataGridViewDanhSachBenhNhan.CurrentRow.Cells["MaBN"].Value.ToString();
            txtTenBenhNhan.Text = dataGridViewDanhSachBenhNhan.CurrentRow.Cells["TenBN"].Value.ToString();
            mskNgaySinh.Text = dataGridViewDanhSachBenhNhan.CurrentRow.Cells["NS"].Value.ToString();
            if (dataGridViewDanhSachBenhNhan.CurrentRow.Cells["GT"].Value.ToString() == "Nam")
                ckbNam.Checked = true;
            else
                ckbNam.Checked = false;           
            
            string ma;
            ma = dataGridViewDanhSachBenhNhan.CurrentRow.Cells["MaDT"].Value.ToString();
            cboDanToc.Text = DAO.GetFieldValues("select TenDT from DanToc where MaDT='" + ma + "'");
            ma = dataGridViewDanhSachBenhNhan.CurrentRow.Cells["MaĐT"].Value.ToString();
            cboDoiTuong.Text = DAO.GetFieldValues("select TenĐT from ĐoiTuong where MaĐT='" + ma + "'");
            ma = dataGridViewDanhSachBenhNhan.CurrentRow.Cells["MaQ"].Value.ToString();
            cboQueQuan.Text = DAO.GetFieldValues("select TenQ from Que where MaQ='" + ma + "'");
            ma = dataGridViewDanhSachBenhNhan.CurrentRow.Cells["MaNN"].Value.ToString();
            cboNgheNghiep.Text = DAO.GetFieldValues("select TenNN from NgheNghiep where MaNN='" + ma + "'");
            bntSua.Enabled = true;
            bntXoa.Enabled = true;
            bntBoQua.Enabled = true;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            DAO.connect();
            string SQL;
            if(tboBenhNhan.Rows.Count==0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaBenhNhan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SQL = "delete from BenhNhan where MaBN='" + txtMaBenhNhan.Text + "'";
             
                DAO.RunSqlDel(SQL);
                LoadDataGripView();
                ResetValues();
            }    
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            DAO.connect();
            
            string SQL, gt;
            if (tboBenhNhan.Rows.Count == 0)
            {            
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if( txtMaBenhNhan.Text== "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(txtTenBenhNhan.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập tên bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ckbNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (mskNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return;
            }
            if (!DAO.IsDate(mskNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Text = "";
                mskNgaySinh.Focus();
                return;
            }
            if (cboDanToc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại dân tộc", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDanToc.Focus();
                return;
            }
            if(cboDoiTuong.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập loại đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDoiTuong.Focus();
                return;
            } 
            if(cboNgheNghiep.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập loại nghề nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNgheNghiep.Focus();
                return;
            } 
            if(cboQueQuan.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQueQuan.Focus();
                return;
            } 
           
            SQL= "update BenhNhan set TenBN='"+ txtTenBenhNhan.Text.Trim().ToString() +"',NS='"+DAO.ConvertDateTime(mskNgaySinh.Text)+ "',GT='"+gt+ "',MaDT='"+ cboDanToc.SelectedValue.ToString()+ "',MaĐT='"+ cboDoiTuong.SelectedValue.ToString()+"',MaQ='" +cboQueQuan.SelectedValue.ToString() + "',MaNN='"+cboNgheNghiep.SelectedValue.ToString()+"' WHERE MaBN='" + txtMaBenhNhan.Text + "'";
            
 
            DAO.RunSql(SQL);
            DAO.LoadDataToTable(SQL);
            LoadDataGripView();
            ResetValues();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            DAO.connect();
            
            string SQL,gt;
            if (tboBenhNhan.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBenhNhan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenBenhNhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ckbNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (mskNgaySinh.Text == "  /  /   ")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return;
            }
            if (!DAO.IsDate(mskNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Text = "";
                mskNgaySinh.Focus();
                return;
            }
            if (cboDanToc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDanToc.Focus();
                return;
            }
            if (cboDoiTuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDoiTuong.Focus();
                return;
            }
            if (cboNgheNghiep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại nghề nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNgheNghiep.Focus();
                return;
            }
            if (cboQueQuan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboQueQuan.Focus();
                return;
            }
            SQL= "SELECT MaBN FROM BenhNhan WHERE MaBN=N'" +txtMaBenhNhan.Text.Trim() + "'";
            if (DAO.CheckKey(SQL))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               txtMaBenhNhan.Focus();
                txtMaBenhNhan.Text = "";
                return;
            }
            SQL = "insert into BenhNhan(MaBN, TenBN,NS,GT,MaDT, MaĐT, MaQ, MaNN) values (N'" + txtMaBenhNhan.Text.Trim() + "',N'" + txtTenBenhNhan.Text.Trim() + "',N'"
            + DAO.ConvertDateTime(mskNgaySinh.Text) + "',N'" + gt + "',N'" + cboDanToc.SelectedValue.ToString() + "',N'" + cboDoiTuong.SelectedValue.ToString() + "',N'" + cboQueQuan.SelectedValue.ToString() + "',N'" + cboNgheNghiep.SelectedValue.ToString() + "')";
     
            DAO.LoadDataToTable(SQL);
            DAO.RunSql(SQL);
            LoadDataGripView();
            ResetValues();
            bntXoa.Enabled = true;
            bntThem.Enabled = true;
            bntSua.Enabled = true;
            bntBoQua.Enabled = false;
            bntLuu.Enabled = false;
            txtMaBenhNhan.Enabled = false;
        }

        private void bntBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntBoQua.Enabled = false;
            bntThem.Enabled = true;
            bntXoa.Enabled = true;
            bntSua.Enabled = true;
            bntLuu.Enabled = false;
            txtMaBenhNhan.Enabled = false;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose();
            } 
        }

        private void txtMaBenhNhan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
