namespace QuanLyPhongMachTu.UserControls
{
    partial class HoaDonThanhToan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Hoadonthanhtoan = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.gbx_Hoadon = new System.Windows.Forms.GroupBox();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_TienThuoc = new System.Windows.Forms.Label();
            this.lbl_TienKham = new System.Windows.Forms.Label();
            this.lbl_NgayKham = new System.Windows.Forms.Label();
            this.lbl_HoVaTen = new System.Windows.Forms.Label();
            this.lbl_TongTien_TD = new System.Windows.Forms.Label();
            this.lbl_TienThuoc_TD = new System.Windows.Forms.Label();
            this.lbl_TenKham_TD = new System.Windows.Forms.Label();
            this.lbl_NgayKham_TD = new System.Windows.Forms.Label();
            this.lbl_HoVaTen_TD = new System.Windows.Forms.Label();
            this.lbl_dsThuoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_dsThuoc = new System.Windows.Forms.DataGridView();
            this.btn_Xuat = new Guna.UI2.WinForms.Guna2Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_Hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Hoadonthanhtoan
            // 
            this.lbl_Hoadonthanhtoan.AutoSize = false;
            this.lbl_Hoadonthanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hoadonthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoadonthanhtoan.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_Hoadonthanhtoan.Location = new System.Drawing.Point(226, 43);
            this.lbl_Hoadonthanhtoan.Name = "lbl_Hoadonthanhtoan";
            this.lbl_Hoadonthanhtoan.Size = new System.Drawing.Size(463, 50);
            this.lbl_Hoadonthanhtoan.TabIndex = 0;
            this.lbl_Hoadonthanhtoan.Text = "HÓA ĐƠN THANH TOÁN";
            this.lbl_Hoadonthanhtoan.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // gbx_Hoadon
            // 
            this.gbx_Hoadon.Controls.Add(this.lbl_TongTien);
            this.gbx_Hoadon.Controls.Add(this.lbl_TienThuoc);
            this.gbx_Hoadon.Controls.Add(this.lbl_TienKham);
            this.gbx_Hoadon.Controls.Add(this.lbl_NgayKham);
            this.gbx_Hoadon.Controls.Add(this.lbl_HoVaTen);
            this.gbx_Hoadon.Controls.Add(this.lbl_TongTien_TD);
            this.gbx_Hoadon.Controls.Add(this.lbl_TienThuoc_TD);
            this.gbx_Hoadon.Controls.Add(this.lbl_TenKham_TD);
            this.gbx_Hoadon.Controls.Add(this.lbl_NgayKham_TD);
            this.gbx_Hoadon.Controls.Add(this.lbl_HoVaTen_TD);
            this.gbx_Hoadon.Location = new System.Drawing.Point(159, 133);
            this.gbx_Hoadon.Name = "gbx_Hoadon";
            this.gbx_Hoadon.Size = new System.Drawing.Size(593, 143);
            this.gbx_Hoadon.TabIndex = 1;
            this.gbx_Hoadon.TabStop = false;
            this.gbx_Hoadon.Text = "Thông Tin Hóa Đơn";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(414, 113);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(84, 16);
            this.lbl_TongTien.TabIndex = 9;
            this.lbl_TongTien.Text = "100.000 VND";
            // 
            // lbl_TienThuoc
            // 
            this.lbl_TienThuoc.AutoSize = true;
            this.lbl_TienThuoc.Location = new System.Drawing.Point(414, 70);
            this.lbl_TienThuoc.Name = "lbl_TienThuoc";
            this.lbl_TienThuoc.Size = new System.Drawing.Size(84, 16);
            this.lbl_TienThuoc.TabIndex = 8;
            this.lbl_TienThuoc.Text = "150.000 VND";
            // 
            // lbl_TienKham
            // 
            this.lbl_TienKham.AutoSize = true;
            this.lbl_TienKham.Location = new System.Drawing.Point(414, 28);
            this.lbl_TienKham.Name = "lbl_TienKham";
            this.lbl_TienKham.Size = new System.Drawing.Size(84, 16);
            this.lbl_TienKham.TabIndex = 7;
            this.lbl_TienKham.Text = "200.000 VND";
            // 
            // lbl_NgayKham
            // 
            this.lbl_NgayKham.AutoSize = true;
            this.lbl_NgayKham.Location = new System.Drawing.Point(132, 94);
            this.lbl_NgayKham.Name = "lbl_NgayKham";
            this.lbl_NgayKham.Size = new System.Drawing.Size(71, 16);
            this.lbl_NgayKham.TabIndex = 6;
            this.lbl_NgayKham.Text = "12/12/2012";
            // 
            // lbl_HoVaTen
            // 
            this.lbl_HoVaTen.AutoSize = true;
            this.lbl_HoVaTen.Location = new System.Drawing.Point(132, 47);
            this.lbl_HoVaTen.Name = "lbl_HoVaTen";
            this.lbl_HoVaTen.Size = new System.Drawing.Size(93, 16);
            this.lbl_HoVaTen.TabIndex = 5;
            this.lbl_HoVaTen.Text = "Nguyễn Văn A";
            // 
            // lbl_TongTien_TD
            // 
            this.lbl_TongTien_TD.AutoSize = true;
            this.lbl_TongTien_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien_TD.Location = new System.Drawing.Point(292, 113);
            this.lbl_TongTien_TD.Name = "lbl_TongTien_TD";
            this.lbl_TongTien_TD.Size = new System.Drawing.Size(82, 17);
            this.lbl_TongTien_TD.TabIndex = 2;
            this.lbl_TongTien_TD.Text = "Tổng tiền:";
            // 
            // lbl_TienThuoc_TD
            // 
            this.lbl_TienThuoc_TD.AutoSize = true;
            this.lbl_TienThuoc_TD.Location = new System.Drawing.Point(292, 70);
            this.lbl_TienThuoc_TD.Name = "lbl_TienThuoc_TD";
            this.lbl_TienThuoc_TD.Size = new System.Drawing.Size(72, 16);
            this.lbl_TienThuoc_TD.TabIndex = 3;
            this.lbl_TienThuoc_TD.Text = "Tiền thuốc:";
            // 
            // lbl_TenKham_TD
            // 
            this.lbl_TenKham_TD.AutoSize = true;
            this.lbl_TenKham_TD.Location = new System.Drawing.Point(292, 28);
            this.lbl_TenKham_TD.Name = "lbl_TenKham_TD";
            this.lbl_TenKham_TD.Size = new System.Drawing.Size(73, 16);
            this.lbl_TenKham_TD.TabIndex = 4;
            this.lbl_TenKham_TD.Text = "Tiền khám:";
            // 
            // lbl_NgayKham_TD
            // 
            this.lbl_NgayKham_TD.AutoSize = true;
            this.lbl_NgayKham_TD.Location = new System.Drawing.Point(34, 94);
            this.lbl_NgayKham_TD.Name = "lbl_NgayKham_TD";
            this.lbl_NgayKham_TD.Size = new System.Drawing.Size(80, 16);
            this.lbl_NgayKham_TD.TabIndex = 1;
            this.lbl_NgayKham_TD.Text = "Ngày Khám:";
            // 
            // lbl_HoVaTen_TD
            // 
            this.lbl_HoVaTen_TD.AutoSize = true;
            this.lbl_HoVaTen_TD.Location = new System.Drawing.Point(34, 47);
            this.lbl_HoVaTen_TD.Name = "lbl_HoVaTen_TD";
            this.lbl_HoVaTen_TD.Size = new System.Drawing.Size(67, 16);
            this.lbl_HoVaTen_TD.TabIndex = 0;
            this.lbl_HoVaTen_TD.Text = "Họ và tên:";
            // 
            // lbl_dsThuoc
            // 
            this.lbl_dsThuoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dsThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsThuoc.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_dsThuoc.Location = new System.Drawing.Point(385, 318);
            this.lbl_dsThuoc.Name = "lbl_dsThuoc";
            this.lbl_dsThuoc.Size = new System.Drawing.Size(148, 20);
            this.lbl_dsThuoc.TabIndex = 2;
            this.lbl_dsThuoc.Text = "DANH SÁCH THUỐC";
            // 
            // dgv_dsThuoc
            // 
            this.dgv_dsThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsThuoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_dsThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Thuoc,
            this.SoLuong,
            this.CachDung});
            this.dgv_dsThuoc.Location = new System.Drawing.Point(143, 362);
            this.dgv_dsThuoc.Name = "dgv_dsThuoc";
            this.dgv_dsThuoc.RowHeadersVisible = false;
            this.dgv_dsThuoc.RowHeadersWidth = 57;
            this.dgv_dsThuoc.RowTemplate.Height = 24;
            this.dgv_dsThuoc.Size = new System.Drawing.Size(619, 150);
            this.dgv_dsThuoc.TabIndex = 4;
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BorderThickness = 1;
            this.btn_Xuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xuat.FillColor = System.Drawing.Color.LightGray;
            this.btn_Xuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xuat.ForeColor = System.Drawing.Color.Black;
            this.btn_Xuat.Location = new System.Drawing.Point(796, 467);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(98, 45);
            this.btn_Xuat.TabIndex = 5;
            this.btn_Xuat.Text = "Xuất";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 7;
            this.STT.Name = "STT";
            // 
            // Thuoc
            // 
            this.Thuoc.HeaderText = "Thuốc";
            this.Thuoc.MinimumWidth = 7;
            this.Thuoc.Name = "Thuoc";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 7;
            this.SoLuong.Name = "SoLuong";
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.MinimumWidth = 7;
            this.CachDung.Name = "CachDung";
            // 
            // HoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.dgv_dsThuoc);
            this.Controls.Add(this.lbl_dsThuoc);
            this.Controls.Add(this.gbx_Hoadon);
            this.Controls.Add(this.lbl_Hoadonthanhtoan);
            this.Name = "HoaDonThanhToan";
            this.Size = new System.Drawing.Size(948, 639);
            this.gbx_Hoadon.ResumeLayout(false);
            this.gbx_Hoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbl_Hoadonthanhtoan;
        private System.Windows.Forms.GroupBox gbx_Hoadon;
        private System.Windows.Forms.Label lbl_NgayKham_TD;
        private System.Windows.Forms.Label lbl_HoVaTen_TD;
        private System.Windows.Forms.Label lbl_TongTien_TD;
        private System.Windows.Forms.Label lbl_TienThuoc_TD;
        private System.Windows.Forms.Label lbl_TenKham_TD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dsThuoc;
        private System.Windows.Forms.DataGridView dgv_dsThuoc;
        private Guna.UI2.WinForms.Guna2Button btn_Xuat;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_TienThuoc;
        private System.Windows.Forms.Label lbl_TienKham;
        private System.Windows.Forms.Label lbl_NgayKham;
        private System.Windows.Forms.Label lbl_HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
    }
}
