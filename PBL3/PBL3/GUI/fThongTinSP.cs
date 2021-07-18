using PBL3.BLL;
using PBL3.DAL;
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
    public partial class fThongTinSP : Form
    {
        public fThongTinSP()
        {
            InitializeComponent();
            ShowSP();
            GUI();
        }
        public void GUI()
        {
            //Set cbb sắp xếp
            string[] tieuchi = { "ID", "Tên", "Size", "Số Lượng", "Đơn Giá" };
            cbbSapXep.Items.AddRange(tieuchi);
            //set cbb hang
            List<string> lHang = new List<string>();
            foreach (SanPham i in BLL_SanPham.Instance.GetAllSanPham_BLL())
            {
                lHang.Add(BLL_SanPham.Instance.GetHangGiayByIDSP(i.IDSP));
            }
            foreach (string j in lHang.Distinct().ToList())
            {
                cbbHang.Items.Add(j);
            }
        }
        public void ShowSP()
        {
            dgvSP.DataSource = BLL_SanPham.Instance.GetAllSanPham_BLL();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowSP();
            txtSearch.Text = "";
            cbbHang.SelectedIndex = -1;
            cbbHang.Items.Clear();
            List<string> lHang = new List<string>();
            foreach (SanPham i in BLL_SanPham.Instance.GetAllSanPham_BLL())
            {
                lHang.Add(BLL_SanPham.Instance.GetHangGiayByIDSP(i.IDSP));
            }
            foreach (string j in lHang.Distinct().ToList())
            {
                cbbHang.Items.Add(j);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThongTinSP_f2 f = new fThongTinSP_f2(null);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSP.SelectedRows.Count == 1)
            {
                string IDSP = dgvSP.SelectedRows[0].Cells["idsp"].Value.ToString();
                fThongTinSP_f2 f = new fThongTinSP_f2(IDSP);
                f.Show();
            }
            else
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvSP.SelectedRows;
            List<string> IDSP_Del = new List<string>();
            if (data.Count == 0)
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow i in data)
                {
                    IDSP_Del.Add(i.Cells["idsp"].Value.ToString());
                }
                foreach (string i in IDSP_Del)
                {
                    if (BLL_SanPham.Instance.Del_BLL(i))
                    {
                        ShowSP();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được !", "Warning",
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
                dgvSP.DataSource = BLL_SanPham.Instance.Search(txtSearch.Text);
                if (dgvSP.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tên sản phẩm này !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dgvSP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string IDSP = dgvSP.SelectedRows[0].Cells["idsp"].Value.ToString();
                fChiTietThongTinSP f = new fChiTietThongTinSP(IDSP);
                f.ShowDialog();
            }
            catch (Exception) { }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            List<SanPham> lSP = new List<SanPham>();
            switch (cbbSapXep.SelectedItem)
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
            dgvSP.DataSource = lSP;
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            if(cbbHang.SelectedIndex == -1)
            {
                MessageBox.Show("Hãng chọn không hợp lệ !", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                dgvSP.DataSource = BLL_SanPham.Instance.GetSPByHang(cbbHang.SelectedItem.ToString());
        }
    }
}
