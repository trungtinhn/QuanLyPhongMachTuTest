namespace QuanLyPhongMachTu.UserControls
{
    partial class uBaoCaoSDThuoc
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
            this.dgv_baocao = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_NgayThang = new System.Windows.Forms.Label();
            this.lb_Baocaodoanhthu = new System.Windows.Forms.Label();
            this.dtp_thangnam = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_baocao
            // 
            this.dgv_baocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_baocao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Thuoc,
            this.DonViTinh,
            this.SoLuong,
            this.SoLanDung});
            this.dgv_baocao.Location = new System.Drawing.Point(208, 238);
            this.dgv_baocao.Name = "dgv_baocao";
            this.dgv_baocao.RowHeadersVisible = false;
            this.dgv_baocao.RowHeadersWidth = 57;
            this.dgv_baocao.RowTemplate.Height = 24;
            this.dgv_baocao.Size = new System.Drawing.Size(767, 150);
            this.dgv_baocao.TabIndex = 7;
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
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn Vị ";
            this.DonViTinh.MinimumWidth = 7;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 7;
            this.SoLuong.Name = "SoLuong";
            // 
            // SoLanDung
            // 
            this.SoLanDung.HeaderText = "Số Lần Dùng";
            this.SoLanDung.MinimumWidth = 7;
            this.SoLanDung.Name = "SoLanDung";
            // 
            // lbl_NgayThang
            // 
            this.lbl_NgayThang.AutoSize = true;
            this.lbl_NgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayThang.Location = new System.Drawing.Point(438, 177);
            this.lbl_NgayThang.Name = "lbl_NgayThang";
            this.lbl_NgayThang.Size = new System.Drawing.Size(54, 18);
            this.lbl_NgayThang.TabIndex = 6;
            this.lbl_NgayThang.Text = "Tháng";
            // 
            // lb_Baocaodoanhthu
            // 
            this.lb_Baocaodoanhthu.AutoSize = true;
            this.lb_Baocaodoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Baocaodoanhthu.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_Baocaodoanhthu.Location = new System.Drawing.Point(435, 109);
            this.lb_Baocaodoanhthu.Name = "lb_Baocaodoanhthu";
            this.lb_Baocaodoanhthu.Size = new System.Drawing.Size(335, 31);
            this.lb_Baocaodoanhthu.TabIndex = 5;
            this.lb_Baocaodoanhthu.Text = "Báo Cáo Sử Dụng Thuốc";
            // 
            // dtp_thangnam
            // 
            this.dtp_thangnam.Checked = true;
            this.dtp_thangnam.CustomFormat = "MM-yyyy";
            this.dtp_thangnam.FillColor = System.Drawing.Color.Wheat;
            this.dtp_thangnam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_thangnam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thangnam.Location = new System.Drawing.Point(519, 168);
            this.dtp_thangnam.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_thangnam.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_thangnam.Name = "dtp_thangnam";
            this.dtp_thangnam.Size = new System.Drawing.Size(137, 36);
            this.dtp_thangnam.TabIndex = 8;
            this.dtp_thangnam.TextTransform = Siticone.Desktop.UI.WinForms.Enums.TextTransform.LowerCase;
            this.dtp_thangnam.Value = new System.DateTime(2023, 6, 12, 2, 5, 30, 39);
            // 
            // uBaoCaoSDThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.dgv_baocao);
            this.Controls.Add(this.lbl_NgayThang);
            this.Controls.Add(this.lb_Baocaodoanhthu);
            this.Controls.Add(this.dtp_thangnam);
            this.Name = "uBaoCaoSDThuoc";
            this.Size = new System.Drawing.Size(1206, 507);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_baocao;
        private System.Windows.Forms.Label lbl_NgayThang;
        private System.Windows.Forms.Label lb_Baocaodoanhthu;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtp_thangnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanDung;
    }
}
