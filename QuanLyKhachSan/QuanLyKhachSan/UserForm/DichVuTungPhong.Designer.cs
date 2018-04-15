namespace QuanLyKhachSan.UserForm
{
    partial class DichVuTungPhong
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.tb_dv = new System.Windows.Forms.DataGridView();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_lu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_mp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.tb_dvp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dvp)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(362, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số Lượng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_sl
            // 
            this.txt_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sl.Location = new System.Drawing.Point(458, 201);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(55, 26);
            this.txt_sl.TabIndex = 22;
            this.txt_sl.TextChanged += new System.EventHandler(this.txt_sl_TextChanged);
            // 
            // tb_dv
            // 
            this.tb_dv.AllowUserToAddRows = false;
            this.tb_dv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_dv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_dv.Location = new System.Drawing.Point(12, 91);
            this.tb_dv.Name = "tb_dv";
            this.tb_dv.ReadOnly = true;
            this.tb_dv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_dv.Size = new System.Drawing.Size(331, 302);
            this.tb_dv.TabIndex = 21;
            this.tb_dv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_dv_MouseClick);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.ForeColor = System.Drawing.Color.MintCream;
            this.bt_huy.Location = new System.Drawing.Point(494, 363);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(101, 30);
            this.bt_huy.TabIndex = 17;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_lu
            // 
            this.bt_lu.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_lu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lu.ForeColor = System.Drawing.Color.MintCream;
            this.bt_lu.Location = new System.Drawing.Point(367, 363);
            this.bt_lu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_lu.Name = "bt_lu";
            this.bt_lu.Size = new System.Drawing.Size(105, 30);
            this.bt_lu.TabIndex = 18;
            this.bt_lu.Text = "Thêm";
            this.bt_lu.UseVisualStyleBackColor = false;
            this.bt_lu.Click += new System.EventHandler(this.bt_lu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bảng Dịch Vụ Phòng";
            // 
            // lb_mp
            // 
            this.lb_mp.AutoSize = true;
            this.lb_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp.Location = new System.Drawing.Point(380, 16);
            this.lb_mp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mp.Name = "lb_mp";
            this.lb_mp.Size = new System.Drawing.Size(64, 22);
            this.lb_mp.TabIndex = 8;
            this.lb_mp.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(362, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã DV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_madv
            // 
            this.txt_madv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madv.Location = new System.Drawing.Point(458, 155);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(55, 26);
            this.txt_madv.TabIndex = 24;
            this.txt_madv.TextChanged += new System.EventHandler(this.txt_madv_TextChanged);
            // 
            // tb_dvp
            // 
            this.tb_dvp.AllowUserToAddRows = false;
            this.tb_dvp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_dvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_dvp.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_dvp.Location = new System.Drawing.Point(623, 91);
            this.tb_dvp.Name = "tb_dvp";
            this.tb_dvp.ReadOnly = true;
            this.tb_dvp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_dvp.Size = new System.Drawing.Size(331, 302);
            this.tb_dvp.TabIndex = 26;
            // 
            // DichVuTungPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 415);
            this.Controls.Add(this.tb_dvp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_madv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.tb_dv);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_lu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_mp);
            this.Name = "DichVuTungPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DichVuTungPhong";
            this.Load += new System.EventHandler(this.DichVuTungPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_dv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dvp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.DataGridView tb_dv;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_lu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_mp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.DataGridView tb_dvp;
    }
}