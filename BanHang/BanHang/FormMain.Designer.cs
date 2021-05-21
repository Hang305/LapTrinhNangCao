namespace BanHang
{
    partial class FormMain
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
            if ( disposing && ( components != null ) )
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
            this.cbNhomHang = new System.Windows.Forms.ComboBox();
            this.cbThuongHieu = new System.Windows.Forms.ComboBox();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbmanhinh = new System.Windows.Forms.Label();
            this.lbcpu = new System.Windows.Forms.Label();
            this.lbcard = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.pictureBoxSP = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNhomHang
            // 
            this.cbNhomHang.Font = new System.Drawing.Font("Lato", 10F);
            this.cbNhomHang.FormattingEnabled = true;
            this.cbNhomHang.Location = new System.Drawing.Point(41, 78);
            this.cbNhomHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbNhomHang.Name = "cbNhomHang";
            this.cbNhomHang.Size = new System.Drawing.Size(235, 24);
            this.cbNhomHang.TabIndex = 1;
            this.cbNhomHang.SelectedIndexChanged += new System.EventHandler(this.cbNhomHang_SelectedIndexChanged);
            // 
            // cbThuongHieu
            // 
            this.cbThuongHieu.Font = new System.Drawing.Font("Lato", 10F);
            this.cbThuongHieu.FormattingEnabled = true;
            this.cbThuongHieu.Location = new System.Drawing.Point(320, 78);
            this.cbThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbThuongHieu.Name = "cbThuongHieu";
            this.cbThuongHieu.Size = new System.Drawing.Size(235, 24);
            this.cbThuongHieu.TabIndex = 1;
            this.cbThuongHieu.SelectedIndexChanged += new System.EventHandler(this.cbThuongHieu_SelectedIndexChanged);
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.Font = new System.Drawing.Font("Lato", 10F);
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.Location = new System.Drawing.Point(592, 78);
            this.cbLoaiSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(221, 24);
            this.cbLoaiSanPham.TabIndex = 1;
            this.cbLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSanPham_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(41, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(320, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thương hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(592, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại sản phẩm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1607, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(23, 27);
            this.dataGridViewSP.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.RowTemplate.Height = 200;
            this.dataGridViewSP.Size = new System.Drawing.Size(1033, 425);
            this.dataGridViewSP.TabIndex = 6;
            this.dataGridViewSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSP_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewSP);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(32, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1085, 475);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1143, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin chi tiết sản phẩm";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.lbTenSP.Location = new System.Drawing.Point(1144, 454);
            this.lbTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(92, 17);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(1144, 483);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1144, 515);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Màn hình";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1144, 550);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "CPU";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(1144, 580);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Card đồ họa";
            // 
            // lbmanhinh
            // 
            this.lbmanhinh.AutoSize = true;
            this.lbmanhinh.Font = new System.Drawing.Font("Lato", 10F);
            this.lbmanhinh.Location = new System.Drawing.Point(1268, 515);
            this.lbmanhinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmanhinh.Name = "lbmanhinh";
            this.lbmanhinh.Size = new System.Drawing.Size(41, 17);
            this.lbmanhinh.TabIndex = 10;
            this.lbmanhinh.Text = "trống";
            // 
            // lbcpu
            // 
            this.lbcpu.AutoSize = true;
            this.lbcpu.Font = new System.Drawing.Font("Lato", 10F);
            this.lbcpu.Location = new System.Drawing.Point(1268, 543);
            this.lbcpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcpu.Name = "lbcpu";
            this.lbcpu.Size = new System.Drawing.Size(41, 17);
            this.lbcpu.TabIndex = 10;
            this.lbcpu.Text = "trống";
            // 
            // lbcard
            // 
            this.lbcard.AutoSize = true;
            this.lbcard.Font = new System.Drawing.Font("Lato", 10F);
            this.lbcard.Location = new System.Drawing.Point(1268, 574);
            this.lbcard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcard.Name = "lbcard";
            this.lbcard.Size = new System.Drawing.Size(41, 17);
            this.lbcard.TabIndex = 10;
            this.lbcard.Text = "trống";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Lato", 10F);
            this.lbGia.Location = new System.Drawing.Point(1268, 483);
            this.lbGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(41, 17);
            this.lbGia.TabIndex = 10;
            this.lbGia.Text = "trống";
            // 
            // pictureBoxSP
            // 
            this.pictureBoxSP.Location = new System.Drawing.Point(1147, 53);
            this.pictureBoxSP.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSP.Name = "pictureBoxSP";
            this.pictureBoxSP.Size = new System.Drawing.Size(352, 330);
            this.pictureBoxSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSP.TabIndex = 11;
            this.pictureBoxSP.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1607, 634);
            this.Controls.Add(this.pictureBoxSP);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbcard);
            this.Controls.Add(this.lbcpu);
            this.Controls.Add(this.lbmanhinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoaiSanPham);
            this.Controls.Add(this.cbThuongHieu);
            this.Controls.Add(this.cbNhomHang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTenSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lato", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbNhomHang;
        private System.Windows.Forms.ComboBox cbThuongHieu;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbmanhinh;
        private System.Windows.Forms.Label lbcpu;
        private System.Windows.Forms.Label lbcard;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.PictureBox pictureBoxSP;
    }
}

