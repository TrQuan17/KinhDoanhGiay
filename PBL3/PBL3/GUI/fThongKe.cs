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
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }
        public string ChuyenDinhDang(double d)
        {
            return string.Format("{0:#,##0} VNĐ", d);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DateTime d1 = dtpStart.Value.Date;
            DateTime d2 = dtpEnd.Value.Date;

            List<DonHangBan> lDHB = new List<DonHangBan>();
            lDHB = BLL_DonHangBan.Instance.GetDonHangBanByDate_BLL(d1, d2);

            List<ChiTietBan> lCTB = new List<ChiTietBan>();
            foreach(DonHangBan i in lDHB)
            {
                foreach(ChiTietBan j in BLL_ChiTietBan.Instance.GetChiTietBanByIdBan_BLL(i.IDBan))
                {
                    lCTB.Add(j);
                }
            }
            if (DateTime.Compare(d1, d2) > 0 )
            {
                MessageBox.Show("Thời gian không hợp lệ !!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvDonHang.DataSource = lDHB;
                if (dgvDonHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không có đơn hàng trong khoảng thời gian này !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtTongTien.Text = ChuyenDinhDang(BLL_DonHangBan.Instance.GetTongTienByDate_DHB_BLL(lDHB));
                lbMax.Text = ChuyenDinhDang(BLL_DonHangBan.Instance.GetMaxTongTienBan_BLL(lDHB));
                lbMin.Text = ChuyenDinhDang(BLL_DonHangBan.Instance.GetMinTongTienBan_BLL(lDHB));
                lbHot.Text = BLL_SanPham.Instance.GetSanPhamByID(BLL_ChiTietBan.Instance.GetIDSPBanMax_BLL(lCTB)).TenSP;
                lbNVbest.Text = BLL_NhanVien.Instance.GetNhanVienByID(BLL_DonHangBan.Instance.GetIDNVBanMax(lDHB)).TenNV;               
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            List<DonHangBan> lDHB_All = new List<DonHangBan>();
            lDHB_All = BLL_DonHangBan.Instance.GetAllDonHangBan_BLL();

            List<ChiTietBan> lCTB_All = new List<ChiTietBan>();
            foreach (DonHangBan i in lDHB_All)
            {
                foreach (ChiTietBan j in BLL_ChiTietBan.Instance.GetChiTietBanByIdBan_BLL(i.IDBan))
                {
                    lCTB_All.Add(j);
                }
            }
            
            dgvDonHang.DataSource = lDHB_All;
            if (dgvDonHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có đơn hàng bán !!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTongTien.Text = ChuyenDinhDang(BLL_DonHangBan.Instance.GetTongTienByDate_DHB_BLL(lDHB_All));
            lbMax.Text = ChuyenDinhDang(BLL_DonHangBan.Instance.GetMaxTongTienBan_BLL(lDHB_All));
            lbMin.Text = ChuyenDinhDang(BLL_DonHangBan.Instance.GetMinTongTienBan_BLL(lDHB_All));
            lbHot.Text = BLL_SanPham.Instance.GetSanPhamByID(BLL_ChiTietBan.Instance.GetIDSPBanMax_BLL(lCTB_All)).TenSP;
            lbNVbest.Text = BLL_NhanVien.Instance.GetNhanVienByID(BLL_DonHangBan.Instance.GetIDNVBanMax(lDHB_All)).TenNV;
            
            
        }
    }
}
