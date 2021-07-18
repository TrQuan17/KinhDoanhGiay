using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_ChiTietBan
    {
        private static BLL_ChiTietBan _Instance;
        public static BLL_ChiTietBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ChiTietBan();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ChiTietBan() { }

        public bool ADDShoesInBill_BLL(int IDBill, string IDSanPham, string SoLuongBan)
        {
            return DAL_ChiTietBan.Instance.AddShoesInBill(IDBill, IDSanPham, SoLuongBan);
        }

        public List<ChiTietBan> GetAllChiTietBan_BLL()
        {
            return DAL_ChiTietBan.Instance.GetAllChiTietBan();
        }

        public List<ChiTietBan> GetChiTietBanByIdBan_BLL(int IdBan)
        {
            return DAL_ChiTietBan.Instance.GetChiTietBanByIdBan(IdBan);
        }
        public string GetIDSPBanMax_BLL(List<ChiTietBan> lCTB)
        {
            return DAL_ChiTietBan.Instance.GetIDSPBanMax(lCTB);
        }
    }
}
