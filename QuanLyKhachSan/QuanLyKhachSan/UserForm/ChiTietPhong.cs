using QuanLyKhachSan.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserForm
{
    public partial class ChiTietPhong : Form
    {
        public ChiTietPhong()
        {
            InitializeComponent();
        }


        public static string Maphong;
        public string mapdp;


        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            DichVuTungPhong.maPhong = Maphong;
            DichVuTungPhong.maPdp = mapdp;
            DichVuTungPhong dvtp = new DichVuTungPhong();
            dvtp.ShowDialog();
        }

        private void ChiTietPhong_Load(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            //SqlConnection kn = new SqlConnection(@"Data Source = DESKTOP-BIBNN55\SQLEXPRESS;Initial Catalog = KHACHSAN; Integrated Security = True");
            kn.Open();
            
            
                string sql = " SELECT p.MA_P,P.MA_LP,LP.GIA,LP.SONGUOI,KH.HOTEN,KH.SDT,KH.CMT,PDP.SONGUOI,PDP. NGAYDEN ,PDP.MA_PDP FROM dbo.khachhang AS KH, dbo.chitietdatphong AS  CTDP, dbo.phieudatphong AS PDP,phong AS P,loaiphong AS LP WHERE KH.MA_KH = PDP.MA_KH AND PDP.MA_PDP = CTDP.MA_PDP AND P.MA_P = '" + Maphong + "' AND P.MA_LP = LP.MA_LP AND P.MA_P = CTDP.MA_P AND PDP.TINHTRANG='waitting' ";
                //MessageBox.Show(sql);

                SqlCommand commandsql = new SqlCommand(sql, kn);

                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable data = new DataTable();
                com.Fill(data);
                DataRow dr = data.Rows[0];
                lb_tenp.Text = dr.ItemArray[0].ToString();
                lb_lp.Text = dr.ItemArray[1].ToString();
                lp_gp.Text = dr.ItemArray[2].ToString();
                txt_songuoidp.Text = dr.ItemArray[7].ToString() + "/" + dr.ItemArray[3].ToString();
                txt_ten.Text = dr.ItemArray[4].ToString();
                txt_sdt.Text = dr.ItemArray[5].ToString();
                txt_socm.Text = dr.ItemArray[6].ToString();
                
                txt_ngayden.Text = dr.ItemArray[8].ToString();
                rd_kt.Checked = true;
                
                mapdp= dr.ItemArray[9].ToString();






        }

        private void bt_tinhtien_Click(object sender, EventArgs e)
        {
            HoaDon.mapdp = mapdp;
            HoaDon hoaDon = new HoaDon();
            this.Hide();
            hoaDon.ShowDialog();
        }
    }
}
