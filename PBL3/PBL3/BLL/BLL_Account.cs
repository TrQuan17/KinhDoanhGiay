using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_Account
    {
        private static BLL_Account _Instance;

        public static BLL_Account Instance 
        { 
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_Account();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_Account() { }
        public List<Account> GetAllAccount_BLL()
        {
            return DAL_Account.Instance.GetAllAccount();
        }
        public List<Account> GetAccountNV_BLL()
        {
            return DAL_Account.Instance.GetAccountNV();
        }
        public bool CheckAccount_BLL(string TenDN, string MK, string Quyen)
        {
            return DAL_Account.Instance.CheckAccount(TenDN, MK, Quyen);
        }
        public string GetTenDNByEmail_BLL(string email)
        {
            return DAL_Account.Instance.GetTenDNByEmail(email);
        }
        public bool UpdateMKByEmail_BLL(string Email, string MK)
        {
            return DAL_Account.Instance.UpdateMKByEmail(Email, MK);
        }
        public string GetQuyenByTenDN(string TenDN)
        {
            string quyen = "";
            foreach(Account i in GetAllAccount_BLL())
            {
                if(TenDN == i.TenDangNhap)
                {
                    quyen = i.Quyen;
                }
            }
            return quyen;
        }
        public bool CheckTenDN(string TenDN)
        {
            foreach(Account i in GetAllAccount_BLL())
            {
                if(TenDN == i.TenDangNhap)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Del_BLL(string TenDangNhap)
        {
            return DAL_Account.Instance.Del(TenDangNhap);
        }
        public bool CheckSDTNV(string SDTNV)
        {
            foreach(Account i in GetAccountNV_BLL())
            {
                if (i.SDTNV == SDTNV) return false;
            }
            return true;
        }
        public bool Add_BLL(string TDN, string MK, string Email, string SDTNV)
        {
            return DAL_Account.Instance.Add(TDN, MK, Email, SDTNV);
        }
    }
}
