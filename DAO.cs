using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace QuanLyBenhNhan
{
    class DAO
    {
        public static SqlConnection Con;
        public static string connectionstring;


        public static void connect()
        {
             connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuanLyBenhNhan;Integrated Security=True";
            Con = new SqlConnection();
            Con.ConnectionString = connectionstring;
            Con.Open();

        }
        public static void disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }
        public static DataTable LoadDataToTable(string SQL)
        {

            SqlDataAdapter Mydata = new SqlDataAdapter(SQL, Con);
            Mydata.SelectCommand = new SqlCommand(SQL, Con);
            Mydata.SelectCommand.Connection = DAO.Con;
            Mydata.SelectCommand.CommandText = SQL;
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;
           

        }
        public static void FillCombo(string SQL, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(SQL, DAO.Con);
            DataTable table = new DataTable();
            
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static void RunSqlDel(string SQL)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DAO.Con;
            cmd.CommandText = SQL;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, bạn không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;


        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static void RunSql(string SQL)
        {
            SqlCommand cmd;		              
            cmd = new SqlCommand();	         
            cmd.Connection = DAO.Con;	
            cmd.CommandText = SQL;			
            try
            {
                cmd.ExecuteNonQuery();		 
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool CheckKey(string SQL)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(SQL, DAO.Con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static string GetFieldValues(string SQL)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(SQL, DAO.Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
 

    }
}
