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
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }
       
        public void ketnoi()
        {

            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
           
            kn.Open();
            string sql = "SELECT nv.MA_NV AS N'Mã Nhân Viên', HOTEN AS N'Tên Nhân Viên' ,IIF(GIOITINH=1,N'Nam',N'Nữ') N'Giới tính',DIACHI AS N'Địa Chỉ', NGAYSINH AS N'Ngày Sinh',SDT AS N'SDT', CHUCVU AS N'Chức Vụ' FROM dbo.nhanvien nv";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            tablenhanvien.DataSource = data;
            kn.Close();
        }
        public void themNV(string manv,string tennv,string gt,string diachi,string sdt,string ngaysinh,string chucvu)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try
            {
                string sql = "INSERT dbo.NHANVIEN( MA_NV , HOTEN ,NGAYSINH ,GIOITINH ,DIACHI ,SDT ,CHUCVU)VALUES  ( '" + manv + "' , N'" + tennv + "' , '" + ngaysinh + "' , " + gt + " , N'" + diachi + "' ,'" + sdt + "' ,   N'" + chucvu + "'   )";
                

                SqlCommand commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                kn.Close();
            }
            catch
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            ketnoi();
        }
        public void SuaNV(string manv,string tennv,string gt,string diachi,string sdt,string ngaysinh,string chucvu)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try
            {
                string sql = "UPDATE dbo.NHANVIEN SET HOTEN=N'"+manv+"',NGAYSINH='"+ngaysinh+"',GIOITINH="+gt+",DIACHI=N'"+diachi+"',sdt='"+sdt+"',CHUCVU=N'"+chucvu+"' WHERE MA_NV='"+manv+"'";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                kn.Close();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi mời kiểm tra lại thông tin");
            }
            ketnoi();
        }
        public void XoaNV(string mnv)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try
            {
                string sql = "DELETE dbo.NHANVIEN WHERE MA_NV='"+mnv+"'";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                kn.Close();
            }
            catch
            {
                MessageBox.Show("Nhân viên không tồn tại");
            }
        }
        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void tablenhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            
            

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string mnv = txt_manv.Text;
            string tennv = txt_ten.Text;
            string gt = "-1";
            if (rd_nam.Checked == true) gt = "1";
            if (rd_nu.Checked == true) gt = "0";
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string ngaysinh = txt_ngaysinh.Text;
            string chucvu = txt_chucvu.Text;

            if (mnv == "" || tennv == "" || gt == "-1" || diachi == "" || sdt == "" || ngaysinh == "" || chucvu == "") MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
            else themNV(mnv, tennv, gt, diachi, sdt, ngaysinh, chucvu);


        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string mnv = txt_manv.Text;
            string tennv = txt_ten.Text;
            string gt = "-1";
            if (rd_nam.Checked == true) gt = "1";
            if (rd_nu.Checked == true) gt = "0";
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string ngaysinh = txt_ngaysinh.Text;
            string chucvu = txt_chucvu.Text;

            if (mnv == "" || tennv == "" || gt == "-1" || diachi == "" || sdt == "" || ngaysinh == "" || chucvu == "") MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
            else SuaNV(mnv, tennv, gt, diachi, sdt, ngaysinh, chucvu);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string mnv = txt_manv.Text;
            XoaNV(mnv);
        }

        private void tablenhanvien_MouseClick_1(object sender, MouseEventArgs e)
        {
            int index = tablenhanvien.CurrentRow.Index;
            txt_manv.Text = tablenhanvien.Rows[index].Cells[0].Value.ToString();
            txt_ten.Text = tablenhanvien.Rows[index].Cells[1].Value.ToString();
            txt_diachi.Text = tablenhanvien.Rows[index].Cells[3].Value.ToString();
            txt_sdt.Text = tablenhanvien.Rows[index].Cells[5].Value.ToString();
            txt_chucvu.Text = tablenhanvien.Rows[index].Cells[6].Value.ToString();
            if (tablenhanvien.Rows[index].Cells[2].Value.ToString() == "Nam") rd_nam.Checked = true;
            else rd_nu.Checked = true;

            txt_ngaysinh.Text = tablenhanvien.Rows[index].Cells[4].Value.ToString();
        }
    }
}
