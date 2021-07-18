using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_Account
    {
        private static DAL_Account _Instance;

        public static DAL_Account Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Account();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_Account() { }
        public Account GetAccount(DataRow i)
        {
            return new Account
            {
                TenDangNhap = i["tendangnhap"].ToString(),
                MatKhau = i["matkhau"].ToString(),
                Email = i["email"].ToString(),
                Quyen = i["quyen"].ToString(),
                SDTNV = i["sdtnv"].ToString()
            };
        }
        public List<Account> GetAllAccount()
        {
            List<Account> l = new List<Account>();
            string query = "select * from Account";
            foreach(DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetAccount(i));
            }
            return l;
        }
        public List<Account> GetAccountNV()
        {
            List<Account> l = new List<Account>();
            string query = string.Format("select * from Account where quyen = '{0}'", "user");
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetAccount(i));
            }
            return l;
        }
        public bool CheckAccount(string TenDN, string MK, string Quyen)
        {
            try
            {
                foreach(Account i in GetAllAccount())
                {
                    if(TenDN == i.TenDangNhap && MK == i.MatKhau && Quyen == i.Quyen)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public string GetTenDNByEmail(string email)
        {
            string s = "";
            foreach(Account i in GetAllAccount())
            {
                if(email == i.Email)
                {
                    s = i.TenDangNhap;
                }
            }
            return s;
        }
        public bool UpdateMKByEmail(string Email, string MK)
        {
            try
            {
                string query = string.Format("update Account " +
                    "set matkhau = '{0}'" +
                    "where email = '{1}'", MK, Email);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool Del(string TenDangNhap)
        {
            try
            {
                string query = string.Format("delete from Account where tendangnhap = '{0}'", TenDangNhap);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Add(string TDN, string MK, string Email, string SDTNV)
        {
            try
            {
                string query = string.Format("insert Account(tendangnhap, matkhau, email, quyen, sdtnv) values" +
                    "('{0}', '{1}', '{2}', 'user', '{3}')", TDN, MK, Email, SDTNV);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
