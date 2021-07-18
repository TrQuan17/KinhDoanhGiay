using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_NhaCungCap
    {
        private static BLL_NhaCungCap _Instance;
        public static BLL_NhaCungCap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhaCungCap();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_NhaCungCap() { }
        public List<NhaCungCap> GetAllNhaCungCap_BLL()
        {
            return DAL_NhaCungCap.Instance.GetAllNhaCungCap();
        }
        public NhaCungCap GetNhaCungCapByID(string IDNCC)
        {
            NhaCungCap NCC = new NhaCungCap();
            foreach (NhaCungCap i in DAL_NhaCungCap.Instance.GetAllNhaCungCap())
            {
                if (IDNCC == i.IDNCC)
                {
                    NCC = i;
                }
            }
            return NCC;
        }
        public bool ExecuteDB_BLL(NhaCungCap NCC)
        {
            bool check = false;
            foreach (NhaCungCap i in DAL_NhaCungCap.Instance.GetAllNhaCungCap())
            {
                if (NCC.IDNCC == i.IDNCC)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                return DAL_NhaCungCap.Instance.Add(NCC);
            }
            else
            {
                return DAL_NhaCungCap.Instance.Edit(NCC);
            }
        }
        public bool Del_BLL(string IDNCC)
        {
            return DAL_NhaCungCap.Instance.Del(IDNCC);
        }
        public List<NhaCungCap> Search(string name)
        {
            return DAL_NhaCungCap.Instance.Search_DAL(name);
        }
    }
}