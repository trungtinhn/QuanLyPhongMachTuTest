using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using DTO;
using System.Data.Entity.Infrastructure;

namespace BLL
{
    public class BLL_CACHDUNG
    {
        private IDAL_CACHDUNG dCachDungDAL;

        public BLL_CACHDUNG(IDAL_CACHDUNG dalCachDung)
        {
            dCachDungDAL = dalCachDung;
        }

        public BLL_CACHDUNG()
        {
        }

        public void LayDanhSach(DataGridView dgv)
        {

            dgv.DataSource = dCachDungDAL.LayDanhSach();
            dgv.Columns[0].HeaderText = "Tên ID";
            dgv.Columns[1].HeaderText = "Mã Cách Dùng";
            dgv.Columns[2].HeaderText = "Tên Cách Dùng";
        }


        //ADD
        public bool AddCachDung(CACHDUNG cd)
        {
            try
            {
                dCachDungDAL.AddCachDung(cd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //CHECK TEN

        public bool CheckCachDung(string ten)
        {
            if (dCachDungDAL.CheckCachDung(ten) == true) return true;
            else return false;
        }

        //CAPNHAT

        public bool CapNhatCachDung(CACHDUNG cACHDUNG)
        {
            if (dCachDungDAL.KiemTraCachDung(cACHDUNG))
            {
                try
                {
                    dCachDungDAL.CapNhatCachDung(cACHDUNG);
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
        //XOA
        public bool XoaCachDung(CACHDUNG cACHDUNG)
        {
            if (dCachDungDAL.KiemTraCachDung(cACHDUNG))
            {
                try
                {
                    dCachDungDAL.XoaCachDung(cACHDUNG);
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
        //TRA CUU
        public bool TracuuCD(CACHDUNG cd)
        {
            if (dCachDungDAL.KiemTraCachDung(cd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CACHDUNG> GetAllThuoc()
        {
            return dCachDungDAL.getall();
        }


        public CACHDUNG GetByTen(string ten)
        {
            return dCachDungDAL.GetByTen(ten);
        }

        public CACHDUNG getCDbyID(int idMaCachDung)
        {
            return dCachDungDAL.getCDbyID(idMaCachDung);
        }
    }
}