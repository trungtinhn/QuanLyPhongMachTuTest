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
        IDAL_LOGIN dalLogin;
        public BLL_LOGIN()
        {
            dalLogin = new DAL_LOGIN();
        }
        public BLL_LOGIN(IDAL_LOGIN dal)
        {
            this.dalLogin = dal;
        }
        public bool Login(string username, string password)
        {
            return dalLogin.Login(username, password);
        }
        public bool Check(string username)
        {
            return dalLogin.Check(username);
        }
    }
}