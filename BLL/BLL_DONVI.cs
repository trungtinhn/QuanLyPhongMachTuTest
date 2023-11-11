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
        private IDAL_DONVI dDonViDAL;

        public BLL_DONVI(IDAL_DONVI dalDonVi)
        {
            dDonViDAL = dalDonVi;
        }

        public BLL_DONVI()
        {
        }

        public void LayDanhSach(DataGridView dgv)
        {
            dgv.DataSource = dDonViDAL.LayDanhSach();
            dgv.Columns[0].HeaderText = "Tên ID";
            dgv.Columns[1].HeaderText = "Mã Đơn Vị";
            dgv.Columns[2].HeaderText = "Tên Đơn Vị";
        }


        public bool Add(DONVI cd)
        {
            try
            {
                dDonViDAL.Add(cd);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Check(string ten)
        {
            if (dDonViDAL.Check(ten) == true) return true;
            else return false;
        }
        public bool CapNhat(DONVI dONVI)
        {
            if (dDonViDAL.KiemTra(dONVI))
            {
                try
                {
                    dDonViDAL.CapNhat(dONVI);
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
            if (dDonViDAL.KiemTra(dONVI))
            {
                try
                {
                    dDonViDAL.Xoa(dONVI);
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
            if (dDonViDAL.KiemTra(cd))
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
            return dDonViDAL.getall();
        }
        public DONVI GetByTen(string ten)
        {
            return dDonViDAL.GetByten(ten);
        }

        public DONVI getDVbyID(int idMaDonVi)
        {
            return dDonViDAL.getDVbyID(idMaDonVi);
        }
    }

}