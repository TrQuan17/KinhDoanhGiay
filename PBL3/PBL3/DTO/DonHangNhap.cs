using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class DonHangNhap
    {
        public int IDNhap { get; set; }
        public string IDNV { get; set; }
        public string IDNCC { get; set; }
        public DateTime NgayNhap { get; set; }
        public double TongTienNhap { get; set; }
    }
}
