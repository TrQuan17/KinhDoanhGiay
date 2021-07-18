using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fChiTietThongTinSP : Form
    {
        public string IDSP { get; set; }
        public static string DuongDan = "C:/Users/Admin/Downloads/PBL3/PBL_Image/";
        public fChiTietThongTinSP(string s)
        {
            InitializeComponent();
            IDSP = s;
            GUI();
        }
        public void GUI()
        {
            if(IDSP != null)
            {
                if (IDSP != null)
                {
                    SanPham SP = BLL_SanPham.Instance.GetSanPhamByID(IDSP);
                    lbID.Text = SP.IDSP;
                    lbName.Text = SP.TenSP;
                    lbSize.Text = SP.SizeSP.ToString();
                    lbPrice.Text = SP.DonGiaSP.ToString();
                    picSP.SizeMode = PictureBoxSizeMode.StretchImage;
                    picSP.ImageLocation = DuongDan + BLL_HinhAnhSanPham.Instance.GetLinkImageByIDSP(IDSP);
                    lbFirm.Text = BLL_SanPham.Instance.GetHangGiayByIDSP(IDSP);
                }
            }
        }
    }
}
