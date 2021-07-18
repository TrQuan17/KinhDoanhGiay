using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class ChiTietNhap
    {
        public int IDNhap { get; set; }
        public string IDSP { get; set; }
        public int SoLuongNhap { get; set; }
        public double DonGiaNhap { get; set; }
        public ChiTietNhap(int IDNhap, string idsp, double DonGiaNhap, int SoLuongNhap)
        {
            this.IDNhap = IDNhap;
            this.IDSP = idsp;
            this.DonGiaNhap = DonGiaNhap;
            this.SoLuongNhap = SoLuongNhap;
        }
        public ChiTietNhap(DataRow row)
        {
            this.IDNhap = int.Parse(row["idnhap"].ToString());
            this.IDSP = row["idsp"].ToString();
            this.DonGiaNhap = (double)Convert.ToDouble(row["dongianhap"].ToString());
            this.SoLuongNhap = (int)row["soluongphap"];
        }

        public ChiTietNhap()
        {
        }
    }
}
