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
        IDAL_THUOC dThuocDAL;
        public BLL_THUOC()
        {
            dThuocDAL = new DAL_THUOC();
        }
        public BLL_THUOC(IDAL_THUOC dAL_)
        {
            dThuocDAL = dAL_;
        }

        public dynamic LayDanhSachThuoc(int idLoaiThuoc)
        {
            return dThuocDAL.LayDanhSachThuoc(idLoaiThuoc);
        }

        public THUOC LayThuocByMa(string maThuoc)
        {
            return dThuocDAL.LayThuocByMa(maThuoc);
        }

        public THUOC LayThuocById(int idThuoc)
        {
            return dThuocDAL.LayThuocById(idThuoc);
        }

        public THUOC LayThongTinThuoc(string tenThuoc)
        {
            return dThuocDAL.LayThongTinThuoc(tenThuoc);
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
    }
}
