using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using QuanLyKhachSan.data;
using QuanLyKhachSan.PhongService;
namespace QuanLyKhachSan.UserForm
{
    public partial class DichVu : Form
    {
        bool themmoi = false;
        int dong = -1;
        IphongApiClient client = new IphongApiClient();
        public DichVu()
        {
            InitializeComponent();
            
           
        }

        public void show_cbbLdv()
        {
            List<loaidichvu> list = client.getLoaidichvu().ToList();
            cbo_maloaidichvu.DataSource = list;
            cbo_maloaidichvu.ValueMember = "Id";
            cbo_maloaidichvu.DisplayMember = "Loai";
        }
        
        public void show_dichvu()
        {
            List<dichvu> list = client.getListDichVu().ToList();
            tabledichvu.DataSource =  list.Select(c => new { id = c.Id, ten = c.Name, loai = c.Loaidichvu.Loai, gia = c.Gia, dvt = c.Donvitinh }).ToList();
        }
        
        
        
        
       
        private void bt_luu_Click(object sender, EventArgs e)
        {
            

        }

        private void DichVu_Load(object sender, EventArgs e)
        {

            show_cbbLdv();
            show_dichvu();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
           
        }
        
        private void bt_them_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_madichvu_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
           
        }

        private void cbo_maloaidichvu_Click(object sender, EventArgs e)
        {
            
        }

        private void cbo_donvitinh_Click(object sender, EventArgs e)
        {
            
        }

        private void tabledichvu_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        //themmoi
        private void bt_them_Click_1(object sender, EventArgs e)
        {
            dichvu newDv = new dichvu();
            newDv.Id = -1;
            newDv.Name = txt_ten.Text;
            newDv.Gia = Convert.ToDouble(txt_giatien.Text);
            newDv.Id_ldv = Convert.ToInt32(cbo_maloaidichvu.SelectedValue);
            newDv.Donvitinh = txt_dvt.Text;
            if (client.updatedv(newDv))
            {
                MessageBox.Show("Đã Thêm");
                setNull();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }
        public void setNull()
        {
            ma_dv.Text = "";
            txt_ten.Text = "";
            txt_giatien.Text = "";
            cbo_maloaidichvu.Text = "";
            txt_dvt.Text = "";
            show_dichvu();
        }
        //xoa
        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ma_dv.Text);
            if (client.xoadv(id))
            {
                MessageBox.Show("Đã xóa");
                setNull();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }
        //thoat
        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //sua
        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            dichvu newDv = new dichvu();
            newDv.Id= Convert.ToInt32(ma_dv.Text);
            newDv.Name = txt_ten.Text;
            newDv.Gia = Convert.ToDouble(txt_giatien.Text);
            newDv.Id_ldv= Convert.ToInt32(cbo_maloaidichvu.SelectedValue);
            newDv.Donvitinh = txt_dvt.Text;
            if (client.updatedv(newDv))
            {
                MessageBox.Show("Đã Sửa");
                setNull();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }

        private void tabledichvu_MouseClick_1(object sender, MouseEventArgs e)
        {
            int index = tabledichvu.CurrentRow.Index;
            //MessageBox.Show(index.ToString());
            ma_dv.Text = tabledichvu.Rows[index].Cells[0].Value.ToString();
            txt_ten.Text = tabledichvu.Rows[index].Cells[1].Value.ToString();
            txt_giatien.Text = tabledichvu.Rows[index].Cells[3].Value.ToString();
            cbo_maloaidichvu.Text = tabledichvu.Rows[index].Cells[2].Value.ToString();
            txt_dvt.Text = tabledichvu.Rows[index].Cells[4].Value.ToString();
        }
    }

    
   
}

