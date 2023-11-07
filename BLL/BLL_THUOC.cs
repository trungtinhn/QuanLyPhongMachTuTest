using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_THUOC
    {
        DAL_THUOC dThuocDAL;
        public BLL_THUOC()
        {
            dThuocDAL = new DAL_THUOC();
        }

        public dynamic LayDanhSachThuoc(int idLoaiThuoc)
        {
            return dThuocDAL.LayDanhSachThuoc(idLoaiThuoc);
        }

        public THUOC LayThuoc(string maThuoc)
        {
            return dThuocDAL.LayThuoc(maThuoc);
        }

        public THUOC LayTenThuoc(int idThuoc)
        {
            return dThuocDAL.LayTenThuoc(idThuoc);
        }

        public THUOC LayThongTinThuoc(string tenThuoc)
        {
            return dThuocDAL.LayThongTinThuoc(tenThuoc);
        }

        public void LayDanhSach(DataGridView dgv)
        {
            //dgv.DataSource = dThuocBLL.LayDanhSach();
            //dgv.Columns[0].HeaderText = "Tên ID";
            //dgv.Columns[1].HeaderText = "Mã Thuốc";
            //dgv.Columns[2].HeaderText = "Tên Thuốc";
            //dgv.Columns[3].HeaderText = "Loại Thuốc";
            //dgv.Columns[4].HeaderText = "Cách dùng";
            //dgv.Columns[5].HeaderText = "Đơn Vị";
            //dgv.Columns[6].HeaderText = "HDSD";
            //dgv.Columns[7].HeaderText = "Số Lượng";
            //dgv.Columns[8].HeaderText = "Đơn giá";
            //dgv.Columns[9].HeaderText = "Công Dụng";

        }

        public bool Add(THUOC cd)
        {
            try
            {
                dThuocDAL.Add(cd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Check(string ten)
        {
            if (dThuocDAL.Check(ten) == true) return true;
            else return false;
        }



        public bool CapNhat(THUOC lOAITHUOC)
        {
            if (dThuocDAL.KiemTra(lOAITHUOC))
            {
                try
                {
                    dThuocDAL.CapNhat(lOAITHUOC);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }



        public bool TracuuCD(THUOC cd)
        {
            if (dThuocDAL.KiemTra(cd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<THUOC> getall()
        {
            return dThuocDAL.Getall();
        }



        public List<THUOC> getThuocSapHet()
        {
            return dThuocDAL.getThuocSapHet();
        }

        public bool CapNhatSoLuongTon(int idThuoc, int SoLuongCapNhat)
        {
            if (dThuocDAL.CapNhatSoLuongTon(idThuoc, SoLuongCapNhat))
            {
                return true;
            }else
            {
                return false;
            }
        }

        public dynamic DanhSachThuoc()
        {
            return dThuocDAL.DanhSachThuoc();
        }
        public List<THUOC> GetDataByMaLoai(int maLoai)
        {
            return dThuocDAL.GetDataByMaLoai(maLoai);
        }

        public THUOC GetDataByMa(int maThuoc)
        {
            return dThuocDAL.GetDataByMa(maThuoc);
        }
        public THUOC GetThuocbyMa(int i)
        {
            return dThuocDAL.GetThuocbyMa(i);
        }
        public void Luu(THUOC t)
        {
            dThuocDAL.Luu(t);
        }
        public THUOC GetTenById(int idMaThuoc)
        {
            return dThuocDAL.GetTenById(idMaThuoc);
        }

    }
}
