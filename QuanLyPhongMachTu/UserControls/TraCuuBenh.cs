using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMachTu.UserControls
{
    public partial class TraCuuBenh : UserControl
    {
        BLL_LOAIBENH dLoaiBenhBLL;
        BLL_BENH dBenhBLL;
        BLL_LOAITHUOC dLoaiThuocBLL;
        BLL_THUOC dThuocBLL;
        public TraCuuBenh()
        {
            InitializeComponent();
            dLoaiBenhBLL = new BLL_LOAIBENH();
            dBenhBLL = new BLL_BENH();
            dThuocBLL = new BLL_THUOC();
            dLoaiThuocBLL = new BLL_LOAITHUOC();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuBenh_Click(object sender, EventArgs e)
        {

        }

        private void TraCuuBenh_Load(object sender, EventArgs e)
        {
            HienThiThongTinLoaiBenh();
            HienThiThongTinBenh();
            HienThiComboBoxLoaiBenh();
            HienThiComboBoxLoaiThuoc();
        }

        public void HienThiThongTinLoaiBenh()
        {
            string kieuLoc = cboTraCuuLoaiBenh.Text;
            string giaTri = txtTraCuuLoaiBenh.Text;

            List<LOAIBENH> loaiBenhs = dLoaiBenhBLL.LayDanhSachLoaiBenh(kieuLoc, giaTri);

            var dt = new DataTable();

            dt.Columns.Add("STT");
            dt.Columns.Add("Mã loại bệnh");
            dt.Columns.Add("Tên loại bệnh");

            int i = 0;

            foreach (LOAIBENH lb in loaiBenhs)
            {
                i++;
                dt.Rows.Add(i, lb.MaLoaiBenh, lb.TenLoaiBenh);
            }

            dgvLoaiBenh.DataSource = dt;


            dgvLoaiBenh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiBenh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiBenh.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLoaiBenh.Columns[0].Width = (int)(dgvLoaiBenh.Width * 0.2);
            dgvLoaiBenh.Columns[1].Width = (int)(dgvLoaiBenh.Width * 0.3);
            dgvLoaiBenh.Columns[2].Width = (int)(dgvLoaiBenh.Width * 0.5);
        }

        public void HienThiThongTinBenh()
        {
            dgvBenh.DataSource = null;
            var dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã bệnh");
            dt.Columns.Add("Tên bệnh");
            dt.Columns.Add("Triệu chứng");
            dt.Columns.Add("Thuốc đặc trị");
            dt.Columns.Add("Tên loại bệnh");

            string kieuLoc = cboTraCuuBenh.Text;
            string giaTri = txtTraCuuBenh.Text;

            List<BENH> benhs = dBenhBLL.LocBenh(kieuLoc, giaTri);

            int i = 0;
            foreach (BENH benh in benhs)
            {
                i++;
                string tenLoaiBenh = dLoaiBenhBLL.LayTenLoaiBenh(benh.idMaLoaiBenh);

                THUOC thuoc = dThuocBLL.LayTenThuoc(benh.idMaThuocDacTri);

                dt.Rows.Add(i, benh.MaBenh, benh.TenBenh, benh.TrieuChung, thuoc.TenThuoc, tenLoaiBenh);
            }

            dgvBenh.DataSource = dt;

            dgvBenh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBenh.Columns[0].Width = (int)(dgvLoaiBenh.Width * 0.05);
            dgvBenh.Columns[1].Width = (int)(dgvLoaiBenh.Width * 0.1);
            dgvBenh.Columns[2].Width = (int)(dgvLoaiBenh.Width * 0.1);
            dgvBenh.Columns[3].Width = (int)(dgvLoaiBenh.Width * 0.3);
            dgvBenh.Columns[4].Width = (int)(dgvLoaiBenh.Width * 0.2);
            dgvBenh.Columns[5].Width = (int)(dgvLoaiBenh.Width * 0.3);



        }

        private bool KiemTraNhapLieuLoaiBenh()
        {
            if (string.IsNullOrEmpty(txtTenLoaiBenh.Text))
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuLoaiBenh())
            {
                MessageBox.Show("Vui lòng cùng cấp tên loại bệnh!");
                return;
            }

            LOAIBENH loaiBenh = new LOAIBENH();
            loaiBenh.TenLoaiBenh = txtTenLoaiBenh.Text;

            if (dLoaiBenhBLL.ThemLoaiBenh(loaiBenh))
            {
                MessageBox.Show("Thêm loại bệnh thành công!");
                HienThiThongTinLoaiBenh();
            }
            else
            {
                MessageBox.Show("Thêm loại bệnh thất bại!");
            }
        }

        private void btnCapNhatLoaiBenh_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuLoaiBenh())
            {
                MessageBox.Show("Vui lòng cùng cấp tên loại bệnh!");
                return;
            }

            LOAIBENH loaiBenh = new LOAIBENH();
            loaiBenh.MaLoaiBenh = txtMaLoaiBenh.Text;
            loaiBenh.TenLoaiBenh = txtTenLoaiBenh.Text;

            if (dLoaiBenhBLL.CapNhatLoaiBenh(loaiBenh))
            {
                MessageBox.Show("Cập nhật loại bệnh thành công!");
                HienThiThongTinLoaiBenh();
            }
            else
            {
                MessageBox.Show("Cập nhật loại bệnh thất bại!");
            }
        }

        private void dgvLoaiBenh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiBenh.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLoaiBenh.SelectedRows[0];

                txtMaLoaiBenh.Text = row.Cells[1].Value.ToString();
                txtTenLoaiBenh.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            txtMaLoaiBenh.Text = "";
            txtTenLoaiBenh.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LOAIBENH loaiBenh = new LOAIBENH();
            loaiBenh.MaLoaiBenh = txtMaLoaiBenh.Text;
            loaiBenh.TenLoaiBenh = txtTenLoaiBenh.Text;

            if (dLoaiBenhBLL.XoaLoaiBenh(loaiBenh))
            {
                MessageBox.Show("Xóa loại bệnh thành công!");
                HienThiThongTinLoaiBenh();
                HienThiThongTinBenh();
            }
            else
            {
                MessageBox.Show("Xóa loại bệnh thất bại!");
            }
        }

        private void HienThiComboBoxLoaiBenh()
        {
            cboTenLoaiBenh.DataSource = dLoaiBenhBLL.LayDanhSachLoaiBenh("Tất cả", "Mặc định");
            cboTenLoaiBenh.DisplayMember = "TenLoaiBenh";
            cboTenLoaiBenh.ValueMember = "MaLoaiBenh";
        }
        public void HienThiComboBoxLoaiThuoc()
        {
            cboTenLoaiThuoc.DataSource = dLoaiThuocBLL.LayDanhSachLoaiThuoc();
            cboTenLoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cboTenLoaiThuoc.ValueMember = "MaLoaiThuoc";
            HienThiComboBoxThuoc();
        }
        public void HienThiComboBoxThuoc()
        {
            string maLoaiThuoc = cboTenLoaiThuoc.SelectedValue.ToString();
            LOAITHUOC loaiThuoc = dLoaiThuocBLL.LayLoaiThuoc(maLoaiThuoc);

            if (loaiThuoc == null)
            {


            }
            else
            {
                cboTenTHuoc.DataSource = dThuocBLL.LayDanhSachThuoc(loaiThuoc.id);

                if (cboTenTHuoc.Items.Count == 0)
                {
                    cboTenTHuoc.ResetText();

                }

                cboTenTHuoc.DisplayMember = "TenThuoc";
                cboTenTHuoc.ValueMember = "MaThuoc";
            }


        }

        private void cboTenLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiComboBoxThuoc();
        }

        private void dgvBenh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBenh.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBenh.SelectedRows[0];

                txtMaBenh.Text = row.Cells[1].Value.ToString();
                txtTenBenh.Text = row.Cells[2].Value.ToString();
                txtTrieuChungBenh.Text = row.Cells[3].Value.ToString();
                cboTenTHuoc.Text = row.Cells[4].Value.ToString();
                cboTenLoaiBenh.Text = row.Cells[5].Value.ToString();

                THUOC thuoc = dThuocBLL.LayThongTinThuoc(row.Cells[4].Value.ToString());
                cboTenLoaiThuoc.Text = dLoaiThuocBLL.LayTenLoaiThuoc(thuoc.idMaLoaiThuoc);
            }
        }

        public bool KiemTraNhapLieuBenh()
        {
            if (string.IsNullOrEmpty(txtTenBenh.Text) || string.IsNullOrEmpty(txtTrieuChungBenh.Text)
                    || string.IsNullOrEmpty(cboTenTHuoc.Text) || string.IsNullOrEmpty(cboTenLoaiBenh.Text)) { return false; }
            else return true;
        }

        private void btnThemBenh_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuBenh())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            BENH benh = new BENH();
            benh.TenBenh = txtTenBenh.Text;
            benh.TrieuChung = txtTrieuChungBenh.Text;

            THUOC thuoc = dThuocBLL.LayThongTinThuoc(cboTenTHuoc.Text);
            LOAIBENH loaiBenh = dLoaiBenhBLL.LayThongTinLoaiBenh(cboTenLoaiBenh.Text);
            benh.idMaThuocDacTri = thuoc.id;
            benh.idMaLoaiBenh = loaiBenh.id;

            if (dBenhBLL.ThemBenh(benh))
            {
                MessageBox.Show("Thêm bệnh thành công!");
                HienThiThongTinBenh();
            }
            else
            {
                MessageBox.Show("Thêm bệnh thất bại!");
            }
        }

        private void btnKhongLuuBenh_Click(object sender, EventArgs e)
        {
            txtMaBenh.Text = "";
            txtTenBenh.Text = "";
            txtTrieuChungBenh.Text = "";

            HienThiComboBoxLoaiThuoc();
            HienThiComboBoxLoaiBenh();
        }

        private void btnCapNhatBenh_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuBenh())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            BENH benh = new BENH();
            benh.TenBenh = txtTenBenh.Text;
            benh.TrieuChung = txtTrieuChungBenh.Text;

            THUOC thuoc = dThuocBLL.LayThongTinThuoc(cboTenTHuoc.Text);
            LOAIBENH loaiBenh = dLoaiBenhBLL.LayThongTinLoaiBenh(cboTenLoaiBenh.Text);
            benh.idMaThuocDacTri = thuoc.id;
            benh.idMaLoaiBenh = loaiBenh.id;

            if (dBenhBLL.CapNhatBenh(benh))
            {
                MessageBox.Show("Cập nhật bệnh thành công!");
                HienThiThongTinBenh();
            }
            else
            {
                MessageBox.Show("Cập nhật bệnh thất bại!");
            }
        }

        private void btnXoaBenh_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuBenh())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            BENH benh = dBenhBLL.LayBenh(txtMaBenh.Text);

            if (dBenhBLL.XoaBenh(benh))
            {
                MessageBox.Show("Xóa bệnh thành công!");
                HienThiThongTinBenh();
            }
            else
            {
                MessageBox.Show("Xóa bệnh thất bại!");
            }
        }

        private void btnTraCuuLoaiBenh_Click(object sender, EventArgs e)
        {
            HienThiThongTinLoaiBenh();
        }

        private void btnTraCuuBenh_Click_1(object sender, EventArgs e)
        {
            HienThiThongTinBenh();
        }

    }
}
