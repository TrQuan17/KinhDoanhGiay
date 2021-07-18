using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fQLBanHang : Form
    {
        public fQLBanHang()
        {
            InitializeComponent();
            GUI();
            SetCBB();
        }
        public void GUI()
        {
            dgvBanHang.DataSource = BLL_SanPham.Instance.GetAllSanPham_BLL();
            lsvShoesSelected.View = View.Details;
            lsvShoesSelected.GridLines = true;
            lsvShoesSelected.FullRowSelect = true;

            txtSDTKH.Text = "";
            txtSDTKH.MaxLength = 10;
            labelDate.Text = "";
            txtTongTien.Text = "";
            txtSumPrice.Text = "";
            lsvShoesSelected.Items.Clear();

            string[] tieuchi = { "ID", "Tên", "Size", "Số Lượng", "Đơn Giá" };
            cbbSapXep.Items.AddRange(tieuchi);
        }
        public void SetCBB()
        {
            List<int> l = new List<int>();
            foreach (SanPham i in BLL_SanPham.Instance.GetAllSanPham_BLL())
            {
                l.Add(i.SizeSP);
            }
            l.Sort();
            foreach (int i in l.Distinct().ToList())
            {
                cbbSize.Items.Add(i);
            }
            foreach (NhanVien i in BLL_NhanVien.Instance.GetAllNhanVien_BLL())
            {
                cbbTenNV.Items.Add(new CBBItem { ID = i.IDNV, Name = i.TenNV });
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvBanHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm!");
            }
            else
            {
                int id = dgvBanHang.SelectedRows[0].Index;
                string IDGiay = dgvBanHang.Rows[id].Cells[0].Value.ToString();
                int AmountShoesKS = (int)Convert.ToInt32(dgvBanHang.Rows[id].Cells[3].Value.ToString());
                if (AmountShoesKS == 0) MessageBox.Show("Loại giày này đã hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ListViewItem item = lsvShoesSelected.FindItemWithText(IDGiay);
                    int SumPriceShoes;
                    if (item == null)
                    {
                        string NameShoes = dgvBanHang.Rows[id].Cells[1].Value.ToString();
                        string PriceShoes = dgvBanHang.Rows[id].Cells[4].Value.ToString();
                        string AmountShoes = "1";
                        SumPriceShoes = (int)Convert.ToInt32(PriceShoes) * (int)Convert.ToInt32(AmountShoes);
                        string SumPriceShoesStr = SumPriceShoes.ToString();
                        ListViewItem lvi = new ListViewItem(IDGiay);
                        lvi.SubItems.Add(NameShoes);
                        lvi.SubItems.Add(PriceShoes);
                        lvi.SubItems.Add(AmountShoes);
                        lvi.SubItems.Add(SumPriceShoesStr);
                        lsvShoesSelected.Items.Add(lvi);
                        this.lsvShoesSelected.Items[0].Selected = true;
                    }
                    else
                    {
                        this.lsvShoesSelected.Items[item.Index].Selected = true;
                        ListViewItem lvi = lsvShoesSelected.SelectedItems[0];
                        int OldAmount = (int)Convert.ToInt32(lvi.SubItems[3].Text);
                        int NewAmount = (int)Convert.ToInt32(lvi.SubItems[3].Text) + 1;
                        int NewSumPrice = (int)Convert.ToInt32(lvi.SubItems[4].Text) / OldAmount * NewAmount;
                        if (NewAmount > AmountShoesKS)
                        {
                            MessageBox.Show("Đã quá sô lượng giày đang có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            lvi.SubItems[3].Text = NewAmount.ToString();
                            lvi.SubItems[4].Text = NewSumPrice.ToString();
                        }
                    }
                    TinhTien();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvShoesSelected.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvShoesSelected.SelectedItems[0];

                int OldAmount = (int)Convert.ToInt32(lvi.SubItems[3].Text);
                int NewAmount = (int)Convert.ToInt32(lvi.SubItems[3].Text) - 1;
                int NewSumPrice = (int)Convert.ToInt32(lvi.SubItems[4].Text) - (int)Convert.ToInt32(lvi.SubItems[4].Text) / OldAmount;
                if (NewAmount < 1)
                {
                    DialogResult dlg = MessageBox.Show("Bạn có muốn xóa sản phẩm khỏi danh sách đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        lvi.Remove();
                    }
                }
                else
                {
                    lvi.SubItems[3].Text = NewAmount.ToString();
                    lvi.SubItems[4].Text = NewSumPrice.ToString();
                }
                TinhTien();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string PhoneNumber = txtSDTKH.Text;
            string SumAmount = txtSumPrice.Text;
            CBBItem getIDNV = (CBBItem)(cbbTenNV.SelectedItem);
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string DatePay1 = string.Format("{0}-{1}-{2}", month, day, year);
            string DatePay2 = string.Format("{0}-{1}-{2}", day, month, year);
            if (PhoneNumber == "" || getIDNV == null) MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string IDKH = BLL_KhachHang.Instance.GetIDKHByPhone(PhoneNumber);
                string IDNV = getIDNV.ID;
                BLL_DonHangBan.Instance.AddBill_BLL(IDNV, IDKH, DatePay1, SumAmount);
                int IdBill = Convert.ToInt32(BLL_DonHangBan.Instance.GetNextIdBill_BLL());
                int rowLV = 0;
                while (rowLV < lsvShoesSelected.Items.Count)
                {
                    ListViewItem lvi = lsvShoesSelected.Items[rowLV];
                    string IdShoes = lvi.SubItems[0].Text;
                    string AmountShoesInBill = lvi.SubItems[3].Text;

                    // 3 dòng code tiếp theo, update lại số lượng giày trong kho
                    int SoLuongTrongKho = Convert.ToInt32(BLL_SanPham.Instance.GetSoLuongTrongKhoByIDSP_BLL(IdShoes));
                    int SoLuongCapNhat = SoLuongTrongKho - Convert.ToInt32(AmountShoesInBill);
                    BLL_SanPham.Instance.UpdateSoLuongGiay_BLL(SoLuongCapNhat, IdShoes);

                    BLL_ChiTietBan.Instance.ADDShoesInBill_BLL(IdBill, IdShoes, AmountShoesInBill);
                    rowLV++;
                }
                GUI();
                string notify = string.Format("Hóa đơn có:\n-Mã hóa đơn: {0}\n-Mã khách hàng: {1}\n-Số điện thoại: {2}\n-Tổng số tiền GD: {3} VNĐ\n-Thời gian:{4}\n\nĐÃ ĐƯỢC THANH TOÁN", IdBill, IDKH, PhoneNumber, SumAmount, DatePay2);
                MessageBox.Show(notify, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "" && cbbSize.SelectedItem == null)
            {
                MessageBox.Show("Không đủ thông tin tìm kiếm !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbbSize.SelectedItem == null)
                {
                    dgvBanHang.DataSource = BLL_SanPham.Instance.Search(txtSearch.Text);
                }
                else
                {
                    dgvBanHang.DataSource = BLL_SanPham.Instance.Search_Size(txtSearch.Text, Convert.ToInt32(cbbSize.SelectedItem.ToString()));
                }
                if (dgvBanHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tên sản phẩm này !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string sdt = txtSDTKH.Text;
            if(sdt == "")
            {
                lbSDT.Text = "Để trống số điện thoại";
            }
            else
            {
                if (sdt.ToCharArray()[0] != '0' || sdt.Length < 10)
                {
                    lbSDT.Text = "Định dạng số điện thoại không đúng";
                }
                else
                {
                    lbSDT.Text = "";
                    if (BLL_KhachHang.Instance.CheckSDT_BLL(sdt) == true)
                    {
                        MessageBox.Show("thông tin khách hàng đã có ");
                    }
                    else MessageBox.Show("không tìm thấy thông tin khách hàng ");
                }
            }
        }
        private void btnTongTien_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            labelDate.Text = string.Format("{0}-{1}-{2}", day, month, year);
            int SumPay = 0;
            if (lsvShoesSelected.Items.Count > 0)
            {
                int i = 0;

                while (i < lsvShoesSelected.Items.Count)
                {
                    ListViewItem lvi = lsvShoesSelected.Items[i];
                    SumPay += (int)Convert.ToInt32(lvi.SubItems[4].Text);
                    i++;
                }
                btnThanhToan.Enabled = true;
            }
            else MessageBox.Show("Vui lòng chọn sản phẩm cần thanh toán", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CultureInfo culture = new CultureInfo("vi-VN");
            string SumPayStr = SumPay.ToString("c", culture);
            txtTongTien.Text = SumPayStr;
        }

        private void TinhTien()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            labelDate.Text = string.Format("{0}-{1}-{2}", day, month, year);

            double GiamGia = 0.0;
            if (txtGiamGia.Text == "")
            {
                GiamGia = 0.0;
            }
            else if (Convert.ToDouble(txtGiamGia.Text) >= 0 && Convert.ToDouble(txtGiamGia.Text) <= 100)
            {
                GiamGia = Convert.ToDouble(txtGiamGia.Text);
            }
            else
            {
                MessageBox.Show("Nhập giá trị giảm giá không hợp lệ");
            }


            double SumPay = 0.0;
            if (lsvShoesSelected.Items.Count > 0)
            {
                int i = 0;

                while (i < lsvShoesSelected.Items.Count)
                {
                    ListViewItem lvi = lsvShoesSelected.Items[i];
                    SumPay += (double)Convert.ToInt32(lvi.SubItems[4].Text);
                    i++;
                }

            }

            SumPay *= (100.0 - GiamGia) / 100;

            //CultureInfo culture = new CultureInfo("vi-VN");
            string SumPayStr = SumPay.ToString(); //.ToString("c", culture);
            txtSumPrice.Text = SumPayStr;
        }

        private void dgvBanHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string IDSP = dgvBanHang.SelectedRows[0].Cells["idsp"].Value.ToString();
                fChiTietThongTinSP f = new fChiTietThongTinSP(IDSP);
                f.ShowDialog();
            }
            catch (Exception) { }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            List<SanPham> lSP = new List<SanPham>();
            switch(cbbSapXep.SelectedItem)
            {
                case "ID":
                    lSP = (from i in BLL_SanPham.Instance.GetAllSanPham_BLL()
                           orderby i.IDSP ascending
                           select i).ToList();
                    break;
                case "Tên":
                    lSP = (from i in BLL_SanPham.Instance.GetAllSanPham_BLL()
                           orderby i.TenSP ascending
                           select i).ToList();
                    break;
                case "Size":
                    lSP = (from i in BLL_SanPham.Instance.GetAllSanPham_BLL()
                           orderby i.SizeSP ascending
                           select i).ToList();
                    break;
                case "Số Lượng":
                    lSP = (from i in BLL_SanPham.Instance.GetAllSanPham_BLL()
                           orderby i.SoLuongSP ascending
                           select i).ToList();
                    break;
                case "Đơn Giá":
                    lSP = (from i in BLL_SanPham.Instance.GetAllSanPham_BLL()
                           orderby i.DonGiaSP ascending
                           select i).ToList();
                    break;
                default:
                    break;
            }
            dgvBanHang.DataSource = lSP;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvBanHang.DataSource = BLL_SanPham.Instance.GetAllSanPham_BLL();
            txtSearch.Text = "";
            cbbSize.SelectedIndex = -1;
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
