using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.DAL_BENHNHAN;

namespace BLL
{
    public class BLL_BENHNHAN
    {
        private IDAL_BENHNHAN dBenhNhanDAL;

        public BLL_BENHNHAN(IDAL_BENHNHAN dal)
        {
            dBenhNhanDAL = dal;
        }

        public BLL_BENHNHAN()
        {

        }

        public dynamic LayDanhSachBenhNhan(string kieuLoc, string giaTri, DateTime ngaySinh)
        {
            return dBenhNhanDAL.LayDanhSachBenhNhan(kieuLoc, giaTri, ngaySinh);
        }

        public bool ThemBenhNhan(BENHNHAN benhNhan)
        {
            try
            {
                dBenhNhanDAL.ThemBenhNhan(benhNhan);
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
        }

        public bool CapNhatBenhNhan(BENHNHAN benhNhan)
        {
            if (dBenhNhanDAL.KiemTraBenhNhan(benhNhan))
            {

                try
                {
                    dBenhNhanDAL.CapNhatBenhNhan(benhNhan);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaBenhNhan(BENHNHAN benhNhan)
        {
            if (dBenhNhanDAL.KiemTraBenhNhan(benhNhan))
            {
                try
                {
                    dBenhNhanDAL.XoaBenhNhan(benhNhan);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public BENHNHAN LayThongTinBenhNhan(string MaBenhNhan)
        {
            return dBenhNhanDAL.LayThongTinBenhNhan(MaBenhNhan);
        }

        public BENHNHAN LayThongTinBenhNhan(int idBenhNhan)
        {
            return dBenhNhanDAL.LayThongTinBenhNhan(idBenhNhan);
        }

    }
}
