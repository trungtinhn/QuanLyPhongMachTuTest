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
    
    public partial class DanhSachKhamBenh : UserControl
    {
        BLL_BENHNHAN dBenhNhanBLL;
        BLL_DANGKY dDangKyBLL;
        BLL_HOADON dHoaDonBLL;
        BLL_PHIEUKHAMBENH dPhieuKhamBenhBLL;

        public DanhSachKhamBenh()
        {
            InitializeComponent();
            dBenhNhanBLL = new BLL_BENHNHAN();
            dDangKyBLL = new BLL_DANGKY();
            dHoaDonBLL = new BLL_HOADON();
            dPhieuKhamBenhBLL = new BLL_PHIEUKHAMBENH();
        }

        private void DanhSachKhamBenh_Load(object sender, EventArgs e)
        {

            HienThiLenDGVBenhNhan();
            HienThiDanhSachHoaDon();
            HienThiSoNguoiConLaiDangKy();

            dtimeNgaySinh.Format = DateTimePickerFormat.Custom;
            dtimeNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void HienThiLenDGVBenhNhan()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");

            dBenhNhanBLL = new BLL_BENHNHAN();
            List<BENHNHAN> benhNhans = dBenhNhanBLL.LayDanhSachBenhNhan(cboTraCuu.Text, txtTraCuu.Text, dtimeTraCuu.Value);

            foreach (BENHNHAN benhNhan in benhNhans)
            {
                DateTime date = (DateTime)benhNhan.NgaySinh;
                dt.Rows.Add(benhNhan.MaBenhNhan, benhNhan.HoTenBenhNhan, benhNhan.GioiTinh, date.ToString("dd/MM/yyyy"), benhNhan.DiaChi);
            }

            dgvThongTinBN.DataSource = dt;
        }

        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrEmpty(txtHotenBN.Text) || string.IsNullOrEmpty(txtDiachiBN.Text))
            {
                return false;
            }else if (!radNam.Checked && !radNu.Checked)
            {
                return false;
            }
            return true;
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {

            if (!KiemTraNhapLieu())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            BENHNHAN benhNhan = new BENHNHAN();
            benhNhan.HoTenBenhNhan = txtHotenBN.Text;
            if (radNam.Checked)
            {
                benhNhan.GioiTinh = "Nam";
            }
            else
            {
                benhNhan.GioiTinh = "Nữ";
            }
            benhNhan.NgaySinh = dtimeNgaySinh.Value;
            benhNhan.DiaChi = txtDiachiBN.Text;
            dBenhNhanBLL = new BLL_BENHNHAN();

            if (dBenhNhanBLL.ThemBenhNhan(benhNhan))
            {
                MessageBox.Show("Thêm bệnh nhân thành công!");
                HienThiLenDGVBenhNhan();
            }
            else
            {
                MessageBox.Show("Thêm bệnh nhân thất bại!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (!KiemTraNhapLieu())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            BENHNHAN benhNhan = new BENHNHAN();
            benhNhan.HoTenBenhNhan = txtHotenBN.Text;
            if (radNam.Checked)
            {
                benhNhan.GioiTinh = "Nam";
            }
            else
            {
                benhNhan.GioiTinh = "Nữ";
            }
            benhNhan.NgaySinh = dtimeNgaySinh.Value;
            benhNhan.DiaChi = txtDiachiBN.Text;
            benhNhan.MaBenhNhan = txtMaBN.Text;
            dBenhNhanBLL = new BLL_BENHNHAN();

            if (dBenhNhanBLL.CapNhatBenhNhan(benhNhan))
            {
                MessageBox.Show("Cập nhật bệnh nhân thành công!");
                HienThiLenDGVBenhNhan();
            }
            else
            {
                MessageBox.Show("Cập nhật bệnh nhân thất bại!");
            }
        }

        private void dgvThongTinBN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinBN.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvThongTinBN.SelectedRows[0];


                txtMaBN.Text = row.Cells[0].Value.ToString();
                txtHotenBN.Text = row.Cells[1].Value.ToString();

                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }

                //dtimeNgaySinh.Value = (DateTime) row.Cells[3].Value;
                txtDiachiBN.Text = row.Cells[4].Value.ToString();
            }
            HienThiDanhSachHoaDon();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BENHNHAN benhNhan = new BENHNHAN();
            benhNhan.HoTenBenhNhan = txtHotenBN.Text;
            if (radNam.Checked)
            {
                benhNhan.GioiTinh = "Nam";
            }
            else
            {
                benhNhan.GioiTinh = "Nữ";
            }
            benhNhan.NgaySinh = dtimeNgaySinh.Value;
            benhNhan.DiaChi = txtDiachiBN.Text;
            benhNhan.MaBenhNhan = txtMaBN.Text;

            dBenhNhanBLL = new BLL_BENHNHAN();
           

            if (dBenhNhanBLL.XoaBenhNhan(benhNhan))
            {
                MessageBox.Show("Xóa bệnh nhân thành công!");
                HienThiLenDGVBenhNhan();
            }
            else
            {
                MessageBox.Show("Xóa bệnh nhân thất bại!");
            }
        }
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = "";
            txtHotenBN.Text = "";
            radNam.Checked = false;
            radNam.Checked = false;
            DateTime dateTime = DateTime.Now;
            dtimeNgaySinh.Value = dateTime;
            txtDiachiBN.Text = "";
        }

        private bool KiemTraNhapLieuDK()
        {
            if (string.IsNullOrEmpty(txtMaBNDK.Text))
            {
                return false;
            }
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuDK())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            DANGKY dangKy = new DANGKY();

            dBenhNhanBLL = new BLL_BENHNHAN();
            dDangKyBLL = new BLL_DANGKY();
           

            BENHNHAN bn = dBenhNhanBLL.LayThongTinBenhNhan(txtMaBNDK.Text);

            if (bn == null)
            {
                MessageBox.Show("Không tồn tại mã bệnh nhân!");
                return;
            }

            dangKy.NgayDangKy = dtimeNgayDK.Value;
            dangKy.idMaBenhNhan = bn.id;

            if (dDangKyBLL.DangKyKhamBenh(dangKy))
            {
                MessageBox.Show("Đăng ký khám bệnh thành công!");
                HienThiSoNguoiConLaiDangKy();

            }
            else
            {
                MessageBox.Show("Đăng ký khám bệnh thất bại!");
            }
        }

        public void HienThiSoNguoiConLaiDangKy()
        {
            int soNguoi = dDangKyBLL.LaySoBenhNhanTiepNhan();
            txtSoBNtiepnhan.Text = soNguoi.ToString();
        }

        public void HienThiDanhSachHoaDon()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT");
            dt.Columns.Add("Số PKB");
            dt.Columns.Add("Ngày khám");
            dt.Columns.Add("Tổng tiền");
            dt.Columns.Add("Trạng thái");
            if (string.IsNullOrEmpty(txtMaBN.Text))
            {
                return;
            }
            dBenhNhanBLL = new BLL_BENHNHAN();
           
            dHoaDonBLL = new BLL_HOADON();
            BENHNHAN benhNhan = dBenhNhanBLL.LayThongTinBenhNhan(txtMaBN.Text);

            dHoaDonBLL = new BLL_HOADON();
            if (benhNhan == null )return;
            
            List<HOADON> hoaDons = dHoaDonBLL.LayDanhSachHoaDon(benhNhan.id);
            int i = 0;
            foreach (HOADON hOADON in hoaDons)
            {
                i++;
                PHIEUKHAMBENH pkb = dPhieuKhamBenhBLL.LayPhieuKhamBenh(hOADON.SoPhieuKhamBenh.Value);

                dt.Rows.Add(i, hOADON.SoPhieuKhamBenh, pkb.NgayKham, hOADON.TienKham + hOADON.TienThuoc, hOADON.TrangThai);

            }

            dgvDanhSachHoaDon.DataSource = dt;

            dgvDanhSachHoaDon.Columns[0].Width = (int)(dgvDanhSachHoaDon.Width * 0.1);
            dgvDanhSachHoaDon.Columns[1].Width = (int)(dgvDanhSachHoaDon.Width * 0.1);
            dgvDanhSachHoaDon.Columns[2].Width = (int)(dgvDanhSachHoaDon.Width * 0.2);
            dgvDanhSachHoaDon.Columns[3].Width = (int)(dgvDanhSachHoaDon.Width * 0.2);
            dgvDanhSachHoaDon.Columns[4].Width = (int)(dgvDanhSachHoaDon.Width * 0.3);
        }

        private void dgvDanhSachHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDanhSachHoaDon.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgvDanhSachHoaDon.SelectedRows[0];

                if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {

                    HOADON hoaDon = dHoaDonBLL.LayHoaDon(Int32.Parse(row.Cells[1].Value.ToString()));

                    fHoaDon fhd = new fHoaDon(hoaDon);

                    fhd.Show();
                }

            }
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            HienThiLenDGVBenhNhan();
        }

        private void cboTraCuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTraCuu.Text == "Ngày sinh")
            {
                dtimeTraCuu.Visible = true;
                txtTraCuu.Visible = false;
            }
            else
            {
                dtimeTraCuu.Visible = false;
                txtTraCuu.Visible = true;
            }
        }
    }
}