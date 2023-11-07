using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_PHIEUNHAPTHUOC
    {
        DAL_PHIEUNHAPTHUOC dPhieuNhapThuoc;
        public BLL_PHIEUNHAPTHUOC()
        {
            dPhieuNhapThuoc = new DAL_PHIEUNHAPTHUOC();
        }

        public List<PHIEUNHAPTHUOC> GetData()
        {
            return dPhieuNhapThuoc.GetData();
        }


        public PHIEUNHAPTHUOC GetDataByMa(int maPhieu)
        {
            return dPhieuNhapThuoc.GetDataByMa(maPhieu);
        }

        public int GetMaMax()
        {
            return dPhieuNhapThuoc.GetMaMax();
        }


        public bool ThemPhieu(PHIEUNHAPTHUOC phieu)
        {
            return dPhieuNhapThuoc.ThemPhieu(phieu);
        }







        public bool XoaPhieuNhap(int soPhieu)
        {
            try
            {
                dPhieuNhapThuoc.XoaPhieuNhap(soPhieu);
                return true;
            }
            catch { return false; }
           
        }
        public int TongTien(int i)
        {
            return dPhieuNhapThuoc.TongTien(i);

        }
        public int getTongtien(PHIEUNHAPTHUOC p)
        {
            return dPhieuNhapThuoc.getTongtien(p);
        }


        public bool LuuPhieuNhapThuoc(PHIEUNHAPTHUOC pnt)
        {
            try
            {
                dPhieuNhapThuoc.LuuPhieuNhapThuoc(pnt);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
