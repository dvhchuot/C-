namespace QuanLyKhachSan.UserForm
{
    partial class DichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.cbo_maloaidichvu = new System.Windows.Forms.ComboBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.txt_giatien = new System.Windows.Forms.TextBox();
            this.tabledichvu = new System.Windows.Forms.DataGridView();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.lb_ten = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ma_dv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabledichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giá tiền";
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_them.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_them.Location = new System.Drawing.Point(64, 263);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(80, 30);
            this.bt_them.TabIndex = 710;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // cbo_maloaidichvu
            // 
            this.cbo_maloaidichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_maloaidichvu.FormattingEnabled = true;
            this.cbo_maloaidichvu.Location = new System.Drawing.Point(134, 130);
            this.cbo_maloaidichvu.Name = "cbo_maloaidichvu";
            this.cbo_maloaidichvu.Size = new System.Drawing.Size(174, 24);
            this.cbo_maloaidichvu.TabIndex = 4;
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_xoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(199, 263);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(80, 30);
            this.bt_xoa.TabIndex = 710;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click_1);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_thoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_thoat.Location = new System.Drawing.Point(199, 324);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(80, 30);
            this.bt_thoat.TabIndex = 710;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click_1);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_sua.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_sua.Location = new System.Drawing.Point(64, 324);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(80, 30);
            this.bt_sua.TabIndex = 710;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click_1);
            // 
            // txt_giatien
            // 
            this.txt_giatien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_giatien.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_giatien.Location = new System.Drawing.Point(134, 210);
            this.txt_giatien.Name = "txt_giatien";
            this.txt_giatien.Size = new System.Drawing.Size(174, 23);
            this.txt_giatien.TabIndex = 723;
            // 
            // tabledichvu
            // 
            this.tabledichvu.BackgroundColor = System.Drawing.Color.White;
            this.tabledichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledichvu.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabledichvu.Location = new System.Drawing.Point(367, 60);
            this.tabledichvu.Name = "tabledichvu";
            this.tabledichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabledichvu.Size = new System.Drawing.Size(504, 330);
            this.tabledichvu.TabIndex = 724;
            this.tabledichvu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabledichvu_MouseClick_1);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_dvt.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_dvt.Location = new System.Drawing.Point(134, 168);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(174, 23);
            this.txt_dvt.TabIndex = 725;
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_ten.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_ten.Location = new System.Drawing.Point(134, 91);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(174, 23);
            this.txt_ten.TabIndex = 727;
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_ten.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_ten.Location = new System.Drawing.Point(15, 91);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(82, 17);
            this.lb_ten.TabIndex = 726;
            this.lb_ten.Text = "Tên dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(15, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 728;
            // 
            // ma_dv
            // 
            this.ma_dv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ma_dv.ForeColor = System.Drawing.Color.DarkCyan;
            this.ma_dv.Location = new System.Drawing.Point(134, 40);
            this.ma_dv.Name = "ma_dv";
            this.ma_dv.Size = new System.Drawing.Size(174, 23);
            this.ma_dv.TabIndex = 729;
            this.ma_dv.Visible = false;
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 420);
            this.Controls.Add(this.ma_dv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.tabledichvu);
            this.Controls.Add(this.txt_giatien);
            this.Controls.Add(this.cbo_maloaidichvu);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabledichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button bt_them;
		private System.Windows.Forms.ComboBox cbo_maloaidichvu;
		private System.Windows.Forms.Button bt_xoa;
		private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox txt_giatien;
        private System.Windows.Forms.DataGridView tabledichvu;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ma_dv;
    }
}