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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        public static string mapdp;
        
        public void LayThongTin()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT CTDP.MA_P,KH.HOTEN,KH.CMT,PDP.NGAYDEN,LP.GIA,PDP.TIENDATCOC FROM dbo.KHACHHANG KH,  dbo.PHIEUDATPHONG PDP, dbo.CHITIETDATPHONG CTDP, dbo.PHONG P, dbo.LOAIPHONG LP WHERE PDP.MA_PDP = '"+mapdp+"' AND PDP.MA_PDP = CTDP.MA_PDP AND CTDP.MA_P = P.MA_P AND P.MA_LP = LP.MA_LP AND  KH.MA_KH = PDP.MA_KH";
            //MessageBox.Show(sql);

            SqlCommand commandsql = new SqlCommand(sql, kn);

            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            DataRow dr = data.Rows[0];
            lb_tenp.Text = dr.ItemArray[0].ToString();
            lb_ten.Text = dr.ItemArray[1].ToString();
            lb_socm.Text = dr.ItemArray[2].ToString();
            lb_ngaytp.Text = DateTime.Now.ToString();
            lb_ngaydp.Text = dr.ItemArray[3].ToString();
            lb_tienphong.Text =  dr.ItemArray[4].ToString();
            lb_tc.Text= dr.ItemArray[5].ToString();

            //tb_dv.DataSource = data;

        }
        public void LayTTDV()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT dv.MA_DV N'Mã dịch vụ', dv.TEN N'Tên', ldv.LOAIDICHVU N'Loại',dv.GIA N'Giá',dv.DONVITINH N'Đơn vị tính',ctdv.soluong N'Số lượng' FROM dbo.CHITIETDICHVU ctdv, dbo.DICHVU dv, dbo.LOAIDICHVU ldv WHERE dv.MA_LDV = ldv.MA_LDV AND ctdv.MA_DV = dv.MA_DV AND ctdv.MA_PDP = '" + mapdp + "'";
            SqlCommand commandsql = new SqlCommand(sql, kn);

            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            tb_dv.DataSource = data;
            int countdv = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                 countdv = countdv+Convert.ToInt32( data.Rows[i][3].ToString())* Convert.ToInt32(data.Rows[i][5].ToString());
                
            }
            lb_chiphi.Text = countdv.ToString();
            kn.Close();
            
        }
        
        private void HoaDon_Load(object sender, EventArgs e)
        {
            label1.Text = mapdp;
            LayThongTin();
            LayTTDV();
            string tien;
            lb_tongtien.Text = (Convert.ToInt32(lb_tienphong.Text) + Convert.ToInt32(lb_chiphi.Text)- Convert.ToInt32(lb_tc.Text)).ToString();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();


            string sql = "UPDATE dbo.PHIEUDATPHONG SET NGAYDI=GETDATE(), TINHTRANG='finish' WHERE MA_PDP='"+mapdp+"'";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            commandsql.ExecuteNonQuery();
            sql = "INSERT dbo.HOADON(  NGAYTHANHTOAN ,TONGTIEN , MA_PDP , MA_KH , USERNAME)VALUES  (  '" + lb_ngaytp.Text + "' ," + lb_tongtien.Text + " , '" + mapdp + "' ,  (SELECT MA_KH FROM dbo.PHIEUDATPHONG WHERE MA_PDP='" + mapdp + "') ,  '" + Login.usename + "'   ) ";
            commandsql = new SqlCommand(sql, kn);
            commandsql.ExecuteNonQuery();
            sql = "UPDATE dbo.PHONG SET MA_TTP='TTP01' WHERE MA_P='" + lb_tenp.Text + "'";
            commandsql = new SqlCommand(sql, kn);
            commandsql.ExecuteNonQuery();
            
            MessageBox.Show("Đã thu tiền");
            this.Close();


        }
    }
}
