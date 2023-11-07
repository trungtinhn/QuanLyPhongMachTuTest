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
    public class BLL_DONVI
    {
        DAL_DONVI dDonViBLL;


        public BLL_DONVI()
        {
            dDonViBLL = new DAL_DONVI();
        }

        public void LayDanhSach(DataGridView dgv)
        {
            dgv.DataSource = dDonViBLL.LayDanhSach();
            dgv.Columns[0].HeaderText = "Tên ID";
            dgv.Columns[1].HeaderText = "Mã Đơn Vị";
            dgv.Columns[2].HeaderText = "Tên Đơn Vị";
        }


        public bool Add(DONVI cd)
        {
            try
            {
                dDonViBLL.Add(cd);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Check(string ten)
        {
            if (dDonViBLL.Check(ten) == true) return true;
            else return false;
        }
        public bool CapNhat(DONVI dONVI)
        {
            if (dDonViBLL.KiemTra(dONVI))
            {
                try
                {
                    dDonViBLL.CapNhat(dONVI);
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


        //XOA
        public bool Xoa(DONVI dONVI)
        {
            if (dDonViBLL.KiemTra(dONVI))
            {
                try
                {
                    dDonViBLL.Xoa(dONVI);
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

        public bool TracuuCD(DONVI cd)
        {
            if (dDonViBLL.KiemTra(cd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<DONVI> GetAllThuoc()
        {
            return dDonViBLL.getall();
        }
        public DONVI GetByTen(string ten)
        {
            return dDonViBLL.GetByten(ten);
        }

        public DONVI getDVbyID(int idMaDonVi)
        {
            return dDonViBLL.getDVbyID(idMaDonVi);
        }
    }

}