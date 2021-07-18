using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DAL_ChiTietBan
    {
        private static DAL_ChiTietBan _Instance;

        public static DAL_ChiTietBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ChiTietBan();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_ChiTietBan() { }
        public bool AddShoesInBill(int IDBill, string IDSanPham, string SoLuongBan)
        {
            try
            {
                string query = string.Format("INSERT dbo.ChiTietBan(idban,idsp,soluongban) VALUES ( {0}, '{1}', '{2}' )",
                    IDBill, IDSanPham, SoLuongBan);
                DBHelper.Instance.ExcuteNonQuery(query);
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public ChiTietBan GetChiTietBan(DataRow i)
        {
            return new ChiTietBan
            {
                IDBan = i["idban"].ToString(),
                IDSP = i["idsp"].ToString(),         
                SoLuongBan = Convert.ToInt32(i["soluongban"])
            };
        }
        public List<ChiTietBan> GetAllChiTietBan()
        {
            List<ChiTietBan> l = new List<ChiTietBan>();
            string query = "select * from ChiTietBan";
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetChiTietBan(i));
            }
            return l;
        }

        public List<ChiTietBan> GetChiTietBanByIdBan(int IdBan)
        {
            List<ChiTietBan> l = new List<ChiTietBan>();
            string query = string.Format("select * from ChitietBan where idban = {0}", IdBan);
            foreach (DataRow i in DBHelper.Instance.GetReCords(query).Rows)
            {
                l.Add(GetChiTietBan(i));
            }
            return l;
        }
        public int GetSoLuongBanByIDSP(string IDSP, List<ChiTietBan> lCTB)
        {
            int SL = 0;
            foreach (ChiTietBan i in lCTB)
            {
                if (IDSP == i.IDSP) SL = SL + i.SoLuongBan;
            }
            return SL;
        }
        public string GetIDSPBanMax(List<ChiTietBan> lCTB)
        {
            int s = 0;
            string IDSPMax = "";
            foreach(ChiTietBan i in lCTB)
            {
                if (s < GetSoLuongBanByIDSP(i.IDSP, lCTB)) s = GetSoLuongBanByIDSP(i.IDSP, lCTB);
            }
            foreach (ChiTietBan i in lCTB)
            {
                if (s == GetSoLuongBanByIDSP(i.IDSP, lCTB)) IDSPMax = i.IDSP;
            }
            return IDSPMax;
        }
    }
}
