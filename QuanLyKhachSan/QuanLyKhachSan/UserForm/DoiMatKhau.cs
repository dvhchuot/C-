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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            lb_tk.Text = Login.usename;
        }
        public void doimk(string mk)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "UPDATE dbo.HETHONG SET PASSWORD='"+mk+"' WHERE USENAME='"+Login.usename+"'";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            commandsql.ExecuteNonQuery();

            MessageBox.Show("Thay đổi thành công");
            kn.Close();
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_mkc.Text == Login.pass)
            {
                if (txt_mkm.Text == txt_nl.Text) doimk(txt_nl.Text);
                else MessageBox.Show("Nhập mk không khớp");
            }
            else MessageBox.Show("Nhập MK sai");
        }
    }
}
