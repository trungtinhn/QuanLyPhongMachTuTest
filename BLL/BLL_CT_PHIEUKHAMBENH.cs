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
        DAL_CT_PHIEUKHAMBENH dCTPhieuKhamBenhAL;

        public BLL_CT_PHIEUKHAMBENH()
        {
            dCTPhieuKhamBenhAL = new DAL_CT_PHIEUKHAMBENH();
        }

        public bool ThemCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            try
            {
                dCTPhieuKhamBenhAL.ThemCTPKB(cTPKB);
                return true;
            }catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        public dynamic LayDanhSachThuoc(int soPhieuKhamBenh)
        {
            return dCTPhieuKhamBenhAL.LayDanhSachThuoc(soPhieuKhamBenh);
        }

        public bool SuaCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            try
            {
                dCTPhieuKhamBenhAL.SuaCTPKB(cTPKB);
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
                dCTPhieuKhamBenhAL.XoaCTPKB(cTPKB);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public dynamic LayTheoThuoc(int idThuoc)
        {
            return dCTPhieuKhamBenhAL.LayTheoThuoc(idThuoc);
        }
    }
}
