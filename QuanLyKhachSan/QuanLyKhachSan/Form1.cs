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
using DevComponents.DotNetBar;
using QuanLyKhachSan.UserForm;
using QuanLyKhachSan.data;
using QuanLyKhachSan.PhongService;
namespace QuanLyKhachSan
{
    public partial class Form1 : Office2007RibbonForm
    {
        IphongApiClient client = new IphongApiClient();
        public Form1()
        {
            InitializeComponent();
            listPhong(-1);
        }
        public void quyenAdmin()
        {
            

        }

        public void quyenNhanVien()
        {
            buttonItem5.Enabled = false;
            ribbonBar9.Enabled = false;
        }
        public void listPhong(int status)
        {
            listViewEx1.Items.Clear();

            //MessageBox.Show("@"+Connectsql.connectionsql);
            
            phong[] list = client.getListPhong(status);
            for(int i = 0; i < list.Length; i++)
            {
                string id = list[i].Id.ToString();

                int ttp =list[i].Status-1;
                var item = new ListViewItem();
                item.Name = id;
                item.ImageIndex = ttp;
                item.Text= list[i].Name;
                
                listViewEx1.Items.Add(item);
            }
            

        }
        public void phongtt(string tt)
        {
            listViewEx1.Items.Clear();

            //MessageBox.Show("@"+Connectsql.connectionsql);

            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);


            kn.Open();
            string sql = "Select * from phong WHERE MA_TTP='" + tt+"'";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string maphong = data.Rows[i][0].ToString();
                string ttphong = data.Rows[i][2].ToString();
                var item = new ListViewItem();
                item.Name = maphong;
                if (ttphong == "TTP01     ")
                    item.ImageIndex = 0;
                else if (ttphong == "TTP02     ")
                    item.ImageIndex = 1;
                else if (ttphong == "TTP03     ")
                    item.ImageIndex = 2;
                else if (ttphong == "TTP04     ")
                    item.ImageIndex = 3;
                listViewEx1.Items.Add(item);

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
            
        }

        private void listViewEx1_MouseClick(object sender, MouseEventArgs e)
        {
            dataPhong dtp = new dataPhong();
            string maphong=listViewEx1.SelectedItems[0].Name.ToString();
            //MessageBox.Show(maphong);
            int check = client.ktraPhong(Convert.ToInt32(maphong));
            switch (check)
            {
                case 2:
                    ChiTietPhong.idP = Convert.ToInt32(maphong);
                    ChiTietPhong phong = new ChiTietPhong();
                    phong.ShowDialog();
                    listPhong(-1);
                    break;
                case 1:
                    DatPhong.MaPhong = listViewEx1.SelectedItems[0].Text.ToString(); ;
                    DatPhong.idp= Convert.ToInt32(maphong);
                    DatPhong datPhong = new DatPhong();
                    datPhong.ShowDialog();
                    listPhong(-1);
                    break;
                case 3:
                    MessageBox.Show("Phòng đang dọn dẹp");
                    break;
                case 4:
                    MessageBox.Show("Phòng đang sửa chữa");
                    break;
                default:
                    MessageBox.Show("Xảy ra lỗi xin mời thử lại");
                    break;
            }

            //if(dtp.Kiemtraphong(maphong)==1)
            //{
            //    ChiTietPhong.Maphong = maphong;
            //    ChiTietPhong phong = new ChiTietPhong();

            //    phong.ShowDialog();
            //}
            //if (dtp.Kiemtraphong(maphong) == 0)
            //{
            //    DatPhong.MaPhong = maphong;
            //    DatPhong datPhong = new DatPhong();
            //    datPhong.ShowDialog();
            //}
            //TrangThaiPhong ttp = new TrangThaiPhong();
            //if (dtp.Kiemtraphong(maphong) == 2)
            //{
            //    TrangThaiPhong.trangthai = "đang dọn dẹp";
            //    TrangThaiPhong.maphong = maphong;
            //    ttp.ShowDialog();
            //}
            //if (dtp.Kiemtraphong(maphong) == 3)
            //{
            //    TrangThaiPhong.trangthai = "đang sửa chữa";
            //    TrangThaiPhong.maphong = maphong;
            //    ttp.ShowDialog();
            //}



        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            KhachHang kh = new UserForm.KhachHang();
            kh.ShowDialog();
        }

        private void DichVu_Click(object sender, EventArgs e)
        {
            DichVu dv = new UserForm.DichVu();
            dv.ShowDialog();
        }

        private void DSPhong_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.ShowDialog();
        }

        private void NhanPhong_Click(object sender, EventArgs e)
        {
            listPhong(2);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien ttnv = new ThongTinNhanVien();
            ttnv.ShowDialog();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            dsnv.ShowDialog();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();

        }

        private void KhachHang_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.ShowDialog();

        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            listPhong(4);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            listPhong(3);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            listPhong(1);
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            listPhong(-1);
        }
    }
}
