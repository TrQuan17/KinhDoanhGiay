using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_ChiTietNhap
    {
        private static BLL_ChiTietNhap _Instance;
        public static BLL_ChiTietNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ChiTietNhap();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ChiTietNhap() { }

        public List<ChiTietNhap> GetAllChiTietNhap_BLL(int idnhap)
        {
            return DAL_ChiTietNhap.Instance.GetAllChiTietNhap(idnhap);
        }
        public ChiTietNhap GetChiTietNhapByID(int IDNhap, string idsp)
        {
            ChiTietNhap DHN = new ChiTietNhap();
            DHN = DAL_ChiTietNhap.Instance.GetAllChiTietNhapByID(IDNhap, idsp);

            return DHN;
        }
        public bool ExecuteDB_BLL(ChiTietNhap CTN)
        {
            bool check = false;
            foreach (ChiTietNhap i in DAL_ChiTietNhap.Instance.GetAllChiTietNhap(CTN.IDNhap))
            {
                if (CTN.IDNhap == i.IDNhap && CTN.IDSP == i.IDSP)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                return DAL_ChiTietNhap.Instance.Add(CTN);
            }
            else
            {
                return DAL_ChiTietNhap.Instance.Edit(CTN);
            }
        }
        public bool Del_BLL(int IDNhap, string idsp)
        {
            return DAL_ChiTietNhap.Instance.Del(IDNhap, idsp);
        }

    }
}
