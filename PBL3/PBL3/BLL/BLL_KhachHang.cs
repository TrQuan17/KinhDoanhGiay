using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_KhachHang
    {
        private static BLL_KhachHang _Instance;
        public static BLL_KhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_KhachHang();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_KhachHang() { }
        public List<KhachHang> GetAllKhachHang_BLL()
        {
            return DAL_KhachHang.Instance.GetAllKhachHang();
        }
        public KhachHang GetKhachHangByID(string IDKH)
        {
            KhachHang KH = new KhachHang();
            foreach (KhachHang i in DAL_KhachHang.Instance.GetAllKhachHang())
            {
                if (IDKH == i.IDKH)
                {
                    KH = i;
                }
            }
            return KH;
        }
        public string GetIDKHByPhone(string phone)
        {
            string IDKH = "";
            foreach (KhachHang i in DAL_KhachHang.Instance.GetAllKhachHang())
            {
                if (phone == i.SDTKH)
                {
                    IDKH = i.IDKH;
                }
            }
            return IDKH;
        }
        public bool ExecuteDB_BLL(KhachHang KH)
        {
            bool check = false;
            foreach (KhachHang i in DAL_KhachHang.Instance.GetAllKhachHang())
            {
                if (KH.IDKH == i.IDKH)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                return DAL_KhachHang.Instance.Add(KH);
            }
            else
            {
                return DAL_KhachHang.Instance.Edit(KH);
            }
        }
        public bool Del_BLL(string IDKH)
        {
            return DAL_KhachHang.Instance.Del(IDKH);
        }
        public List<KhachHang> Search(string name)
        {
            return DAL_KhachHang.Instance.Search_DAL(name);
        }

        public bool CheckSDT_BLL(string sdt)
        {
            return DAL_KhachHang.Instance.CheckSDT(sdt);
        }
    }   
}
