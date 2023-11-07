using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PHIEUKHAMBENH
    {
        DAL_PHIEUKHAMBENH dPhieuKhamBenhDAL;
        public BLL_PHIEUKHAMBENH() 
        {
            dPhieuKhamBenhDAL = new DAL_PHIEUKHAMBENH();
        }

        public bool ThemPhieuKhamBenh(PHIEUKHAMBENH pkb)
        {
            try
            {
                dPhieuKhamBenhDAL.ThemPhieuKhamBenh(pkb);
                return true;
            }
            catch { return false; }
        }

        public dynamic LayDanhSachPhieuKhamBenh(string kieuLoc, string giaTri, DateTime start, DateTime end)
        {
            return dPhieuKhamBenhDAL.LayDanhSachPhieuKhamBenh(kieuLoc, giaTri, start, end);
        }

        public PHIEUKHAMBENH LayPhieuKhamBenh(int soPhieuKhamBenh)
        {
            return dPhieuKhamBenhDAL.LayPhieuKhamBenh(soPhieuKhamBenh);
        }

        public void TinhTongTien(int soPhieuKhamBenh)
        {
            dPhieuKhamBenhDAL.TinhTongTien(soPhieuKhamBenh);
        }

        public bool LuuPhieuKhamBenh(PHIEUKHAMBENH pkb)
        {
            try
            {
                dPhieuKhamBenhDAL.LuuPhieuKhamBenh(pkb);
                return true;
            }
            catch
            {
                return false;
            }
        }
        

    }
}
