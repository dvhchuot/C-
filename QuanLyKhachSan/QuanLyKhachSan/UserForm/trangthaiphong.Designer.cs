namespace QuanLyKhachSan.UserForm
{
    partial class TrangThaiPhong
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
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.cmb_ttp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangthai.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_trangthai.Location = new System.Drawing.Point(129, 42);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(86, 25);
            this.lb_trangthai.TabIndex = 0;
            this.lb_trangthai.Text = "Phòng ";
            this.lb_trangthai.Click += new System.EventHandler(this.lb_trangthai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(96, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thay đổi trạng thái";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_thoat.Location = new System.Drawing.Point(288, 188);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 30);
            this.bt_thoat.TabIndex = 25;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_luu.Location = new System.Drawing.Point(134, 188);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 30);
            this.bt_luu.TabIndex = 24;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // cmb_ttp
            // 
            this.cmb_ttp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ttp.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmb_ttp.FormattingEnabled = true;
            this.cmb_ttp.Location = new System.Drawing.Point(257, 115);
            this.cmb_ttp.Name = "cmb_ttp";
            this.cmb_ttp.Size = new System.Drawing.Size(124, 24);
            this.cmb_ttp.TabIndex = 26;
            // 
            // TrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 276);
            this.Controls.Add(this.cmb_ttp);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_trangthai);
            this.Name = "TrangThaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trangthaiphong";
            this.Load += new System.EventHandler(this.TrangThaiPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.ComboBox cmb_ttp;
    }
}