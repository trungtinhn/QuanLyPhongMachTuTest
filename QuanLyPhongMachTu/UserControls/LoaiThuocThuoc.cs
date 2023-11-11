using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QuanLyPhongMachTu.UserControls
{
    public partial class LoaiThuocThuoc : UserControl
    {
        BLL_LOAITHUOC dLoaiThuocBLL;
        BLL_THUOC dThuocBLL;
        BLL_CACHDUNG dCachDungBLL;
        BLL_DONVI dDonViBLL;



        public LoaiThuocThuoc()
        {
            InitializeComponent();
            dLoaiThuocBLL = new BLL_LOAITHUOC();
            dThuocBLL = new BLL_THUOC();
            dDonViBLL = new BLL_DONVI();
            dCachDungBLL = new BLL_CACHDUNG();
            Load_CDcb();
            Load_DVcb();
            Load_LTcb();
        }


        //Kiem Tra du Lieu cho Loai Thuoc
        public bool KiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(txt_Tenloaithuoc.Text))
            {
                return false; // Không đủ thông tin, trả về false
            }
            return true; // Đủ thông tin, trả về true
        }

        //Kiem Tra du Lieu cho tra cuu Loai Thuoc
        public bool KiemTraNhapLieu3()
        {
            if (string.IsNullOrWhiteSpace(txt_tracuu.Text))
            {
                return false; // Không đủ thông tin, trả về false
            }
            return true; // Đủ thông tin, trả về true
        }


        // Kiem Tra Nhap Lieu cho Thuoc
        public bool KiemTraNhapLieu4()
        {
            if (string.IsNullOrWhiteSpace(txt_tracuu_thuoc.Text))
            {
                return false; // Không đủ thông tin, trả về false
            }
            return true; // Đủ thông tin, trả về true
        }

        //Kiem Tra Nha Lieu cho Thuoc
        public bool KiemTraNhapLieu2()
        {
            if (string.IsNullOrWhiteSpace(txt_Tenthuoc.Text) || string.IsNullOrWhiteSpace(txt_congdung.Text) ||
                string.IsNullOrWhiteSpace(txt_Huongdansudung.Text) || Int32.Parse(txt_dongia.Text) <= 0)
            {
                return false; // Không đủ thông tin, trả về false
            }
            return true; // Đủ thông tin, trả về true
        }

        public void HIENTHI()
        {
            dgv_dsThuoc.DataSource = null;
            HienThiThongTinDanhSachThuoc();
            dgv_Loaithuoc.DataSource = null;
            dgv_dsThuocsaphet.DataSource = null;
            HienThiDanhSachThuocSapHet();
            dgv_Loaithuoc.DataSource =  dLoaiThuocBLL.LayDanhSachLoaiThuoc();
        }



        public void HienThiThongTinDanhSachThuoc()
        {
            int selectedRowIndex = 0;
            if (dgv_dsThuoc.DataSource != null)
            {
                if (dgv_dsThuoc.SelectedRows.Count == 0)
                    selectedRowIndex = 0;
                else selectedRowIndex = dgv_dsThuoc.SelectedCells[0].RowIndex;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Tên ID");
            dt.Columns.Add("Mã Thuốc");
            dt.Columns.Add("Tên Thuốc");
            dt.Columns.Add("Loại thuốc");
            dt.Columns.Add("Cách Dùng");
            dt.Columns.Add("Đơn Vị");
            dt.Columns.Add("HDSD");
            dt.Columns.Add("Số Lượng tồn");
            dt.Columns.Add("Đơn giá bán");
            dt.Columns.Add("Công Dụng");


            List<THUOC> tHUOCs = dThuocBLL.getall();

            foreach (THUOC t in tHUOCs)
            {

                LOAITHUOC lt = dLoaiThuocBLL.getLTbyID(t.idMaLoaiThuoc);
                DONVI dv = dDonViBLL.getDVbyID(t.idMaDonVi);
                CACHDUNG cd = dCachDungBLL.getCDbyID(t.idMaCachDung);
                dt.Rows.Add(t.id, t.MaThuoc, t.TenThuoc, lt.TenLoaiThuoc, cd.TenCachDung, dv.TenDonVi, t.HuongDanSuDung, t.SoLuongTon, t.DonGia, t.CongDung);
            }

            dgv_dsThuoc.DataSource = dt;
            if (dgv_dsThuoc.Rows.Count > 0 && selectedRowIndex != -1 && selectedRowIndex < dgv_dsThuoc.Rows.Count)
            {
                dgv_dsThuoc.Rows[selectedRowIndex].Selected = true;
            }
        }


        public void HienThiDanhSachThuocSapHet()
        {
            int selectedRowIndex = 0;
            if (dgv_dsThuocsaphet.DataSource != null)
            {
                if (dgv_dsThuocsaphet.SelectedRows.Count == 0)
                    selectedRowIndex = 0;
                else selectedRowIndex = dgv_dsThuocsaphet.SelectedCells[0].RowIndex;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Tên ID");
            dt.Columns.Add("Mã Thuốc");
            dt.Columns.Add("Tên Thuốc");
            dt.Columns.Add("Loại thuốc");
            dt.Columns.Add("Số Lượng tồn");



            List<THUOC> tHUOCs = dThuocBLL.getThuocSapHet();

            foreach (THUOC t in tHUOCs)
            {

                LOAITHUOC lt = dLoaiThuocBLL.getLTbyID(t.idMaLoaiThuoc);
                dt.Rows.Add(t.id, t.MaThuoc, t.TenThuoc, lt.TenLoaiThuoc, t.SoLuongTon);
            }

            dgv_dsThuocsaphet.DataSource = dt;
            if (dgv_dsThuocsaphet.Rows.Count > 0 && selectedRowIndex != -1 && selectedRowIndex < dgv_dsThuocsaphet.Rows.Count)
            {
                dgv_dsThuocsaphet.Rows[selectedRowIndex].Selected = true;
            }
        }


        private void LoaiThuocThuoc_Load_1(object sender, EventArgs e)
        {
            HIENTHI();
        }

        // THEM CHO LOAI THUOC

        private void btn_Them_Loaithuoc_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm");
                return;
            }
            LOAITHUOC cd = new LOAITHUOC();
            if (dLoaiThuocBLL.Check(txt_Tenloaithuoc.Text) == true)
            {
                DialogResult result = MessageBox.Show("Tên Loại Thuốc đã tồn tại. Bạn có chắc chắn muốn thêm không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cd.TenLoaiThuoc = txt_Tenloaithuoc.Text;
                    if (dLoaiThuocBLL.Add(cd) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HIENTHI();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");

                    }
                }
            }
            else
            {
                cd.TenLoaiThuoc = txt_Tenloaithuoc.Text;
            }
            if (dLoaiThuocBLL.Add(cd) == true)
            {
                MessageBox.Show("Thêm thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");

            }
        }


        // CAP NHAT CHO LOAI THUOC 
        private void btn_Capnhat_Loaithuoc_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần cập nhật");
                return;
            }
            LOAITHUOC cd = new LOAITHUOC();
            cd.MaLoaiThuoc = txt_Maloaithuoc.Text;
            cd.TenLoaiThuoc = txt_Tenloaithuoc.Text;
            cd.id = int.Parse(txt_ID.Text);
            if (dLoaiThuocBLL.CapNhat(cd) == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        //XOA TRANG LOAI THUOC
        private void btn_Khongluu_Loaithuoc_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_Maloaithuoc.Text = "";
            txt_Tenloaithuoc.Text = "";
        }

        private void txt_ID_Click(object sender, EventArgs e)
        {

        }

        // CELL CLICK DGV LOAITHUOC
        private void dgv_Loaithuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Loaithuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Loaithuoc.SelectedRows[0];
                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_Maloaithuoc.Text = row.Cells[1].Value.ToString();
                txt_Tenloaithuoc.Text = row.Cells[2].Value.ToString();
            }
        }


        // XOA LOAI THUOC
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần xóa");
                return;
            }
            LOAITHUOC cd = new LOAITHUOC();
            cd.id = int.Parse(txt_ID.Text);
            if (dLoaiThuocBLL.Xoa(cd) == true)
            {
                MessageBox.Show("Xóa thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }


        //TRA CUU LOAI THUOC
        private void btn_Tracuu_Loaithuoc_Click_1(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu3() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                return;
            }
            LOAITHUOC cd = new LOAITHUOC();
            cd.MaLoaiThuoc =txt_tracuu.Text;
            if (dLoaiThuocBLL.TracuuCD(cd) == true)
            {
                var rowIndex = -1;
                for (int i = 0; i < dgv_Loaithuoc.Rows.Count; i++)
                {
                    if (dgv_Loaithuoc.Rows[i].Cells[1].Value.ToString() == cd.MaLoaiThuoc)
                    {
                        rowIndex = i;
                        break;
                    }
                }

                if (cd != null && rowIndex >= 0)
                {

                    // Cuộn đến dòng tìm thấy va tro
                    dgv_Loaithuoc.FirstDisplayedScrollingRowIndex = rowIndex;
                    dgv_Loaithuoc.CurrentCell = dgv_Loaithuoc.Rows[rowIndex].Cells[0];
                }
                else
                {
                    MessageBox.Show("Thất bại! Không tìm thấy");
                }
            }
        }

        // TRA CUU THUOC 
        private void btn_Tracuu_Thuoc_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu4() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                return;
            }
            THUOC cd = new THUOC();
            cd.MaThuoc = txt_tracuu_thuoc.Text;
            if (dThuocBLL.TracuuCD(cd) == true)
            {
                var rowIndex = -1;
                for (int i = 0; i < dgv_dsThuoc.Rows.Count; i++)
                {
                    if (dgv_dsThuoc.Rows[i].Cells[1].Value.ToString() == cd.MaThuoc)
                    {
                        rowIndex = i;
                        break;
                    }
                }

                if (cd != null && rowIndex >= 0)
                {

                    // Cuộn đến dòng tìm thấy va tro
                    dgv_dsThuoc.FirstDisplayedScrollingRowIndex = rowIndex;
                    dgv_dsThuoc.CurrentCell =dgv_dsThuoc.Rows[rowIndex].Cells[0];
                }
                else
                {
                    MessageBox.Show("Thất bại! Không tìm thấy");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //TRA CUU THUOC 

        private void btn_Capnhap_Thuoc_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu2() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần cập nhật");
                return;
            }

            THUOC cd = new THUOC();
            LOAITHUOC tHUOC = dLoaiThuocBLL.GetbyTen(cbb_Tenloaithuoc.Text);
            CACHDUNG cdung = dCachDungBLL.GetByTen(cb_CachDung.Text);
            DONVI dONVI = dDonViBLL.GetByTen(cbb_Tendonvi.Text);
            cd.id = int.Parse(id.Text);
            cd.TenThuoc = txt_Tenthuoc.Text;
            cd.idMaLoaiThuoc = tHUOC.id;
            cd.idMaCachDung = cdung.id;
            cd.idMaDonVi = dONVI.id;
            cd.DonGia = int.Parse(txt_dongia.Text);
            cd.CongDung = txt_congdung.Text;
            cd.HuongDanSuDung = txt_Huongdansudung.Text;
            if (dThuocBLL.CapNhat(cd) == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        // THEM THUOC

        private void btn_Them_Thuoc_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu2() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm");
                return;
            }
            THUOC cd = new THUOC();
            LOAITHUOC tHUOC = dLoaiThuocBLL.GetbyTen(cbb_Tenloaithuoc.Text);
            CACHDUNG cdung = dCachDungBLL.GetByTen(cb_CachDung.Text);
            DONVI dONVI = dDonViBLL.GetByTen(cbb_Tendonvi.Text);
            cd.TenThuoc = txt_Tenthuoc.Text;
            cd.idMaLoaiThuoc = tHUOC.id;
            cd.idMaCachDung = cdung.id;
            cd.idMaDonVi = dONVI.id;
            cd.DonGia = int.Parse(txt_dongia.Text);
            cd.CongDung = txt_congdung.Text;
            cd.HuongDanSuDung = txt_Huongdansudung.Text;
            if (dThuocBLL.Add(cd) == true)
            {
                MessageBox.Show("Thêm thành công!");
                HIENTHI();
                return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");

            }
        }




        private void txt_tracuu_TextChanged(object sender, EventArgs e)
        {

        }



        //XOA TRang THUOC 
        private void btn_Khongluu_Thuoc_Click(object sender, EventArgs e)
        {

            id.Text = "";
            txt_Mathuoc.Text= "";
            txt_Tenloaithuoc.Text = "";
            txt_Tenthuoc.Text = "";
            cbb_Tendonvi.SelectedIndex = -1;
            cbb_Tenloaithuoc.SelectedIndex = -1;
            cb_CachDung.SelectedIndex = -1;
            txt_congdung.Text = "";
            txt_Huongdansudung.Text = "";
            txt_dongia.Text="";

        }
        //LOAD Cbb LOAI THUOC CHO THUOC
        public void Load_LTcb()
        {
            List<LOAITHUOC> thuocList = dLoaiThuocBLL.GetData();
            cbb_Tenloaithuoc.DataSource = thuocList;
            cbb_Tenloaithuoc.DisplayMember = "TenLoaiThuoc";
            cbb_Tenloaithuoc.ValueMember = "id";
        }
        //LOAD Cbb CACHDUNG CHO THUOC

        public void Load_CDcb()
        {
            List<CACHDUNG> thuocList = dCachDungBLL.GetAllThuoc();
            cb_CachDung.DataSource = thuocList;
            cb_CachDung.DisplayMember = "TenCachDung";
            cb_CachDung.ValueMember = "id";
        }
        //LOAD Cbb DONVI CHO THUOC

        public void Load_DVcb()
        {
            List<DONVI> thuocList = dDonViBLL.GetAllThuoc();
            cbb_Tendonvi.DataSource = thuocList;
            cbb_Tendonvi.ValueMember = "id";
            cbb_Tendonvi.DisplayMember = "TenDonVi";
        }

        private void nud_Dongia_ValueChanged(object sender, EventArgs e)
        {

        }

        //CELL CLICK THUOC
        private void dgv_dsThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_dsThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_dsThuoc.SelectedRows[0];
                id.Text = row.Cells[0].Value.ToString();
                txt_Mathuoc.Text = row.Cells[1].Value.ToString();
                txt_Tenthuoc.Text = row.Cells[2].Value.ToString();
                cbb_Tenloaithuoc.DisplayMember = row.Cells[3].Value.ToString();
                cb_CachDung.DisplayMember = row.Cells[4].Value.ToString();
                cbb_Tendonvi.DisplayMember = row.Cells[5].Value.ToString();
                txt_Huongdansudung.Text = row.Cells[6].Value.ToString();
                txt_dongia.Text= row.Cells[8].Value.ToString();
                txt_congdung.Text = row.Cells[9].Value.ToString();
            }
        }

        private void dgv_dsThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Khongluu_Loaithuoc_Click_1(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_Maloaithuoc.Text = "";
            txt_Tenloaithuoc.Text = "";
        }

        private void lbl_Huongdansudung_Click(object sender, EventArgs e)
        {

        }
    }
}

