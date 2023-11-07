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
    public partial class DonViCachDung : UserControl
    {
        BLL_CACHDUNG bCachDung;
        BLL_DONVI bDonVi;


        public DonViCachDung()
        {
            InitializeComponent();
            bCachDung = new BLL_CACHDUNG();
            bDonVi = new BLL_DONVI();
        }


        //KIEM TRA NHAP
        public bool KiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(txt_Tencachdung.Text)|| string.IsNullOrWhiteSpace(txt_TenDonVi.Text))
            {
                return false; // Không đủ thông tin, trả về false
            }
            return true; // Đủ thông tin, trả về true
        }



        //HIEN THI
        public void HIENTHI()
        {
            dgv_DonVi.DataSource = null;
            dgv_CachDung.DataSource = null;
            bDonVi.LayDanhSach(dgv_DonVi);
            bCachDung.LayDanhSach(dgv_CachDung);
        }



        //MAIN
        private void DonViCachDung_Load(object sender, EventArgs e)
        {
            HIENTHI();
        }



        //THEM CACH DUNG
        //CHECK CACH DUNG THEM VAO NEU TRUNG TEN 
        private void btn_Them_Cachdung_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm");
                return;
            }
            CACHDUNG cd = new CACHDUNG();
            if (bCachDung.CheckCachDung(txt_Tencachdung.Text) == true)
            {
                DialogResult result = MessageBox.Show("Tên cách dùng đã tồn tại. Bạn có chắc chắn muốn thêm không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cd.TenCachDung = txt_Tencachdung.Text;
                    if (bCachDung.AddCachDung(cd) == true)
                    {
                        MessageBox.Show("Thêm cách dùng thành công!");
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
                cd.TenCachDung = txt_Tencachdung.Text;
            }

            if (bCachDung.AddCachDung(cd) == true)
            {
                MessageBox.Show("Thêm cách dùng thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");

            }
        }


        //CAP NHAT
        private void btn_Capnhat_Cachdung_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần cập nhật");
                return;
            }
            CACHDUNG cd = new CACHDUNG();
            cd.MaCachDung = txt_MaCachDung.Text;
            cd.TenCachDung = txt_Tencachdung.Text;
            if (bCachDung.CapNhatCachDung(cd) == true)
            {
                MessageBox.Show("Cập nhật cách dùng thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }

        }



        private void txt_Macachdung_TextChanged(object sender, EventArgs e)
        {

        }





        //XOA 
        private void btn_xoa_Cachdung_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần xóa");
                return;
            }
            CACHDUNG cd = new CACHDUNG();
            cd.id = int.Parse(txt_ID.Text);
            if (bCachDung.XoaCachDung(cd) == true)
            {
                MessageBox.Show("Xóa cách dùng thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Không thể xóa cách dùng vì đang được sử dụng");
            }
        }



        //XOA TRANG
        private void btn_KhongLuu_Cachdung_Click(object sender, EventArgs e)
        {
            txt_MaCachDung.Text = "";
            txt_Tencachdung.Text = "";
            txt_ID.Text = "";
        }


        private void dgv_CachDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        //CELL CLICK
        private void dgv_CachDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_CachDung.SelectedRows.Count>0)
            {
                DataGridViewRow row = dgv_CachDung.SelectedRows[0];
                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_MaCachDung.Text = row.Cells[1].Value.ToString();
                txt_Tencachdung.Text = row.Cells[2].Value.ToString();
            }
        }


        //TRACUU CACH DUNG 
        private void btn_Tracuu_Cachdung_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                return;
            }
            CACHDUNG cd = new CACHDUNG();
            cd.MaCachDung = txt_Macachdung_Search.Text;
            if (bCachDung.TracuuCD(cd) == true)
            {
                var rowIndex = -1;
                for (int i = 0; i < dgv_CachDung.Rows.Count; i++)
                {
                    if (dgv_CachDung.Rows[i].Cells[1].Value.ToString() == cd.MaCachDung)
                    {
                        rowIndex = i;
                        break;
                    }
                }

                if (cd != null && rowIndex >= 0)
                {

                    // Cuộn đến dòng tìm thấy va tro
                    dgv_CachDung.FirstDisplayedScrollingRowIndex = rowIndex;
                    dgv_CachDung.CurrentCell = dgv_CachDung.Rows[rowIndex].Cells[0];
                }
                else
                {
                    MessageBox.Show("Thất bại! Không tìm thấy");
                }
            }
        }

        //XOA TRANG DON VI

        private void btn_Khongluu_dv_Click(object sender, EventArgs e)
        {
            txt_MaDonVi.Text = "";
            txt_TenDonVi.Text = "";
            txt_ID2.Text = "";
        }

        //THEM DON VI
        private void btn_Them_dv_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm");
                return;
            }
            DONVI cd = new DONVI();
            if (bDonVi.Check(txt_TenDonVi.Text) == true)
            {
                DialogResult result = MessageBox.Show("Tên đơn vị đã tồn tại. Bạn có chắc chắn muốn thêm không?", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cd.TenDonVi = txt_TenDonVi.Text;
                    if (bDonVi.Add(cd) == true)
                    {
                        MessageBox.Show("Thêm đơn vị thành công!");
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
                cd.TenDonVi = txt_TenDonVi.Text;
            }

            if (bDonVi.Add(cd) == true)
            {
                MessageBox.Show("Thêm Đơn vị thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");

            }
        }


        // CAP NHAT ĐON VỊ 


        private void btn_Capnhat_dv_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần cập nhật");
                return;
            }
            DONVI cd = new DONVI();
            cd.MaDonvi = txt_MaDonVi.Text;
            cd.TenDonVi = txt_TenDonVi.Text;
            if (bDonVi.CapNhat(cd) == true)
            {
                MessageBox.Show("Cập nhật đơn vị thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        // TRA CỨU ĐƠN VỊ 



        private void btn_Tracuu_dv_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tra cứu");
                return;
            }
            DONVI cd = new DONVI();
            cd.MaDonvi = txt_MaDonVi_Tracuu.Text;
            if (bDonVi.TracuuCD(cd) == true)
            {
                var rowIndex = -1;
                for (int i = 0; i < dgv_DonVi.Rows.Count; i++)
                {
                    if (dgv_DonVi.Rows[i].Cells[1].Value.ToString() == cd.MaDonvi)
                    {
                        rowIndex = i;
                        break;
                    }
                }

                if (cd != null && rowIndex >= 0)
                {

                    // Cuộn đến dòng tìm thấy va tro
                    dgv_DonVi.FirstDisplayedScrollingRowIndex = rowIndex;
                    dgv_DonVi.CurrentCell = dgv_DonVi.Rows[rowIndex].Cells[0];
                }
                else
                {
                    MessageBox.Show("Thất bại! Không tìm thấy");
                }
            }
        }



        private void dgv_DonVi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //CELL CLICK DON VI

        private void dgv_DonVi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DonVi.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_DonVi.SelectedRows[0];
                txt_ID2.Text = row.Cells[0].Value.ToString();
                txt_MaDonVi.Text = row.Cells[1].Value.ToString();
                txt_TenDonVi.Text = row.Cells[2].Value.ToString();
            }
        }

        //XÓA ĐƠN VỊ 


        private void btn_XoaDV(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu() == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần xóa");
                return;
            }
            DONVI cd = new DONVI();
            cd.id = int.Parse(txt_ID2.Text);
            if (bDonVi.Xoa(cd) == true)
            {
                MessageBox.Show("Xóa đơn vị thành công!");
                HIENTHI();
            }
            else
            {
                MessageBox.Show("Không thể xóa đơn vị vì đang đơn vị đang được sử dụng!");
            }
        }
    }
}

