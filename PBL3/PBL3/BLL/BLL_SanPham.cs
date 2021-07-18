using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_SanPham
    {
        private static BLL_SanPham _Instance;
        public static BLL_SanPham Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SanPham();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_SanPham() { }
        public List<SanPham> GetAllSanPham_BLL()
        {
            return DAL_SanPham.Instance.GetAllSanPham();
        }
        public SanPham GetSanPhamByID(string IDSP)
        {
            SanPham SP = new SanPham();
            foreach (SanPham i in DAL_SanPham.Instance.GetAllSanPham())
            {
                if (IDSP == i.IDSP)
                {
                    SP = i;
                }
            }
            return SP;
        }
        public bool ExecuteDB_BLL(SanPham SP)
        {
            bool check = false;
            foreach (SanPham i in DAL_SanPham.Instance.GetAllSanPham())
            {
                if (SP.IDSP == i.IDSP)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                return DAL_SanPham.Instance.Add(SP);
            }
            else
            {
                return DAL_SanPham.Instance.Edit(SP);
            }
        }
        public bool Del_BLL(string IDSP)
        {
            return DAL_SanPham.Instance.Del(IDSP);
        }
        public List<SanPham> Search(string name)
        {
            return DAL_SanPham.Instance.Search_DAL(name);
        }
        public List<SanPham> Search_Size(string name, int size)
        {
            return DAL_SanPham.Instance.Search_Size_DAL(name, size);
        }
        public void UpdateSoLuongGiay_BLL(int SoLuong, string IDSP)
        {
            DAL_SanPham.Instance.UpdateSoLuongGiay(SoLuong, IDSP);
        }
        public string GetSoLuongTrongKhoByIDSP_BLL(string IDSP)
        {
            return DAL_SanPham.Instance.GetSoLuongTrongKhoByIDSP(IDSP);
        }
        public string GetHangGiayByIDSP(string IDSP)
        {
            string s = "";
            char[] a = new char[1000];
            foreach(SanPham i in GetAllSanPham_BLL())
            {
                if(i.IDSP == IDSP)
                {
                    s = i.TenSP;
                }
            }
            for(int j = 0; j < s.ToCharArray().Length; j++)
            {
                if(s.ToCharArray()[j] != ' ')
                    a[j] = s.ToCharArray()[j];
                else break;
            }
            return new string(a);
        }
        public List<SanPham> GetSPByHang(string hang)
        {
            List<SanPham> l = new List<SanPham>();
            foreach(SanPham i in GetAllSanPham_BLL())
            {
                if(hang == GetHangGiayByIDSP(i.IDSP))
                {
                    l.Add(i);
                }
            }
            return l;
        }
    }
}
