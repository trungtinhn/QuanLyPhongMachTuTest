using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_THAMSO
    {
        IDAL_THAMSO dThamSoDAL;
        public BLL_THAMSO()
        {
            dThamSoDAL = new DAL_THAMSO();
        }
        public BLL_THAMSO(IDAL_THAMSO dAL_)
        {
            dThamSoDAL = dAL_;
        }

        public void ThayDoiQuyDinh(int TienKham, int SoBenhNhanToiDa, int SoLuongThuocSapHet)
        {
            dThamSoDAL.ThayDoiThamSo(TienKham, SoBenhNhanToiDa, SoLuongThuocSapHet);
        }

        public THAMSO LayThamSo(int id)
        {
            return dThamSoDAL.LayThamSo(id);
        }
    }
}
