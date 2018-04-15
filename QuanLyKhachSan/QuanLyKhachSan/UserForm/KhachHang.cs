using QuanLyKhachSan.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserForm
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        public void laydata()
        {
            
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT MA_KH N'Mã khách hàng',HOTEN N'Họ và tên',IIF(GIOITINH=1,N'Nam',N'Nữ') N'Giới tính',DIACHI N'Địa chỉ',SDT ,CMT,EMAIL FROM dbo.KHACHHANG";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter con = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            con.Fill(data);
            tb_kh.DataSource = data;
            

            kn.Close();

        }

        public void ThemKhachHang(string mkh,string hoten,string gt,string cmt,string diachi,string sdt,string email)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try

            {
                string sql = "INSERT dbo.KHACHHANG (  , HOTEN ,GIOITINH ,CMT ,DIACHI , SDT , EMAIL )VALUES  ( '" + mkh + "' , N'" + hoten + "' ,  " + gt + " , '" + cmt + "' ,  N'" + diachi + "' , '" + sdt + "' ,  '" + email + "'  )";
                SqlCommand command = new SqlCommand(sql, kn);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công");
            }
            catch
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }


            kn.Close();
            laydata();
        }
        public void SuaKhachHang(string mkh, string hoten, string gt, string cmt, string diachi, string sdt, string email)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try

            {
                string sql = "UPDATE dbo.KHACHHANG SET HOTEN=N'"+hoten+"',GIOITINH="+gt+",CMT='"+cmt+"',DIACHI=N'"+diachi+"',SDT='"+sdt+"', EMAIL='"+email+"' WHERE MA_KH='"+mkh+"'";
                SqlCommand command = new SqlCommand(sql, kn);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa khách hàng thành công");
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi mời thử lại");
            }
            

            kn.Close();
            laydata();
        }

        public void TimKiemTheoMa(string ma)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT MA_KH N'Mã khách hàng',HOTEN N'Họ và tên',IIF(GIOITINH=1,N'Nam',N'Nữ') N'Giới tính',DIACHI N'Địa chỉ',SDT ,CMT,EMAIL FROM dbo.KHACHHANG WHERE  MA_KH='"+ma+"'";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter con = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            con.Fill(data);
            tb_kh.DataSource = data;


            kn.Close();
        }
        public void TimKiemTheoTen(string hoten)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT MA_KH N'Mã khách hàng',HOTEN N'Họ và tên',IIF(GIOITINH=1,N'Nam',N'Nữ') N'Giới tính',DIACHI N'Địa chỉ',SDT ,CMT,EMAIL FROM dbo.KHACHHANG WHERE HOTEN ='"+hoten  +"'";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter con = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            con.Fill(data);
            tb_kh.DataSource = data;


            kn.Close();
        }
        public void TimKiemTheoSDT(string sdt)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT MA_KH N'Mã khách hàng',HOTEN N'Họ và tên',IIF(GIOITINH=1,N'Nam',N'Nữ') N'Giới tính',DIACHI N'Địa chỉ',SDT ,CMT,EMAIL FROM dbo.KHACHHANG WHERE SDT='"+sdt+"'";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter con = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            con.Fill(data);
            tb_kh.DataSource = data;


            kn.Close();
        }
        public void TimKiemTheoCMT(string cmt)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT MA_KH N'Mã khách hàng',HOTEN N'Họ và tên',IIF(GIOITINH=1,N'Nam',N'Nữ') N'Giới tính',DIACHI N'Địa chỉ',SDT ,CMT,EMAIL FROM dbo.KHACHHANG  WHERE CMT='"+cmt+"'";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter con = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            con.Fill(data);
            tb_kh.DataSource = data;


            kn.Close();
        }

        private void KhachHang_Load_1(object sender, EventArgs e)
        {
           
            laydata();
        }

        private void tb_kh_MouseClick(object sender, MouseEventArgs e)
        {
            int index = tb_kh.CurrentRow.Index;
            txt_mkh.Text= tb_kh.Rows[index].Cells[0].Value.ToString();
            txt_ten.Text=tb_kh.Rows[index].Cells[1].Value.ToString();
            txt_diachi.Text= tb_kh.Rows[index].Cells[3].Value.ToString();
            txt_sdt.Text= tb_kh.Rows[index].Cells[4].Value.ToString();
            txt_cmt.Text= tb_kh.Rows[index].Cells[5].Value.ToString();
            txt_email.Text= tb_kh.Rows[index].Cells[6].Value.ToString();
            if (tb_kh.Rows[index].Cells[2].Value.ToString() == "Nam")
                rd_nam.Checked = true;
            else rd_nu.Checked = true;

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string mkh = txt_mkh.Text;
            string hoten = txt_ten.Text;
            string gt="-1";
            if (rd_nam.Checked == true)  gt = "1";
            if (rd_nu.Checked == true)  gt = "0";
            string cmt = txt_cmt.Text;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string email = txt_email.Text;
            if (mkh == "" || hoten == "" || gt == "-1" || cmt == "" || diachi == "" || sdt == "" || email == "")
                MessageBox.Show("Phải điền đầy đủ thông tin");
            else
               
            ThemKhachHang(mkh, hoten, gt, cmt, diachi, sdt, email);

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string mkh = txt_mkh.Text;
            string hoten = txt_ten.Text;
            string gt = "-1";
            if (rd_nam.Checked == true) gt = "1";
            if (rd_nu.Checked == true) gt = "0";
            string cmt = txt_cmt.Text;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string email = txt_email.Text;
            if (mkh == "" || hoten == "" || gt == "-1" || cmt == "" || diachi == "" || sdt == "" || email == "")
                MessageBox.Show("Phải điền đầy đủ thông tin");
            else

                SuaKhachHang(mkh, hoten, gt, cmt, diachi, sdt, email);

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rd_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            string mkh = txt_mkh.Text;
            string hoten = txt_ten.Text;
            
            string cmt = txt_cmt.Text;
            
            string sdt = txt_sdt.Text;
            if (mkh == "")
                if (hoten == "")
                    if (cmt == "")
                        if (sdt == "") MessageBox.Show("Mời nhập thông tin để tìm kiếm");
                        else TimKiemTheoSDT(sdt);
                    else TimKiemTheoCMT(cmt);
                else TimKiemTheoTen(hoten);
            else TimKiemTheoMa(mkh);

        }
    }
}
