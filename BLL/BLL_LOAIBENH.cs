using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_LOAIBENH
    {
        IDAL_LOAIBENH dLoaiBenhDAL;
        public BLL_LOAIBENH()
        {
            dLoaiBenhDAL = new DAL_LOAIBENH();
        }
        public BLL_LOAIBENH(IDAL_LOAIBENH dAL_LOAIBENH)
        {
            dLoaiBenhDAL = dAL_LOAIBENH;
        }

        public dynamic LayDanhSachLoaiBenh(string kieuLoc, string giaTri)
        {
            return dLoaiBenhDAL.LayDanhSachLoaiBenh(kieuLoc, giaTri);
           
        }
        public string LayTenLoaiBenh(int maBenh)
        {
            return dLoaiBenhDAL.LayTenLoaiBenh(maBenh);
        }

        public bool ThemLoaiBenh(LOAIBENH loaiBenh)
        {
            try
            {
                dLoaiBenhDAL.ThemLoaiBenh(loaiBenh);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatLoaiBenh(LOAIBENH loaiBenh)
        {
            if (dLoaiBenhDAL.KiemTraLoaiBenh(loaiBenh))
            {
                try
                {
                    dLoaiBenhDAL.CapNhatLoaiBenh(loaiBenh);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaLoaiBenh(LOAIBENH loaiBenh)
        {
            if (dLoaiBenhDAL.KiemTraLoaiBenh(loaiBenh))
            {
                try
                {
                    dLoaiBenhDAL.XoaLoaiBenh(loaiBenh);
                    return true;
                }catch (DbUpdateException ex)
                {
                    return false;
                }
            }else { return false; }
        }

        public LOAIBENH LayThongTinLoaiBenh(string tenLB)
        {
            return dLoaiBenhDAL.LayThongTinLoaiBenh(tenLB);
        }
    }
}
