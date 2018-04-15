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
namespace QuanLyKhachSan
{
    public partial class Form1 : Office2007RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void quyenAdmin()
        {
            

        }

        public void quyenNhanVien()
        {
            buttonItem5.Enabled = false;
            ribbonBar9.Enabled = false;
        }
        public void listPhong()
        {
            listViewEx1.Items.Clear();

            //MessageBox.Show("@"+Connectsql.connectionsql);

            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);


            kn.Open();
            string sql = "Select * from phong";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string maphong = data.Rows[i][0].ToString();
                string ttphong = data.Rows[i][2].ToString();
                var item = new ListViewItem(maphong);
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
                var item = new ListViewItem(maphong);
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

            listPhong();
            
        }

        private void listViewEx1_MouseClick(object sender, MouseEventArgs e)
        {
            dataPhong dtp = new dataPhong();
            string maphong=listViewEx1.SelectedItems[0].Text;
            if(dtp.Kiemtraphong(maphong)==1)
            {
                ChiTietPhong.Maphong = maphong;
                ChiTietPhong phong = new ChiTietPhong();

                phong.ShowDialog();
            }
            if (dtp.Kiemtraphong(maphong) == 0)
            {
                DatPhong.MaPhong = maphong;
                DatPhong datPhong = new DatPhong();
                datPhong.ShowDialog();
            }
            TrangThaiPhong ttp = new TrangThaiPhong();
            if (dtp.Kiemtraphong(maphong) == 2)
            {
                TrangThaiPhong.trangthai = "đang dọn dẹp";
                TrangThaiPhong.maphong = maphong;
                ttp.ShowDialog();
            }
            if (dtp.Kiemtraphong(maphong) == 3)
            {
                TrangThaiPhong.trangthai = "đang sửa chữa";
                TrangThaiPhong.maphong = maphong;
                ttp.ShowDialog();
            }



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
            phongtt("TTP02     ");
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
            phongtt("TTP04     ");
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            phongtt("TTP03     ");
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            phongtt("TTP01     ");
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            listPhong();
        }
    }
}
