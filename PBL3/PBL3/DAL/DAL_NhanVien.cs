using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_NhanVien
    {
        private static DAL_NhanVien _Instance;

        public static DAL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_NhanVien();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_NhanVien() { }
        public NhanVien GetNhanVien(DataRow i)
        {
            return new NhanVien
            {
                IDNV = i["idnv"].ToString(),
                TenNV = i["tennv"].ToString(),
                GioiTinhNV = Convert.ToBoolean(i["gioitinhnv"].ToString()),
                TuoiNV = Convert.ToInt32(i["tuoi"].ToString()),
                DiaChiNV = i["diachi"].ToString(),
                SDTNV = i["sdtnv"].ToString()
            };
        }
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> l = new List<NhanVien>();
            string query = "select * from NhanVien";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetNhanVien(i));
            }
            return l;
        }
        public bool Add(NhanVien NV)
        {
            try
            {
                string query = string.Format("insert NhanVien(idnv, tennv, gioitinhnv, tuoi, diachi, sdtnv) " +
                    "values ('{0}', '{1}', '{2}', {3}, '{4}', '{5}')",
                    NV.IDNV, NV.TenNV, NV.GioiTinhNV, NV.TuoiNV, NV.DiaChiNV, NV.SDTNV);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(NhanVien NV)
        {
            try
            {
                string query = string.Format("update NhanVien " +
                    "set tennv = '{0}', " +
                    "gioitinhnv = '{1}', " +
                    "tuoi = {2}, " +
                    "diachi = '{3}', " +
                    "sdtnv = '{4}' " + 
                    "where idnv = '{5}'",
                    NV.TenNV, NV.GioiTinhNV, NV.TuoiNV, NV.DiaChiNV, NV.SDTNV, NV.IDNV);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(string IDNV)
        {
            try
            {
                string query = string.Format("delete from NhanVien where idnv = '{0}'", IDNV);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<NhanVien> Search_DAL(string name)
        {
            List<NhanVien> l = new List<NhanVien>();
            string query = string.Format(
                "select idnv, tennv, gioitinhnv, tuoi, diachi, sdtnv from NhanVien " +
                "where tennv like N'%{0}%'", name);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetNhanVien(i));
            }
            return l;
        }
    }
}
