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
    public class BLL_LOAITHUOC
    {
        DAL_LOAITHUOC dLoaiThuocDAL;
        public BLL_LOAITHUOC()
        {
            dLoaiThuocDAL = new DAL_LOAITHUOC();    
        }

        public dynamic LayDanhSachLoaiThuoc()
        {
            return dLoaiThuocDAL.LayDanhSachLoaiThuoc();
        }

        public LOAITHUOC LayLoaiThuoc(string MaLoaiThuoc)
        {
            return dLoaiThuocDAL.LayLoaiThuoc(MaLoaiThuoc);
        }

        public string LayTenLoaiThuoc(int idLoaiThuoc)
        {
            return dLoaiThuocDAL.LayTenLoaiThuoc(idLoaiThuoc);
        }

        public bool Add(LOAITHUOC cd)
        {
            try
            {
                dLoaiThuocDAL.Add(cd);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Check(string ten)
        {
            if (dLoaiThuocDAL.Check(ten) == true) return true;
            else return false;
        }
        public bool CapNhat(LOAITHUOC lOAITHUOC)
        {
            if (dLoaiThuocDAL.KiemTra(lOAITHUOC))
            {
                try
                {
                    dLoaiThuocDAL.CapNhat(lOAITHUOC);
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
        //XOA
        public bool Xoa(LOAITHUOC cACHDUNG)
        {
            if (dLoaiThuocDAL.KiemTra(cACHDUNG))
            {
                try
                {
                    dLoaiThuocDAL.Xoa(cACHDUNG);
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

        public bool TracuuCD(LOAITHUOC cd)
        {
            if (dLoaiThuocDAL.KiemTra(cd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<LOAITHUOC> GetAllThuoc()
        {
            return dLoaiThuocDAL.getall();
        }
        public LOAITHUOC GetbyTen(string ten)
        {
            return dLoaiThuocDAL.GetByten(ten);
        }

        public LOAITHUOC getLTbyID(int idMaLoaiThuoc)
        {
            return dLoaiThuocDAL.getLTbyID(idMaLoaiThuoc);
        }

        public LOAITHUOC GetDataByMa(int maLoai)
        {
            return dLoaiThuocDAL.GetDataByMa(maLoai);
        }

        public List<LOAITHUOC> GetData()
        {
            return dLoaiThuocDAL.GetData().ToList();
        }
    }
}
