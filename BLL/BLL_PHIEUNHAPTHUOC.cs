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
        IDAL_PHIEUNHAPTHUOC dPhieuNhapThuoc;
        public BLL_PHIEUNHAPTHUOC()
        {
            dPhieuNhapThuoc = new DAL_PHIEUNHAPTHUOC();
        }
        public BLL_PHIEUNHAPTHUOC(IDAL_PHIEUNHAPTHUOC dPhieuNhapThuoc)
        {
            this.dPhieuNhapThuoc = dPhieuNhapThuoc;
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
            return dPhieuNhapThuoc.XoaPhieuNhap(soPhieu);
           
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
            return dPhieuNhapThuoc.LuuPhieuNhapThuoc(pnt);
        }
    }
}
