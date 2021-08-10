using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_ThanhToan
    {
        private static DAL_ThanhToan _Instance;

        internal static DAL_ThanhToan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ThanhToan();
                }
                return _Instance;
            }
            private set { }
        }
        public ThanhToan GetThanhToan(DataRow i)
        {
            return new ThanhToan
            {
                idban = Convert.ToInt32(i["idban"]),
                idsp = i["idsp"].ToString(),
                soluongban = Convert.ToInt32(i["soluongban"]),
                namesp = i["tensp"].ToString(),
                giaban = Convert.ToDouble(i["dongiaban"])
            };
        }
        public List<ThanhToan> GetThanhToansByidban(int idban)
        {
            List<ThanhToan> l = new List<ThanhToan>();
            string query = string.Format("select ChiTietBan.*, SanPham.tensp, SanPham.dongiaban " +
                "from ChiTietBan, SanPham where ChiTietBan.idsp = SanPham.idsp and ChiTietBan.idban = {0};",
                idban);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetThanhToan(i));
            }
            return l;
        }
    }
}
