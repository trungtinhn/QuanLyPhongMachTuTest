using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_CT_PHIEUKHAMBENH
    {
        private IDAL_CTPHIEUKHAMBENH dCTPhieuKhamBenhDAL;

        public BLL_CT_PHIEUKHAMBENH(IDAL_CTPHIEUKHAMBENH dalCTPhieuKhamBenh)
        {
            dCTPhieuKhamBenhDAL = dalCTPhieuKhamBenh;
        }

        public BLL_CT_PHIEUKHAMBENH()
        {
            dCTPhieuKhamBenhDAL = new DAL_CT_PHIEUKHAMBENH();
        }


        public bool ThemCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            try
            {
                dCTPhieuKhamBenhDAL.ThemCTPKB(cTPKB);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public dynamic LayDanhSachThuoc(int soPhieuKhamBenh)
        {
            return dCTPhieuKhamBenhDAL.LayDanhSachThuoc(soPhieuKhamBenh);
        }

        public bool SuaCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            try
            {
                dCTPhieuKhamBenhDAL.SuaCTPKB(cTPKB);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            try
            {
                dCTPhieuKhamBenhDAL.XoaCTPKB(cTPKB);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public dynamic LayTheoThuoc(int idThuoc)
        {
            return dCTPhieuKhamBenhDAL.LayTheoThuoc(idThuoc);
        }
    }
}
