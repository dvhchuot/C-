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
using QuanLyKhachSan.PhongService;
namespace QuanLyKhachSan.UserForm
{
    public partial class ChiTietPhong : Form
    {
        public ChiTietPhong()
        {
            InitializeComponent();
            
        }


        public static string Maphong;
        public int idpdp;
        public static int idP;


        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            DichVuTungPhong.maPhong = Maphong;
            DichVuTungPhong.maPdp = idpdp.ToString();
            DichVuTungPhong.idP = idP;
            DichVuTungPhong.idPdp = idpdp;
            DichVuTungPhong dvtp = new DichVuTungPhong();
            dvtp.ShowDialog();
        }
        public void load()
        {
            IphongApiClient client = new IphongApiClient();
            try
            {
                chitietdatphong chitiet = client.getPhongById(idP);
                lb_tenp.Text = chitiet.Phong.Name;
                lb_lp.Text = chitiet.Phong.LoaiPhong.Mota;
                lp_gp.Text = chitiet.Phong.LoaiPhong.Gia.ToString();
                txt_songuoidp.Text = chitiet.Phieudatphong.Songuoi.ToString() + "/" + chitiet.Phong.LoaiPhong.SoNguoi.ToString();
                txt_ten.Text = chitiet.Phieudatphong.Khachhang.Hoten;
                txt_sdt.Text = chitiet.Phieudatphong.Khachhang.Sdt;
                txt_socm.Text = chitiet.Phieudatphong.Khachhang.Cmt;

                txt_ngayden.Text = chitiet.Phieudatphong.Ngayden.ToString();
                rd_kt.Checked = true;


                idpdp = chitiet.Id_pdp;
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi mời thử lại");
                //this.Hide();
            }
        }
        private void ChiTietPhong_Load(object sender, EventArgs e)
        {
            load();
            

        }

        private void bt_tinhtien_Click(object sender, EventArgs e)
        {
            HoaDon.mapdp = idpdp.ToString();
            HoaDon.idpdp = idpdp;
            HoaDon hoaDon = new HoaDon();
            this.Hide();
            hoaDon.ShowDialog();
        }
    }
}
