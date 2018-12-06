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
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }

        public void addKhachHang(string mkh, string hoten, string gt, string cmt, string diachi, string sdt, string email, string mpdp, string ngayden, string tiencoc, string songuoi)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try

            {
                string sql = "INSERT dbo.KHACHHANG ( MA_KH , HOTEN ,GIOITINH ,CMT ,DIACHI , SDT , EMAIL )VALUES  ( '" + mkh + "' , N'" + hoten + "' ,  " + gt + " , '" + cmt + "' ,  N'" + diachi + "' , '" + sdt + "' ,  '" + email + "'  )";
                SqlCommand command = new SqlCommand(sql, kn);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công");
                addPhieuDatPhong(mpdp, mkh, ngayden, tiencoc, songuoi);
            }
            catch
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }


            kn.Close();
        }
        public void updatettp()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql_ = "UPDATE dbo.PHONG SET MA_TTP='TTP02' WHERE MA_P='"+MaPhong+"'";
            SqlCommand command_ = new SqlCommand(sql_, kn);
            command_.ExecuteNonQuery();
            kn.Close();
        }
        public void addPhieuDatPhong(string mpdp,string mkh, string ngayden,string tiencoc,string songuoi)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try

            {
                string sql = "INSERT dbo.PHIEUDATPHONG( MA_PDP , MA_KH , NGAYDEN , NGAYDI ,TIENDATCOC ,USERNAME ,TINHTRANG ,SONGUOI ) VALUES  ( '"+mpdp+"' ,'"+mkh+"' , '"+ngayden+"',  '', "+tiencoc+" ,  N'"+Login.usename+"' ,  N'waitting' ,  "+songuoi+" )";
                SqlCommand command = new SqlCommand(sql, kn);
                command.ExecuteNonQuery();
                
                string sql_ = "INSERT dbo.CHITIETDATPHONG( MA_PDP, MA_P )VALUES  ( '" + mpdp + "', '" + MaPhong + "'  )";
                SqlCommand command_ = new SqlCommand(sql_, kn);
                command_.ExecuteNonQuery();
                MessageBox.Show("Thêm  thành công");
                updatettp();
            }
            catch
            {

                string sql = "DELETE dbo.KHACHHANG WHERE MA_KH='" + mkh + "'";
                SqlCommand command = new SqlCommand(sql, kn);
                command.ExecuteNonQuery();
                MessageBox.Show("Mã phiếu đặt đã tồn tại");

            }
            
            kn.Close();
            
        }
        public static string MaPhong;
        public static int idp;
        private void DatPhong_Load(object sender, EventArgs e)
        {
            lb_mp.Text = MaPhong;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string mpdp = "";
            string mkh = "";
            string hoten = txt_ten.Text;
            string gt = "-1";
            if (rd_nam.Checked == true) gt = "1";
            if (rd_nu.Checked == true) gt = "0";
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string cmt = txt_cmt.Text;
            string email = txt_email.Text;
            string ngaydat = dt_ngay.Value.ToString();
            string tiencoc = txt_tiencoc.Text;
            string songuoi = txt_songuoi.Text;
            addKhachHang(mkh, hoten, gt, cmt, diachi, sdt, email,mpdp,ngaydat,tiencoc,songuoi);
            
        }
    }
}
