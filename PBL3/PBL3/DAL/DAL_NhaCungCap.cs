using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_NhaCungCap
    {
        private static DAL_NhaCungCap _Instance;

        public static DAL_NhaCungCap Instance 
        { 
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DAL_NhaCungCap();
                }
                return _Instance;
            }
            private set { }
        }
	private DAL_NhaCungCap() { }
        public NhaCungCap GetNhaCungCap(DataRow i)
        {
            return new NhaCungCap
            {
                IDNCC = i["idncc"].ToString(),
                TenNCC = i["tenncc"].ToString(),
                DiaChiNCC = i["diachi"].ToString(),
                EmailNCC = i["email"].ToString()
            };
        }
        public List<NhaCungCap> GetAllNhaCungCap()
        {
            List<NhaCungCap> l = new List<NhaCungCap>();
            string query = "select * from NhaCungCap";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetNhaCungCap(i));
            }
            return l;
        }
        public bool Add(NhaCungCap NCC)
        {
            try
            {
                string query = string.Format("insert NhaCungCap(idncc, tenncc, diachi, email) " +
                    "values ('{0}', '{1}', '{2}', '{3}')",
                    NCC.IDNCC, NCC.TenNCC, NCC.DiaChiNCC, NCC.EmailNCC);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(NhaCungCap NCC)
        {
            try
            {
                string query = string.Format("update NhaCungCap " +
                    "set tenncc = '{0}', " +
                    "diachi = '{1}', " +
                    "email = '{2}' " +
                    "where idncc = '{3}'",
                    NCC.TenNCC, NCC.DiaChiNCC, NCC.EmailNCC, NCC.IDNCC);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(string IDNCC)
        {
            try
            {
                string query = string.Format("delete from NhaCungCap where idncc = '{0}'", IDNCC);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<NhaCungCap> Search_DAL(string name)
        {
            List<NhaCungCap> l = new List<NhaCungCap>();
            string query = string.Format(
                "select idncc, tenncc, diachi, email from NhaCungCap " +
                "where tenncc like N'%{0}%'", name);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetNhaCungCap(i));
            }
            return l;
        }
    }
}

