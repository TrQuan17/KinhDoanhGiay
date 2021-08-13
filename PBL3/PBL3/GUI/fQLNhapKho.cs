using PBL3.BLL;
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
    public partial class fQLNhapKho : Form
    {

        public fQLNhapKho()
        {
            InitializeComponent();
            SetCBB();
            ShowDHN();
        }
        public void SetCBB()
        {
            foreach (NhaCungCap i in BLL_NhaCungCap.Instance.GetAllNhaCungCap_BLL())
            {
                cbbTenNCC.Items.Add(new CBBItem { Name = i.TenNCC, ID = i.IDNCC });
            }
            foreach (NhanVien i in BLL_NhanVien.Instance.GetAllNhanVien_BLL())
            {
                cbbTenNV.Items.Add(new CBBItem { Name = i.TenNV, ID = i.IDNV });
            }
            foreach (SanPham i in BLL_SanPham.Instance.GetAllSanPham_BLL())
            {
                cbbSP.Items.Add(new CBBItem { Name = i.TenSP, ID = i.IDSP });
            }
            
            ccbSapXep.Items.Clear();
            ccbSapXep.Items.Add("IDNV (A->Z)");
            ccbSapXep.Items.Add("IDNV (Z->A)");

            ccbSapXep.Items.Add("IDNCC (A->Z)");
            ccbSapXep.Items.Add("IDNCC (Z->A)");

            ccbSapXep.Items.Add("Ngày mua (A->Z)");
            ccbSapXep.Items.Add("Ngày mua (Z->A)");

            ccbSapXep.Items.Add("Tổng tiền (A->Z)");
            ccbSapXep.Items.Add("Tổng tiền (Z->A)");
        }
        public void ShowDHN()
        {
            var lists = BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL();
            dgvNhap.DataSource = lists;
            gvSP.ClearSelection();
            txtIDNhap.Text = "";
        }

        private void ShowCTN(int idnhap)
        {
            List<ChiTietNhap> listChiTietNhap = BLL_ChiTietNhap.Instance.GetAllChiTietNhap_BLL(idnhap);
            List<SanPham> sanPhams = BLL_SanPham.Instance.GetAllSanPham_BLL();

            var items = from ct in listChiTietNhap
                        join sp in sanPhams
                        on ct.IDSP equals sp.IDSP
                        where ct.IDNhap == idnhap
                        select new
                        {
                            IDSP = ct.IDSP,
                            TenSP = sp.TenSP,
                            SoLuong = ct.SoLuongNhap,
                            DonGia = ct.DonGiaNhap,
                            ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap
                        };
            gvSP.DataSource = items.ToList();
        }

        public void ExcuteDB_UI()
        {
            if (cbbTenNCC.Text == "" || cbbTenNV.Text == "")
            {
                MessageBox.Show("Đối tượng không hợp lệ !", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DonHangNhap DHN;
                if (txtIDNhap.Text == "")
                {
                    DHN = new DonHangNhap
                    {
                        IDNhap = -1,
                        IDNCC = ((CBBItem)cbbTenNCC.SelectedItem).ID,
                        IDNV = ((CBBItem)cbbTenNV.SelectedItem).ID,
                        NgayNhap = dtpNgayNhap.Value.Date,
                        TongTienNhap = 0
                    };
                }
                else
                {
                    var dhn = BLL_DonHangNhap.Instance.GetDonHangNhapByID(int.Parse(txtIDNhap.Text));

                    DHN = new DonHangNhap
                    {
                        IDNhap = int.Parse(txtIDNhap.Text),
                        IDNCC = ((CBBItem)cbbTenNCC.SelectedItem).ID,
                        IDNV = ((CBBItem)cbbTenNV.SelectedItem).ID,
                        NgayNhap = dtpNgayNhap.Value.Date,
                        TongTienNhap = dhn.TongTienNhap
                    };
                }
                bool check = BLL_DonHangNhap.Instance.ExecuteDB_BLL(DHN);
                if (check == true)
                {

                    MessageBox.Show("Đã Lưu!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDHN();

                    for (int i = 0; i < dgvNhap.Rows.Count; i++)
                    {
                        dgvNhap.Rows[i].Selected = false;
                    }

                }
                else
                {
                    MessageBox.Show("Xử lý xảy ra lỗi !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            luuBtn.Enabled = true;
            huyBtn.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtIDNhap.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDHN();
            txtSearch.Text = "";

        }

        private void dgvNhap_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvNhap.SelectedRows;
            if (data.Count == 1)
            {
                string IDNhap = data[0].Cells["idnhap"].Value.ToString();
                DonHangNhap DHN = new DonHangNhap();
                DHN = BLL_DonHangNhap.Instance.GetDonHangNhapByID(int.Parse(IDNhap));
                txtIDNhap.Text = DHN.IDNhap.ToString();
                cbbTenNCC.Text = BLL_NhaCungCap.Instance.GetNhaCungCapByID(DHN.IDNCC).TenNCC;
                cbbTenNV.Text = BLL_NhanVien.Instance.GetNhanVienByID(DHN.IDNV).TenNV;
                dtpNgayNhap.Value = DHN.NgayNhap.Date;
                txtIDNhap.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            luuBtn.Enabled = true;
            huyBtn.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvNhap.SelectedRows;
            List<int> IDNhap_Del = new List<int>();
            if (data.Count == 0)
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gvSP.ClearSelection();
                cbbSP.SelectedIndex = -1;
                numUDSL.Value = 0;
                txtGiaNhap.Text = "";
                foreach (DataGridViewRow i in data)
                {
                    IDNhap_Del.Add(int.Parse(i.Cells["idnhap"].Value.ToString()));
                }
                foreach (int i in IDNhap_Del)
                {
                    var list = BLL_ChiTietNhap.Instance.GetAllChiTietNhap_BLL(i);
                    foreach (var item in list)
                    {
                        BLL_ChiTietNhap.Instance.Del_BLL(item.IDNhap, item.IDSP);
                    }
                    if (BLL_DonHangNhap.Instance.Del_BLL(i))
                    {
                        ShowDHN();

                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
     
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin cần tìm kiếm !", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvNhap.DataSource = BLL_DonHangNhap.Instance.Search(Convert.ToInt32(txtSearch.Text));
                if (dgvNhap.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng nhập này !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvNhap.SelectedRows[0].Index;

                int idNhap = int.Parse(txtIDNhap.Text);
                string idSp = ((CBBItem)cbbSP.SelectedItem).ID ;
                double donGia = Convert.ToDouble(txtGiaNhap.Text);
                int soLuong = int.Parse(numUDSL.Value.ToString());
                if (soLuong < 1)
                {
                    MessageBox.Show("Cung cấp thông tin không hợp lệ.");
                    return;
                }   
                donGia = double.Parse(txtGiaNhap.Text);
                if (idSp != "")
                {
                    ChiTietNhap chiTietNhap = new ChiTietNhap();
                    chiTietNhap = BLL_ChiTietNhap.Instance.GetChiTietNhapByID(idNhap, idSp);
                    if (chiTietNhap != null)
                    {
                        chiTietNhap.SoLuongNhap += soLuong;
                        BLL_ChiTietNhap.Instance.ExecuteDB_BLL(chiTietNhap);
                    }
                    else
                    {
                        BLL_ChiTietNhap.Instance.ExecuteDB_BLL(new ChiTietNhap(idNhap, idSp, donGia, soLuong));

                        //3 dòng tiếp theo để cập nhật lại số giày có trong kho
                        int SoLuongTrongKho = Convert.ToInt32(BLL_SanPham.Instance.GetSoLuongTrongKhoByIDSP_BLL(idSp));
                        int SoLuongCapNhat = SoLuongTrongKho + Convert.ToInt32(soLuong);
                        BLL_SanPham.Instance.UpdateSoLuongGiay_BLL(SoLuongCapNhat, idSp);
                    }
                    ShowCTN(idNhap);
                    DonHangNhap dhn = BLL_DonHangNhap.Instance.GetDonHangNhapByID(idNhap);
                    dhn.TongTienNhap += (soLuong * donGia);
                    BLL_DonHangNhap.Instance.Edit_BLL(dhn);
                    ShowDHN();

                    dgvNhap.Rows[0].Selected = false;
                    dgvNhap.Rows[index].Selected = true;
                }
            }
            catch
            {
                MessageBox.Show("Cung cấp thông tin không hợp lệ.");
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                int idNhap = int.Parse(txtIDNhap.Text);
                string idSp = gvSP.SelectedRows[0].Cells[0].Value.ToString();
                double thanhTien = double.Parse(gvSP.SelectedRows[0].Cells[4].Value.ToString());
                DonHangNhap dh = BLL_DonHangNhap.Instance.GetDonHangNhapByID(idNhap);
                dh.TongTienNhap -= thanhTien;
                BLL_DonHangNhap.Instance.ExecuteDB_BLL(dh);
                BLL_ChiTietNhap.Instance.Del_BLL(idNhap, idSp);

                //4 dòng tiếp theo để cập nhật lại số giày có trong kho
                int SoLuongTrongKho = Convert.ToInt32(BLL_SanPham.Instance.GetSoLuongTrongKhoByIDSP_BLL(idSp));
                int SoLuongTrongChiTietNhap = Convert.ToInt32(gvSP.SelectedRows[0].Cells[2].Value.ToString());
                int SoLuongCapNhat = SoLuongTrongKho - SoLuongTrongChiTietNhap;
                BLL_SanPham.Instance.UpdateSoLuongGiay_BLL(SoLuongCapNhat, idSp);

                ShowCTN(idNhap);
                ShowDHN();
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }

        }

        private void dgvNhap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnThemSP.Enabled = true;
                int index = dgvNhap.SelectedRows[0].Index;
                if (index > -1)
                {

                    ShowCTN(int.Parse(dgvNhap.Rows[index].Cells[0].Value.ToString()));

                    txtIDNhap.Text = dgvNhap.Rows[index].Cells[0].Value.ToString();

                    var listNV = BLL_NhanVien.Instance.GetAllNhanVien_BLL();

                    for (var i = 0; i < cbbTenNV.Items.Count; i++)
                    {
                        if (listNV[i].IDNV == dgvNhap.Rows[index].Cells[1].Value.ToString())
                        {
                            cbbTenNV.SelectedIndex = i;
                            break;
                        }
                    }
                    var listNCC = BLL.BLL_NhaCungCap.Instance.GetAllNhaCungCap_BLL();
                    for (var i = 0; i < listNCC.Count; i++)
                    {
                        if (listNCC[i].IDNCC == dgvNhap.Rows[index].Cells[2].Value.ToString())
                        {
                            cbbTenNCC.SelectedIndex = i;
                            break;
                        }
                    }

                    dtpNgayNhap.Value = DateTime.Parse(dgvNhap.Rows[index].Cells[3].Value.ToString());
                }
            }
            catch
            {
                btnThemSP.Enabled = false;
            }
        }

        private void txtIDNhap_TextChanged(object sender, EventArgs e)
        {
            gvSP.ClearSelection();
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            ExcuteDB_UI();
            luuBtn.Enabled = false;
            huyBtn.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;


        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            luuBtn.Enabled = false;
            huyBtn.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            List<DonHangNhap> dhns = new List<DonHangNhap>();

            switch (ccbSapXep.SelectedIndex)
            {
                case 0:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.IDNV ascending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                case 2:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.IDNCC ascending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                case 4:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.NgayNhap ascending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                case 6:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.TongTienNhap ascending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                case 1:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.IDNV descending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                case 3:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.IDNCC descending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                case 5:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.NgayNhap descending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                case 7:
                    dhns = (from i in BLL_DonHangNhap.Instance.GetAllDonHangNhap_BLL()
                            orderby i.TongTienNhap descending
                            select i).ToList();
                    dgvNhap.DataSource = dhns;
                    break;
                default:
                    break;
            }
        }

     
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
