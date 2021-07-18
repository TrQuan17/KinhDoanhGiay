using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_DonHangBan
    {
        private static BLL_DonHangBan _Instance;
        public static BLL_DonHangBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DonHangBan();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_DonHangBan() { }

        public void AddBill_BLL(string IDNV, string IDKH, string NgayBan, string TongTienBan)
        {
            DAL_DonHangBan.Instance.AddBill(IDNV, IDKH, NgayBan, TongTienBan);
        }
        public string GetNextIdBill_BLL()
        {
            return DAL_DonHangBan.Instance.GetNextIdBill();
        }

        public List<DonHangBan> GetAllDonHangBan_BLL()
        {
            return DAL_DonHangBan.Instance.GetAllDonHangBan();
        }

        public bool Del_BLL(int IdBan)
        {
            return DAL_DonHangBan.Instance.Del(IdBan);
        }
        public List<DonHangBan> GetDonHangBanByDate_BLL(DateTime d1, DateTime d2)
        {
            return DAL_DonHangBan.Instance.GetDonHangBanByDate(d1, d2);
        }
        public double GetTongTienByDate_DHB_BLL(List<DonHangBan> lDHB)
        {
            return DAL_DonHangBan.Instance.GetTongTienByDate_DHB(lDHB);
        }
        public double GetMaxTongTienBan_BLL(List<DonHangBan> lDHB)
        {
            return DAL_DonHangBan.Instance.GetMaxTongTienBan(lDHB);
        }
        public double GetMinTongTienBan_BLL(List<DonHangBan> lDHB)
        {
            return DAL_DonHangBan.Instance.GetMinTongTienBan(lDHB);
        }
        public double GetTongTienByIDNV(string IDNV, List<DonHangBan> lDHB)
        {
            double s = 0;
            foreach(DonHangBan i in lDHB)
            {
                if(i.IDNV == IDNV)
                {
                    s = s + i.TongTienBan;
                }
            }
            return s;
        }
        public string GetIDNVBanMax(List<DonHangBan> lDHB)
        {
            string IDNV = "";
            double max = 0;
            foreach(DonHangBan i in lDHB)
            {
                if(max < GetTongTienByIDNV(i.IDNV, lDHB))
                {
                    max = GetTongTienByIDNV(i.IDNV, lDHB);
                    IDNV = i.IDNV;
                }
            }
            return IDNV;
        }
    }
}
