using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_DonHangNhap
    {
        private static DAL_DonHangNhap _Instance;

        public static DAL_DonHangNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_DonHangNhap();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_DonHangNhap() { }
        public DonHangNhap GetDonHangNhap(DataRow i)
        {
            return new DonHangNhap
            {
                IDNhap = Convert.ToInt32(i["idnhap"].ToString()),
                IDNV = i["idnv"].ToString(),
                IDNCC = i["idncc"].ToString(),
                NgayNhap = Convert.ToDateTime(i["ngaynhap"].ToString()),
                TongTienNhap = Convert.ToDouble(i["tongtiennhap"].ToString())
            };
        }
        public List<DonHangNhap> GetAllDonHangNhap()
        {
            List<DonHangNhap> l = new List<DonHangNhap>();
            string query = "select * from DonHangNhap";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetDonHangNhap(i));
            }
            return l;
        }
        public bool Add(DonHangNhap DHN)
        {
            try
            {
                string query = string.Format("insert DonHangNhap(idnv, idncc, ngaynhap, tongtiennhap) " +
                    "values ('{0}', '{1}', '{2}', {3})",
                    DHN.IDNV, DHN.IDNCC, DHN.NgayNhap.ToString("yyyy-MM-dd"), DHN.TongTienNhap);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(DonHangNhap DHN)
        {
            try
            {
                string query = string.Format("update DonHangNhap " +
                    "set idnv = '{0}', " +
                    "idncc = '{1}', " +
                    "ngaynhap = '{2}', " +
                    "tongtiennhap = {3} " +
                    "where idnhap = {4}",
                    DHN.IDNV, DHN.IDNCC, DHN.NgayNhap.ToString("yyyy-MM-dd"), DHN.TongTienNhap, DHN.IDNhap);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(int IDNhap)
        {
            try
            {
                string query = string.Format("delete from DonHangNhap where idnhap = {0}", IDNhap);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<DonHangNhap> Search_DAL(int idnhap)
        {
            List<DonHangNhap> l = new List<DonHangNhap>();
            string query = string.Format(
                "select * from DonHangNhap " +
                "where idnhap = {0} ", idnhap);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetDonHangNhap(i));
            }
            return l;
        }
    }
}
