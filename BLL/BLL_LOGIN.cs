using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class BLL_LOGIN
    {
        private readonly NGUOIDUNG dalLogin;

        public BLL_LOGIN()
        {
            dalLogin = new NGUOIDUNG();
        }
        public bool Login(string username, string password)
        {
            using (QLPMTEntities dbContext = new QLPMTEntities())
            {
                return dbContext.NGUOIDUNGs.Any(a => a.TenDangNhap == username && a.MatKhau == password);
            }
        }
        public bool Check(string username)
        {
            using (QLPMTEntities dbContext = new QLPMTEntities())
            {
                return dbContext.NGUOIDUNGs.Any(a => a.TenDangNhap == username);
            }
        }
    }
}