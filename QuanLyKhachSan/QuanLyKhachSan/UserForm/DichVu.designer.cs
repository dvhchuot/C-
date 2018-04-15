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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_madichvu = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.cbo_maloaidichvu = new System.Windows.Forms.ComboBox();
            this.cbo_donvitinh = new System.Windows.Forms.ComboBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.txt_giatien = new System.Windows.Forms.TextBox();
            this.tabledichvu = new System.Windows.Forms.DataGridView();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã loại dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(12, 143);
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
            this.label5.Location = new System.Drawing.Point(11, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giá tiền";
            // 
            // txt_madichvu
            // 
            this.txt_madichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_madichvu.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_madichvu.Location = new System.Drawing.Point(130, 60);
            this.txt_madichvu.Name = "txt_madichvu";
            this.txt_madichvu.Size = new System.Drawing.Size(174, 23);
            this.txt_madichvu.TabIndex = 2;
            this.txt_madichvu.TextChanged += new System.EventHandler(this.txt_madichvu_TextChanged);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_them.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_them.Location = new System.Drawing.Point(15, 263);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(80, 30);
            this.bt_them.TabIndex = 710;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cbo_maloaidichvu
            // 
            this.cbo_maloaidichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_maloaidichvu.FormattingEnabled = true;
            this.cbo_maloaidichvu.Location = new System.Drawing.Point(130, 102);
            this.cbo_maloaidichvu.Name = "cbo_maloaidichvu";
            this.cbo_maloaidichvu.Size = new System.Drawing.Size(174, 24);
            this.cbo_maloaidichvu.TabIndex = 4;
            this.cbo_maloaidichvu.Click += new System.EventHandler(this.cbo_maloaidichvu_Click);
            // 
            // cbo_donvitinh
            // 
            this.cbo_donvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_donvitinh.ForeColor = System.Drawing.Color.DarkCyan;
            this.cbo_donvitinh.FormattingEnabled = true;
            this.cbo_donvitinh.Location = new System.Drawing.Point(130, 143);
            this.cbo_donvitinh.Name = "cbo_donvitinh";
            this.cbo_donvitinh.Size = new System.Drawing.Size(174, 24);
            this.cbo_donvitinh.TabIndex = 4;
            this.cbo_donvitinh.Click += new System.EventHandler(this.cbo_donvitinh_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_xoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(121, 263);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(80, 30);
            this.bt_xoa.TabIndex = 710;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_luu.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_luu.Location = new System.Drawing.Point(225, 263);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(80, 30);
            this.bt_luu.TabIndex = 710;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_thoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_thoat.Location = new System.Drawing.Point(225, 324);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(80, 30);
            this.bt_thoat.TabIndex = 710;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_timkiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_timkiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_timkiem.Location = new System.Drawing.Point(12, 324);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(80, 30);
            this.bt_timkiem.TabIndex = 710;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_sua.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_sua.Location = new System.Drawing.Point(121, 324);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(80, 30);
            this.bt_sua.TabIndex = 710;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // txt_giatien
            // 
            this.txt_giatien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_giatien.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_giatien.Location = new System.Drawing.Point(130, 182);
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
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 420);
            this.Controls.Add(this.tabledichvu);
            this.Controls.Add(this.txt_giatien);
            this.Controls.Add(this.cbo_donvitinh);
            this.Controls.Add(this.cbo_maloaidichvu);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.txt_madichvu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_madichvu;
		private System.Windows.Forms.Button bt_them;
		private System.Windows.Forms.ComboBox cbo_maloaidichvu;
		private System.Windows.Forms.ComboBox cbo_donvitinh;
		private System.Windows.Forms.Button bt_xoa;
		private System.Windows.Forms.Button bt_luu;
		private System.Windows.Forms.Button bt_thoat;
		private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox txt_giatien;
        private System.Windows.Forms.DataGridView tabledichvu;
    }
}