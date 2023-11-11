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
        private IDAL_CTPHIEUNHAP dCTPhieuNhapDAL;

        public BLL_CT_PHIEUNHAP(IDAL_CTPHIEUNHAP dalCTPhieuNhap)
        {
            dCTPhieuNhapDAL = dalCTPhieuNhap;
        }

        public BLL_CT_PHIEUNHAP()
        {
        }

        public List<CT_PHIEUNHAP> GetCTByMa(int ma)
        {
            return dCTPhieuNhapDAL.GetCTByMa(ma);
        }
        public bool ThemChiTietPhieu(CT_PHIEUNHAP model)
        {
            return dCTPhieuNhapDAL.ThemChiTietPhieu(model);
        }
        public object GetDataCTPhieuByMaPhieu(int maPhieu)
        {
            return dCTPhieuNhapDAL.GetDataCTPhieuByMaPhieu(maPhieu);
        }
        public bool XoaChiTietPhieu(CT_PHIEUNHAP model)
        {
            return dCTPhieuNhapDAL.XoaChiTietPhieu(model);
        }

        public bool SuaChiTietPhieu(CT_PHIEUNHAP model)
        {
            return dCTPhieuNhapDAL.SuaChiTietPhieu(model);
        }
        public bool XoaAllChiTietPhieu(int soPhieu)
        {
            return dCTPhieuNhapDAL.XoaAllChiTietPhieu(soPhieu);
        }
        public dynamic Getall(int i)
        {
            return dCTPhieuNhapDAL.Getall(i);
        }
    }
}
