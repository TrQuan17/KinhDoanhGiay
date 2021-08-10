using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_ThanhToan
    {
        private static BLL_ThanhToan _Instance;

        public static BLL_ThanhToan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ThanhToan();
                }
                return _Instance;
            }
            private set { }
        }
        public BLL_ThanhToan() { }
        public List<ThanhToan> GetThanhToansbyidban_BLL(int idban)
        {
            return DAL_ThanhToan.Instance.GetThanhToansByidban(idban);
        }
    }
}
