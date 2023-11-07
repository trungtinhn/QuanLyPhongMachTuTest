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
        DAL_CACHDUNG dCachDungBLL;
        public BLL_CACHDUNG()
        {
            dCachDungBLL = new DAL_CACHDUNG();
        }


        public void LayDanhSach(DataGridView dgv)
        {

            dgv.DataSource = dCachDungBLL.LayDanhSach();
            dgv.Columns[0].HeaderText = "Tên ID";
            dgv.Columns[1].HeaderText = "Mã Cách Dùng";
            dgv.Columns[2].HeaderText = "Tên Cách Dùng";
        }


        //ADD
        public bool AddCachDung(CACHDUNG cd)
        {
            try
            {
                dCachDungBLL.AddCachDung(cd);
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
            if (dCachDungBLL.CheckCachDung(ten) == true) return true;
            else return false;
        }

        //CAPNHAT

        public bool CapNhatCachDung(CACHDUNG cACHDUNG)
        {
            if (dCachDungBLL.KiemTraCachDung(cACHDUNG))
            {
                try
                {
                    dCachDungBLL.CapNhatCachDung(cACHDUNG);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
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
            if (dCachDungBLL.KiemTraCachDung(cACHDUNG))
            {
                try
                {
                    dCachDungBLL.XoaCachDung(cACHDUNG);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
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
            if (dCachDungBLL.KiemTraCachDung(cd))
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
            return dCachDungBLL.getall();
        }


        public CACHDUNG GetByTen(string ten)
        {
            return dCachDungBLL.GetByTen(ten);
        }

        public CACHDUNG getCDbyID(int idMaCachDung)
        {
            return dCachDungBLL.getCDbyID(idMaCachDung);
        }
    }
}