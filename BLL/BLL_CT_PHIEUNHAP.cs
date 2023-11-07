using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_CT_PHIEUNHAP
    {
        DAL_CT_PHIEUNHAP dCT_PhieuNhap;
        public BLL_CT_PHIEUNHAP()
        {
            dCT_PhieuNhap = new DAL_CT_PHIEUNHAP();
        }

        public List<CT_PHIEUNHAP> GetCTByMa(int ma)
        {
            return dCT_PhieuNhap.GetCTByMa(ma);
        }
        public bool ThemChiTietPhieu(CT_PHIEUNHAP model)
        {
            return dCT_PhieuNhap.ThemChiTietPhieu(model);
        }
        public object GetDataCTPhieuByMaPhieu(int maPhieu)
        {
            return dCT_PhieuNhap.GetDataCTPhieuByMaPhieu(maPhieu);
        }
        public bool XoaChiTietPhieu(CT_PHIEUNHAP model)
        {
            return dCT_PhieuNhap.XoaChiTietPhieu(model);
        }

        public bool SuaChiTietPhieu(CT_PHIEUNHAP model)
        {
            return dCT_PhieuNhap.SuaChiTietPhieu(model);
        }
        public bool XoaAllChiTietPhieu(int soPhieu)
        {
            return dCT_PhieuNhap.XoaAllChiTietPhieu(soPhieu);
        }
        public dynamic Getall(int i)
        {
            return dCT_PhieuNhap.Getall(i);
        }
    }
}
