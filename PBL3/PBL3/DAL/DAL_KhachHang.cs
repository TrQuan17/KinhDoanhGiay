using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_KhachHang
    {
        private static DAL_KhachHang _Instance;

        public static DAL_KhachHang Instance 
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DAL_KhachHang();
                }
                return _Instance;
            }
            private set { } 
        }
        private DAL_KhachHang() { }
        public KhachHang GetKhachHang(DataRow i)
        {
            return new KhachHang
            {
                IDKH = i["idkh"].ToString(),
                TenKH = i["tenkh"].ToString(),
                GioiTinhKH = Convert.ToBoolean(i["gioitinhkh"].ToString()),
                DiaChiKH = i["diachikh"].ToString(),
                SDTKH = i["sdtkh"].ToString()
            };
        }
        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> l = new List<KhachHang>();
            string query = "select * from KhachHang";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetKhachHang(i));
            }
            return l;
        }
        public bool Add(KhachHang KH)
        {
            try
            {
                string query = string.Format("insert KhachHang(idkh, tenkh, gioitinhkh, diachikh, sdtkh) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    KH.IDKH, KH.TenKH, KH.GioiTinhKH, KH.DiaChiKH, KH.SDTKH);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(KhachHang KH)
        {
            try
            {
                string query = string.Format("update KhachHang " +
                    "set tenkh = '{0}', " +
                    "gioitinhkh = '{1}', " +
                    "diachikh = '{2}', " +
                    "sdtkh = '{3}' " +
                    "where idkh = '{4}'",
                    KH.TenKH, KH.GioiTinhKH, KH.DiaChiKH, KH.SDTKH, KH.IDKH);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(string IDKH)
        {
            try
            {
                string query = string.Format("delete from KhachHang where idkh = N'{0}'", IDKH);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<KhachHang> Search_DAL(string name)
        {
            List<KhachHang> l = new List<KhachHang>();
            string query = string.Format(
                "select idkh, tenkh, gioitinhkh, diachikh, sdtkh from KhachHang " +
                "where tenkh like N'%{0}%'", name);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetKhachHang(i));
            }
            return l;
        }

        public bool CheckSDT(string sdt)
        {
            List<KhachHang> l = new List<KhachHang>();
            string query = "select * from KhachHang";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetKhachHang(i));
            }
            foreach (KhachHang i in l )
            {
                if (sdt == i.SDTKH)
                    return true;
            }
            return false;
        }
    }
}
