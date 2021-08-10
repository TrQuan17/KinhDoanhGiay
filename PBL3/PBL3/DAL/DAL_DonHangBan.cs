using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_DonHangBan
    {
        private static DAL_DonHangBan _Instance;

        public static DAL_DonHangBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_DonHangBan();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_DonHangBan() { }
        public DonHangBan GetDonHangBan(DataRow i)
        {
            return new DonHangBan
            {
                IDBan = Convert.ToInt32(i["idban"].ToString()),
                IDNV = i["idnv"].ToString(),
                IDKH = i["idkh"].ToString(),
                NgayBan = Convert.ToDateTime(i["ngayban"].ToString()),
                TongTienBan = Convert.ToDouble(i["tongtienban"])
            };
        }
        public List<DonHangBan> GetAllDonHangBan()
        {
            List<DonHangBan> l = new List<DonHangBan>();
            string query = "select * from DonHangBan";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetDonHangBan(i));
            }
            return l;
        }
        public bool Add(DonHangBan DHB)
        {
            try
            {
                string query = string.Format("insert DonHangBan(idnv, idkh, ngayban, tongtienban) " +
                    "values ('{0}', '{1}', '{2}', {3})",
                    DHB.IDNV, DHB.IDKH, DHB.NgayBan.ToString("yyyy-MM-dd"), DHB.TongTienBan);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(DonHangBan DHB)
        {
            try
            {
                string query = string.Format("update DonHangBan " +
                    "set idnv = '{0}', " +
                    "idkh = '{1}', " +
                    "ngayban = '{2}', " +
                    "tongtienban = {3} " +
                    "where idnban = {4}",
                    DHB.IDNV, DHB.IDKH, DHB.NgayBan.ToString("yyyy-MM-dd"), DHB.TongTienBan, DHB.IDBan);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(int IDBan)
        {
            try
            {
                string query = string.Format("delete from DonHangBan where idban = {0}", IDBan);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<DonHangBan> Search_DAL(string idnv)
        {
            List<DonHangBan> l = new List<DonHangBan>();
            string query = string.Format(
                "select idban, idnv, idkh, ngayban, tongtienban from DonHangBan " +
                "where idnv like N'%{0}%'", idnv);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetDonHangBan(i));
            }
            return l;
        }
        
        public void AddBill(string IDNV, string IDKH, string NgayBan, string TongTienBan)
        {
            string query = string.Format("INSERT dbo.DonHangBan(idnv,idkh,ngayban,tongtienban) OUTPUT inserted.idban VALUES  ( '{0}','{1}','{2}',{3})", IDNV, IDKH, NgayBan, TongTienBan );
            DBHelper.Instance.ExcuteNonQuery(query);
        }
        public string GetNextIdBill()
        {
            string query = string.Format("SELECT MAX(idban) FROM dbo.DonHangBan");
            string id = DBHelper.Instance.ExcuteScalar(query).ToString();
            return id;
        }
        public List<DonHangBan> GetDonHangBanByDate(DateTime d1, DateTime d2)
        {
            List<DonHangBan> l = new List<DonHangBan>();
            string query = string.Format("select idban, idnv, idkh, ngayban, tongtienban from DonHangBan " +
                "where ngayban >= '{0}' and ngayban <= '{1}'", d1.ToString("yyyy-MM-dd"), d2.ToString("yyyy-MM-dd"));
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetDonHangBan(i));
            }
            return l;
        }
        public double GetTongTienByDate_DHB(List<DonHangBan> lDHB)
        {
            double s = 0;
            foreach(DonHangBan i in lDHB)
            {
                s = s + i.TongTienBan;
            }
            return s;
        }
        public double GetMaxTongTienBan(List<DonHangBan> lDHB)
        {
            double maxTongTien = 0;
            foreach(DonHangBan i in lDHB)
            {
                if (maxTongTien < i.TongTienBan) maxTongTien = i.TongTienBan;
            }
            return maxTongTien;
        }
        public double GetMinTongTienBan(List<DonHangBan> lDHB)
        {
            double minTongTien = GetMaxTongTienBan(lDHB);
            foreach (DonHangBan i in lDHB)
            {
                if (minTongTien > i.TongTienBan) minTongTien = i.TongTienBan;
            }
            return minTongTien;
        }
    }
}
