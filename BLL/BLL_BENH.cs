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
    public class BLL_BENH
    {
        DAL_BENH dBenhDAL;
        public BLL_BENH()
        {
            dBenhDAL = new DAL_BENH();
        }

        public dynamic LayThongTinBenh()
        {
            return dBenhDAL.LayThongTinBenh();
            
        }

        public bool ThemBenh(BENH benh)
        {
            try
            {
                dBenhDAL.ThemBenh(benh);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatBenh(BENH benh)
        {
            if (dBenhDAL.KiemTraBenh(benh))
            {
                try
                {
                    dBenhDAL.CapNhatBenh(benh);
                    return true;
                }catch(Exception ex)
                {
                    return false;
                }
               
            }
            else
            {
                return false;
            }
        }

        public bool XoaBenh(BENH benh)
        {
            if (dBenhDAL.KiemTraBenh(benh))
            {
                try
                {
                    dBenhDAL.XoaBenh(benh);
                    return true;
                }catch { return false;}
            }
            else
            {
                return false;
            }
        }

        public BENH LayBenh(string maBenh)
        {
            return dBenhDAL.LayBenh(maBenh);
        }

        public BENH LayBenh(int idBenh)
        {
            return dBenhDAL.LayBenh(idBenh);
        }

        public dynamic LocBenh(string kieuLoc, string giaTri)
        {
            return dBenhDAL.LocBenh(kieuLoc, giaTri);
        }

    }
}
