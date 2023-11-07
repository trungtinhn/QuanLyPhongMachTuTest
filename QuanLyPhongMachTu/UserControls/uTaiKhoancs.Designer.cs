namespace QuanLyPhongMachTu.UserControls
{
    partial class uTaiKhoancs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_loggout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_NhomND_TD = new System.Windows.Forms.Label();
            this.lbl_MaNd_TD = new System.Windows.Forms.Label();
            this.lbl_Hoten_TD = new System.Windows.Forms.Label();
            this.lbl_Ngaysinh_TD = new System.Windows.Forms.Label();
            this.lbl_Chucvu_TD = new System.Windows.Forms.Label();
            this.lbl_TenDN_TD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Chinhsua = new System.Windows.Forms.Button();
            this.lbl_Thongtinnguoidung = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Job = new System.Windows.Forms.Label();
            this.lbl_Delete = new System.Windows.Forms.Label();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.pbx_Avatar = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_rgt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.btn_loggout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableLayoutPanel);
            this.panel1.Controls.Add(this.btn_Chinhsua);
            this.panel1.Controls.Add(this.lbl_Thongtinnguoidung);
            this.panel1.Location = new System.Drawing.Point(279, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 440);
            this.panel1.TabIndex = 1;
            // 
            // btn_loggout
            // 
            this.btn_loggout.BackColor = System.Drawing.Color.Chocolate;
            this.btn_loggout.Location = new System.Drawing.Point(323, 375);
            this.btn_loggout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loggout.Name = "btn_loggout";
            this.btn_loggout.Size = new System.Drawing.Size(83, 35);
            this.btn_loggout.TabIndex = 93;
            this.btn_loggout.Text = "ĐĂNG XUẤT";
            this.btn_loggout.UseVisualStyleBackColor = false;
            this.btn_loggout.Click += new System.EventHandler(this.btn_loggout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(85, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 92;
            this.button1.Text = "ĐỔI MẬT KHẨU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.lbl_NhomND_TD, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_MaNd_TD, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_Hoten_TD, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_Ngaysinh_TD, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lbl_Chucvu_TD, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lbl_TenDN_TD, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel.Location = new System.Drawing.Point(85, 113);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(321, 246);
            this.tableLayoutPanel.TabIndex = 91;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // lbl_NhomND_TD
            // 
            this.lbl_NhomND_TD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NhomND_TD.AutoSize = true;
            this.lbl_NhomND_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhomND_TD.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_NhomND_TD.Location = new System.Drawing.Point(3, 41);
            this.lbl_NhomND_TD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NhomND_TD.Name = "lbl_NhomND_TD";
            this.lbl_NhomND_TD.Size = new System.Drawing.Size(155, 39);
            this.lbl_NhomND_TD.TabIndex = 1;
            this.lbl_NhomND_TD.Text = "Số Điện Thoại";
            this.lbl_NhomND_TD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MaNd_TD
            // 
            this.lbl_MaNd_TD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MaNd_TD.AutoSize = true;
            this.lbl_MaNd_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNd_TD.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_MaNd_TD.Location = new System.Drawing.Point(3, 1);
            this.lbl_MaNd_TD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaNd_TD.Name = "lbl_MaNd_TD";
            this.lbl_MaNd_TD.Size = new System.Drawing.Size(155, 39);
            this.lbl_MaNd_TD.TabIndex = 0;
            this.lbl_MaNd_TD.Text = "Mã Người Dùng";
            this.lbl_MaNd_TD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Hoten_TD
            // 
            this.lbl_Hoten_TD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hoten_TD.AutoSize = true;
            this.lbl_Hoten_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoten_TD.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Hoten_TD.Location = new System.Drawing.Point(3, 81);
            this.lbl_Hoten_TD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Hoten_TD.Name = "lbl_Hoten_TD";
            this.lbl_Hoten_TD.Size = new System.Drawing.Size(155, 39);
            this.lbl_Hoten_TD.TabIndex = 2;
            this.lbl_Hoten_TD.Text = "Họ Tên";
            this.lbl_Hoten_TD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Ngaysinh_TD
            // 
            this.lbl_Ngaysinh_TD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Ngaysinh_TD.AutoSize = true;
            this.lbl_Ngaysinh_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngaysinh_TD.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Ngaysinh_TD.Location = new System.Drawing.Point(3, 121);
            this.lbl_Ngaysinh_TD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ngaysinh_TD.Name = "lbl_Ngaysinh_TD";
            this.lbl_Ngaysinh_TD.Size = new System.Drawing.Size(155, 39);
            this.lbl_Ngaysinh_TD.TabIndex = 3;
            this.lbl_Ngaysinh_TD.Text = "Ngày Sinh";
            this.lbl_Ngaysinh_TD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chucvu_TD
            // 
            this.lbl_Chucvu_TD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Chucvu_TD.AutoSize = true;
            this.lbl_Chucvu_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chucvu_TD.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Chucvu_TD.Location = new System.Drawing.Point(3, 161);
            this.lbl_Chucvu_TD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Chucvu_TD.Name = "lbl_Chucvu_TD";
            this.lbl_Chucvu_TD.Size = new System.Drawing.Size(155, 39);
            this.lbl_Chucvu_TD.TabIndex = 4;
            this.lbl_Chucvu_TD.Text = "Chức Vụ";
            this.lbl_Chucvu_TD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TenDN_TD
            // 
            this.lbl_TenDN_TD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenDN_TD.AutoSize = true;
            this.lbl_TenDN_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDN_TD.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_TenDN_TD.Location = new System.Drawing.Point(3, 201);
            this.lbl_TenDN_TD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenDN_TD.Name = "lbl_TenDN_TD";
            this.lbl_TenDN_TD.Size = new System.Drawing.Size(155, 44);
            this.lbl_TenDN_TD.TabIndex = 5;
            this.lbl_TenDN_TD.Text = "Địa chỉ";
            this.lbl_TenDN_TD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(163, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(163, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(163, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 39);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(163, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 39);
            this.label4.TabIndex = 9;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(163, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 39);
            this.label5.TabIndex = 10;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(163, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 44);
            this.label6.TabIndex = 11;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Chinhsua
            // 
            this.btn_Chinhsua.BackColor = System.Drawing.Color.Chocolate;
            this.btn_Chinhsua.Location = new System.Drawing.Point(204, 375);
            this.btn_Chinhsua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Chinhsua.Name = "btn_Chinhsua";
            this.btn_Chinhsua.Size = new System.Drawing.Size(83, 35);
            this.btn_Chinhsua.TabIndex = 90;
            this.btn_Chinhsua.Text = "CHỈNH SỬA";
            this.btn_Chinhsua.UseVisualStyleBackColor = false;
            this.btn_Chinhsua.Click += new System.EventHandler(this.btn_Chinhsua_Click);
            // 
            // lbl_Thongtinnguoidung
            // 
            this.lbl_Thongtinnguoidung.AutoSize = true;
            this.lbl_Thongtinnguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thongtinnguoidung.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Thongtinnguoidung.Location = new System.Drawing.Point(79, 51);
            this.lbl_Thongtinnguoidung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Thongtinnguoidung.Name = "lbl_Thongtinnguoidung";
            this.lbl_Thongtinnguoidung.Size = new System.Drawing.Size(315, 29);
            this.lbl_Thongtinnguoidung.TabIndex = 0;
            this.lbl_Thongtinnguoidung.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(430, 103);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(151, 27);
            this.lbl_Name.TabIndex = 4;
            // 
            // lbl_Job
            // 
            this.lbl_Job.AutoSize = true;
            this.lbl_Job.Location = new System.Drawing.Point(431, 80);
            this.lbl_Job.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Job.Name = "lbl_Job";
            this.lbl_Job.Size = new System.Drawing.Size(0, 13);
            this.lbl_Job.TabIndex = 5;
            // 
            // lbl_Delete
            // 
            this.lbl_Delete.AutoSize = true;
            this.lbl_Delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Delete.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete.Location = new System.Drawing.Point(624, 117);
            this.lbl_Delete.Name = "lbl_Delete";
            this.lbl_Delete.Size = new System.Drawing.Size(137, 19);
            this.lbl_Delete.TabIndex = 6;
            this.lbl_Delete.Text = "XÓA ẢNH ĐẠI DIỆN";
            this.lbl_Delete.Click += new System.EventHandler(this.lbl_Delete_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = global::QuanLyPhongMachTu.Properties.Resources.change;
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(388, 117);
            this.siticoneCirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(28, 25);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 3;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.Click += new System.EventHandler(this.siticoneCirclePictureBox1_Click);
            // 
            // pbx_Avatar
            // 
            this.pbx_Avatar.Image = global::QuanLyPhongMachTu.Properties.Resources.boy;
            this.pbx_Avatar.Location = new System.Drawing.Point(307, 30);
            this.pbx_Avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_Avatar.Name = "pbx_Avatar";
            this.pbx_Avatar.Size = new System.Drawing.Size(100, 100);
            this.pbx_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Avatar.TabIndex = 2;
            this.pbx_Avatar.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(803, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 94;
            this.button2.Text = "CẬP NHẬT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_rgt
            // 
            this.btn_rgt.BackColor = System.Drawing.Color.Chocolate;
            this.btn_rgt.Location = new System.Drawing.Point(803, 552);
            this.btn_rgt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rgt.Name = "btn_rgt";
            this.btn_rgt.Size = new System.Drawing.Size(118, 35);
            this.btn_rgt.TabIndex = 94;
            this.btn_rgt.Text = "ĐĂNG KÝ";
            this.btn_rgt.UseVisualStyleBackColor = false;
            this.btn_rgt.Click += new System.EventHandler(this.btn_rgt_Click);
            // 
            // uTaiKhoancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.btn_rgt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_Delete);
            this.Controls.Add(this.lbl_Job);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.siticoneCirclePictureBox1);
            this.Controls.Add(this.pbx_Avatar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uTaiKhoancs";
            this.Size = new System.Drawing.Size(987, 662);
            this.Load += new System.EventHandler(this.uTaiKhoancs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Chinhsua;
        private System.Windows.Forms.Label lbl_Thongtinnguoidung;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lbl_NhomND_TD;
        private System.Windows.Forms.Label lbl_MaNd_TD;
        private System.Windows.Forms.Label lbl_Hoten_TD;
        private System.Windows.Forms.Label lbl_Ngaysinh_TD;
        private System.Windows.Forms.Label lbl_Chucvu_TD;
        private System.Windows.Forms.Label lbl_TenDN_TD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbx_Avatar;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Job;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Delete;
        private System.Windows.Forms.Button btn_loggout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_rgt;
    }
}
