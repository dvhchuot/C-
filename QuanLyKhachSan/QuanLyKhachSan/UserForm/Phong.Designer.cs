namespace QuanLyKhachSan.UserForm
{
    partial class Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phong));
            this.cmb_ttp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmb_lp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtMaPhong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tb_p = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_p)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_ttp
            // 
            this.cmb_ttp.DisplayMember = "Text";
            this.cmb_ttp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_ttp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ttp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ttp.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_ttp.FormattingEnabled = true;
            this.cmb_ttp.ItemHeight = 16;
            this.cmb_ttp.Location = new System.Drawing.Point(269, 136);
            this.cmb_ttp.Name = "cmb_ttp";
            this.cmb_ttp.Size = new System.Drawing.Size(121, 22);
            this.cmb_ttp.TabIndex = 14;
            this.cmb_ttp.ValueMember = "1";
            this.cmb_ttp.SelectedIndexChanged += new System.EventHandler(this.cmbMaTTrPhong_SelectedIndexChanged);
            // 
            // cmb_lp
            // 
            this.cmb_lp.DisplayMember = "Text";
            this.cmb_lp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_lp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_lp.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_lp.FormattingEnabled = true;
            this.cmb_lp.ItemHeight = 16;
            this.cmb_lp.Location = new System.Drawing.Point(269, 106);
            this.cmb_lp.Name = "cmb_lp";
            this.cmb_lp.Size = new System.Drawing.Size(121, 22);
            this.cmb_lp.TabIndex = 15;
            this.cmb_lp.ValueMember = "1";
            this.cmb_lp.SelectedIndexChanged += new System.EventHandler(this.cmbMaLPhong_SelectedIndexChanged);
            // 
            // txtMaPhong
            // 
            // 
            // 
            // 
            this.txtMaPhong.Border.Class = "TextBoxBorder";
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtMaPhong.Location = new System.Drawing.Point(269, 74);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 22);
            this.txtMaPhong.TabIndex = 13;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelX4.Location = new System.Drawing.Point(126, 134);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(125, 23);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Mã tình trạng phòng";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelX3.Location = new System.Drawing.Point(126, 104);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(89, 24);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Mã loại phòng";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelX2.Location = new System.Drawing.Point(126, 74);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 24);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Mã phòng";
            // 
            // tb_p
            // 
            this.tb_p.BackgroundColor = System.Drawing.Color.White;
            this.tb_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_p.Location = new System.Drawing.Point(12, 264);
            this.tb_p.Name = "tb_p";
            this.tb_p.ReadOnly = true;
            this.tb_p.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_p.Size = new System.Drawing.Size(563, 204);
            this.tb_p.TabIndex = 19;
            this.tb_p.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_p_MouseClick);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(126, 193);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 35);
            this.bt_them.TabIndex = 20;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(189, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(219, 193);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 35);
            this.bt_sua.TabIndex = 25;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(315, 193);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 35);
            this.bt_xoa.TabIndex = 26;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.White;
            this.bt_timkiem.Location = new System.Drawing.Point(405, 193);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(85, 35);
            this.bt_timkiem.TabIndex = 27;
            this.bt_timkiem.Text = "Tìm Kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(434, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 55);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.cmb_ttp);
            this.Controls.Add(this.cmb_lp);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Name = "Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_ttp;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_lp;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhong;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridView tb_p;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button button1;
    }
}