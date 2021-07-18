using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_HinhAnhSanPham
    {
        private static DAL_HinhAnhSanPham _Instance;

        public static DAL_HinhAnhSanPham Instance 
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DAL_HinhAnhSanPham();
                }
                return _Instance;
            }
            private set { } 
        }
        private DAL_HinhAnhSanPham() { }
        public HinhAnhSanPham GetHinhAnhSanPham(DataRow i)
        {
            return new HinhAnhSanPham
            {
                ID = Convert.ToInt32(i["id"].ToString()),
                IDSP = i["idsp"].ToString(),
                LinkImage = i["linkimage"].ToString()
            };
        }
        public List<HinhAnhSanPham> GetAllHASP()
        {
            List<HinhAnhSanPham> l = new List<HinhAnhSanPham>();
            string query = string.Format("select * from HinhAnhSanPham");
            foreach(DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetHinhAnhSanPham(i));
            }
            return l;
        }
        public bool Add(HinhAnhSanPham ISP)
        {
            try
            {
                string query = string.Format("insert HinhAnhSanPham(idsp, linkimage) " +
                    "values ('{0}', '{1}')",
                    ISP.IDSP, ISP.LinkImage);
                DBHelper.Instance.excuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Edit(HinhAnhSanPham ISP)
        {
            try
            {
                string query = string.Format("update HinhAnhSanPham " +
                    "set linkimage = '{0}' where idsp = '{1}'",
                    ISP.LinkImage, ISP.IDSP);
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
