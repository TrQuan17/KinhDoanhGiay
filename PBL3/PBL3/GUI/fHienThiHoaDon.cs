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
    public partial class fHienThiHoaDon : Form
    {
        public int IDBan { get; set; }
        public fHienThiHoaDon(int id)
        {
            InitializeComponent();
            IDBan = id;
            GUI();
        }
        public void GUI()
        {
            if(IDBan != 0)
            {
                dgvThanhToan.DataSource = BLL_ThanhToan.Instance.GetThanhToansbyidban_BLL(IDBan);
                dgvThanhToan.Columns["idban"].HeaderText = "Mã hóa đơn";
                dgvThanhToan.Columns["namesp"].HeaderText = "Tên sản phẩm";
                dgvThanhToan.Columns["soluongban"].HeaderText = "Số lượng bán";
                dgvThanhToan.Columns["giaban"].HeaderText = "Giá bán";
                dgvThanhToan.Columns["idsp"].Visible = false;
            }
            DonHangBan dhb = new DonHangBan();
            dhb = BLL_DonHangBan.Instance.GetDonHangBanbyIDBan(IDBan);
            lbIDKH.Text = dhb.IDKH;
            lbIDHD.Text = dhb.IDBan.ToString();
            lbNameNV.Text = BLL_NhanVien.Instance.GetNhanVienByID(dhb.IDNV).TenNV;
            lbNameKH.Text = BLL_KhachHang.Instance.GetKhachHangByID(dhb.IDKH).TenKH;
            lbNgay.Text = dhb.NgayBan.ToString("dd - MM - yyyy");
            lbTongTien.Text = dhb.TongTienBan.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
