using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_NhanVien
    {
        private static BLL_NhanVien _Instance;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhanVien();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_NhanVien() { }
        public List<NhanVien> GetAllNhanVien_BLL()
        {
            return DAL_NhanVien.Instance.GetAllNhanVien();
        }
        public NhanVien GetNhanVienByID(string IDNV)
        {
            NhanVien NV = new NhanVien();
            foreach (NhanVien i in DAL_NhanVien.Instance.GetAllNhanVien())
            {
                if (IDNV == i.IDNV)
                {
                    NV = i;
                }
            }
            return NV;
        }
        public bool ExecuteDB_BLL(NhanVien NV)
        {
            bool check = false;
            foreach (NhanVien i in DAL_NhanVien.Instance.GetAllNhanVien())
            {
                if (NV.IDNV == i.IDNV)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                return DAL_NhanVien.Instance.Add(NV);
            }
            else
            {
                return DAL_NhanVien.Instance.Edit(NV);
            }
        }
        public bool Del_BLL(string IDNV)
        {
            return DAL_NhanVien.Instance.Del(IDNV);
        }
        public List<NhanVien> Search(string name)
        {
            return DAL_NhanVien.Instance.Search_DAL(name);
        }
    }
}
