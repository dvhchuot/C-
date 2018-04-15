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
    public partial class ThongTinNhanVien : Form
    {
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }
        public string manv;

        public void HienThi()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT * FROM dbo.NHANVIEN WHERE MA_NV IN(SELECT MA_NV FROM dbo.HETHONG WHERE USENAME='"+Login.usename+"')";
            //MessageBox.Show(sql);

            SqlCommand commandsql = new SqlCommand(sql, kn);

            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            DataRow dr = data.Rows[0];
            manv= dr.ItemArray[0].ToString();
            txt_ten.Text = dr.ItemArray[1].ToString();
            txt_ngaysinh.Text = dr.ItemArray[2].ToString();
            //MessageBox.Show(dr.ItemArray[3].ToString());
            if (dr.ItemArray[3].ToString() == "True") rd_nam.Checked = true;
            if (dr.ItemArray[3].ToString() == "False") rd_nu.Checked = true;
            txt_diachi.Text = dr.ItemArray[4].ToString();
            txt_sdt.Text = dr.ItemArray[5].ToString();

        }

        public void updateTT(string hoten,string ngaysinh,string gt,string diachi,string sdt)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "UPDATE dbo.NHANVIEN SET HOTEN=N'"+hoten+"', NGAYSINH='"+ngaysinh+"', GIOITINH="+gt+", DIACHI=N'"+diachi+"', SDT='"+sdt+"' WHERE MA_NV='"+manv+"'";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            commandsql.ExecuteNonQuery();

            MessageBox.Show("Sửa thành công");
            kn.Close();

        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            int gt = -1;
            if (rd_nam.Checked == true) gt = 1;
            if (rd_nu.Checked == true) gt = 0;
            updateTT(txt_ten.Text, txt_ngaysinh.Text, gt.ToString(), txt_diachi.Text, txt_sdt.Text);
        }
    }
}
