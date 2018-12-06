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
using QuanLyKhachSan.PhongService;
namespace QuanLyKhachSan.UserForm
{
    public partial class HoaDon : Form
    {
        IphongApiClient client = new IphongApiClient();
        chitietdatphong chitiet = new chitietdatphong();
        public HoaDon()
        {
            InitializeComponent();
        }
        public static string mapdp;
        public static int idpdp;
        public void LayThongTin()
        {
            
            
            chitiet = client.getPhieuDatPhongById(idpdp);
            lb_tenp.Text = chitiet.Phong.Name;
            lb_ten.Text = chitiet.Phieudatphong.Khachhang.Hoten;
            lb_socm.Text = chitiet.Phieudatphong.Khachhang.Cmt;
            lb_ngaytp.Text = DateTime.Now.ToString();
            lb_ngaydp.Text = chitiet.Phieudatphong.Ngayden.ToString();
            lb_tienphong.Text = chitiet.Phong.LoaiPhong.Gia.ToString();
            lb_tc.Text = chitiet.Phieudatphong.Tiendatcoc.ToString();

        }
        public void LayTTDV()
        {
            List<chitietdichvu> list = new List<chitietdichvu>();
            list = client.getDichVuPdp(idpdp).ToList();
            tb_dv.AutoSize = true;
            tb_dv.DataSource = list.Select(c=>new { id = c.Dichvu.Id,ten= c.Dichvu.Name,loai=c.Dichvu.Loaidichvu.Loai,gia=c.Dichvu.Gia,dvt= c.Dichvu.Donvitinh, soluong=c.Soluong }).ToList();
            
           
            double countdv = 0;
            for (int i = 0; i < list.Count; i++)
            {
                countdv = countdv + list[i].Soluong * list[i].Dichvu.Gia;

            }
            lb_chiphi.Text = countdv.ToString();
            

        }
        
        private void HoaDon_Load(object sender, EventArgs e)
        {
            label1.Text ="Thanh toán phiếu đặt phòng số " + mapdp;
            LayThongTin();
            LayTTDV();
            lb_tongtien.Text = (Convert.ToDouble(lb_tienphong.Text) + Convert.ToDouble(lb_chiphi.Text)- Convert.ToDouble(lb_tc.Text)).ToString();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            //SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            //kn.Open();
            //string sql = "UPDATE dbo.PHIEUDATPHONG SET NGAYDI=GETDATE(), STATUS=1 WHERE MA_PDP='"+mapdp+"'";
            //SqlCommand commandsql = new SqlCommand(sql, kn);
            //commandsql.ExecuteNonQuery();
            //sql = "INSERT dbo.HOADON(  NGAYTHANHTOAN ,TONGTIEN , MA_PDP , MA_KH , USERNAME)VALUES  (  '" + lb_ngaytp.Text + "' ," + lb_tongtien.Text + " , '" + mapdp + "' ,  (SELECT MA_KH FROM dbo.PHIEUDATPHONG WHERE MA_PDP='" + mapdp + "') ,  '" + Login.usename + "'   ) ";
            //commandsql = new SqlCommand(sql, kn);
            //commandsql.ExecuteNonQuery();
            //sql = "UPDATE dbo.PHONG SET MA_TTP='TTP01' WHERE MA_P='" + lb_tenp.Text + "'";
            //commandsql = new SqlCommand(sql, kn);
            //commandsql.ExecuteNonQuery();
            client.traphong(idpdp,Convert.ToDouble(lb_tongtien.Text), Login.usename,chitiet.Id_p);
            MessageBox.Show("Đã thu tiền");
            this.Close();


        }
    }
}
