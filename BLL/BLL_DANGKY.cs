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
    public class BLL_DANGKY
    {
        private IDAL_DANGKY dDangKyDAL;

        public BLL_DANGKY(IDAL_DANGKY dalDangKy)
        {
            dDangKyDAL = dalDangKy;
        }

        public BLL_DANGKY()
        {
            dDangKyDAL = new DAL_DANGKY();
        }

        public dynamic LayDanhSachDangKy()
        {
            return dDangKyDAL.LayDanhSachDangKy();
        }

        public bool DangKyKhamBenh(DANGKY dangKy)
        {
            try
            {
                dDangKyDAL.DangKyKhamBenh(dangKy);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void XoaDangKy(DANGKY dangKy)
        {
            dDangKyDAL.XoaDangKy(dangKy);
        }

        public DANGKY LayDangKy(int idBenhNhan)
        {
            return dDangKyDAL.LayDangKy(idBenhNhan);
        }

        public int LaySoBenhNhanTiepNhan()
        {
           return dDangKyDAL.LaySoBenhNhanTiepNhan();
        }
    }
}
