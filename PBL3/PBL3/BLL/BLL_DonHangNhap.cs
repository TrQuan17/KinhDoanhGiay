using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_DonHangNhap
    {
        private static BLL_DonHangNhap _Instance;
        public static BLL_DonHangNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DonHangNhap();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_DonHangNhap() { }
        public List<DonHangNhap> GetAllDonHangNhap_BLL()
        {
            return DAL_DonHangNhap.Instance.GetAllDonHangNhap();
        }
        public DonHangNhap GetDonHangNhapByID(int IDNhap)
        {
            DonHangNhap DHN = new DonHangNhap();
            foreach (DonHangNhap i in DAL_DonHangNhap.Instance.GetAllDonHangNhap())
            {
                if (IDNhap == i.IDNhap)
                {
                    DHN = i;
                }
            }
            return DHN;
        }
        public bool ExecuteDB_BLL(DonHangNhap DHN)
        {
            bool check = false;
            foreach (DonHangNhap i in DAL_DonHangNhap.Instance.GetAllDonHangNhap())
            {
                if (DHN.IDNhap == i.IDNhap)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                return DAL_DonHangNhap.Instance.Add(DHN);
            }
            else
            {
                return DAL_DonHangNhap.Instance.Edit(DHN);
            }
        }
        public bool ADD_BLL(DonHangNhap DHN)
        {
            return DAL_DonHangNhap.Instance.Add(DHN);
        }
        public bool Edit_BLL(DonHangNhap DHN)
        {
            return DAL_DonHangNhap.Instance.Edit(DHN);
        }
        public bool Del_BLL(int IDNhap)
        {
            return DAL_DonHangNhap.Instance.Del(IDNhap);
        }
        public List<DonHangNhap> Search(int name)
        {
            return DAL_DonHangNhap.Instance.Search_DAL(name);
        }
    }
}
