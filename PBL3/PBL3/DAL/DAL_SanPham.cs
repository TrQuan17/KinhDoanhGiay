using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_SanPham
    {
        private static DAL_SanPham _Instance;

        public static DAL_SanPham Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_SanPham();
                }
                return _Instance;
            }
            private set { }
        }
        public SanPham GetSanPham(DataRow i)
        {
            return new SanPham
            {
                IDSP = i["idsp"].ToString(),
                TenSP = i["tensp"].ToString(),
                SizeSP = Convert.ToInt32(i["size"].ToString()),
                SoLuongSP = Convert.ToInt32(i["soluongtrongkho"].ToString()),
                DonGiaSP = Convert.ToDouble(i["dongiaban"].ToString())
            };
        }
        public List<SanPham> GetAllSanPham()
        {
            List<SanPham> l = new List<SanPham>();
            string query = "select * from SanPham";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetSanPham(i));
            }
            return l;
        }
        public bool Add(SanPham SP)
        {
            try
            {
                string query = string.Format("insert SanPham(idsp, tensp, size, soluongtrongkho, dongiaban) " +
                    "values ('{0}', '{1}', {2}, {3}, {4})",
                    SP.IDSP, SP.TenSP, SP.SizeSP, SP.SoLuongSP, SP.DonGiaSP);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(SanPham SP)
        {
            try
            {
                string query = string.Format("update SanPham " +
                    "set tensp = '{0}', " +
                    "size = {1}, " +
                    "soluongtrongkho = {2}, " +
                    "dongiaban = {3} " +
                    "where idsp = '{4}'",
                    SP.TenSP, SP.SizeSP, SP.SoLuongSP, SP.DonGiaSP, SP.IDSP);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(string IDSP)
        {
            try
            {
                string query = string.Format("delete from SanPham where idsp = '{0}'", IDSP);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<SanPham> Search_DAL(string name)
        {
            List<SanPham> l = new List<SanPham>();
            string query = string.Format(
                "select idsp, tensp, size, soluongtrongkho, dongiaban from SanPham " +
                "where tensp like N'%{0}%'", name);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetSanPham(i));
            }
            return l;
        }
        public List<SanPham> Search_Size_DAL(string name, int size)
        {
            List<SanPham> l = new List<SanPham>();
            string query = string.Format(
                "select idsp, tensp, size, soluongtrongkho, dongiaban from SanPham " +
                "where (tensp like N'%{0}%' and size = {1}) ", name, size);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetSanPham(i));
            }
            return l;
        }
        public void UpdateSoLuongGiay(int SoLuong, string IDSP)
        {
            string query = string.Format("update SanPham set soluongtrongkho = {0} where idsp = '{1}' ", SoLuong, IDSP);
            DBHelper.Instance.excuteDB(query);
        }
        public string GetSoLuongTrongKhoByIDSP(string IDSP)
        {
            string query = string.Format("SELECT soluongtrongkho FROM dbo.SanPham where idsp = '{0}'", IDSP);
            string id = DBHelper.Instance.ExcuteScalar(query).ToString();
            return id;
        }
    }
}
