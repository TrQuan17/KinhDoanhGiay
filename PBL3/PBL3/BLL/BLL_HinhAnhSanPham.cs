using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_HinhAnhSanPham
    {
        private static BLL_HinhAnhSanPham _Instance;
        public static BLL_HinhAnhSanPham Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HinhAnhSanPham();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_HinhAnhSanPham() { }
        public string GetLinkImageByIDSP(string IDSP)
        {
            string Link = "";
            foreach(HinhAnhSanPham i in DAL_HinhAnhSanPham.Instance.GetAllHASP())
            {
                if(IDSP == i.IDSP)
                {
                    Link = i.LinkImage;
                }
            }
            return Link;
        }
        public bool ExecuteDB_BLL(HinhAnhSanPham ISP)
        {
            bool check = false;
            foreach (HinhAnhSanPham i in DAL_HinhAnhSanPham.Instance.GetAllHASP())
            {
                if (ISP.IDSP == i.IDSP)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                return DAL_HinhAnhSanPham.Instance.Add(ISP);
            }
            else
            {
                return DAL_HinhAnhSanPham.Instance.Edit(ISP);
            }
        }
    }
}
