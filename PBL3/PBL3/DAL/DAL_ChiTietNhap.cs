using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_ChiTietNhap
    {
        private static DAL_ChiTietNhap _Instance;
        public static DAL_ChiTietNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ChiTietNhap();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_ChiTietNhap() { }
        public ChiTietNhap GetChiTietNhap(DataRow i)
        {
            return new ChiTietNhap()
            {
                IDNhap = int.Parse(i["idnhap"].ToString()),
                IDSP = i["idsp"].ToString(),
                DonGiaNhap = double.Parse(i["dongianhap"].ToString()),
                SoLuongNhap = int.Parse(i["soluongnhap"].ToString())
            };
        }
        public List<ChiTietNhap> GetAllChiTietNhap(int idn)
        {
            List<ChiTietNhap> l = new List<ChiTietNhap>();
            string query = string.Format("select * from chitietnhap where idnhap = {0}", idn);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetChiTietNhap(i));
            }
            return l;
        }
        public ChiTietNhap GetAllChiTietNhapByID(int idn, string idsp)
        {
            ChiTietNhap ctn = new ChiTietNhap();
            string query = string.Format("select * from chitietnhap where idnhap = {0} and idsp = '{1}'", idn, idsp);
            if (DBHelper.Instance.GetReCords(query).Rows.Count > 0)
            {
                ctn = GetChiTietNhap(DBHelper.Instance.GetReCords(query).Rows[0]);
            }
            else
            {
                ctn = null;
            }

            return ctn;
        }
        public bool Add(ChiTietNhap ctn)
        {
            try
            {
                string query = string.Format("insert ChiTietNhap(idnhap, idsp, dongianhap, soluongnhap) " +
                    "values ({0}, '{1}', {2}, {3})",
                    ctn.IDNhap, ctn.IDSP, ctn.DonGiaNhap, ctn.SoLuongNhap);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(ChiTietNhap ctn)
        {
            try
            {
                string query = string.Format("update ChiTietNhap " +
                    "set soluongnhap = {2} " +
                    "where idnhap = {0} and idsp = '{1}'",
                    ctn.IDNhap, ctn.IDSP, ctn.SoLuongNhap);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(int IDNhap, string idsp)
        {
            try
            {
                string query = string.Format("delete from ChiTietNhap where idnhap = {0} and idsp = '{1}'", IDNhap, idsp);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

