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
    public partial class fThongTinKH : Form
    {
        public fThongTinKH()
        {
            InitializeComponent();
            ShowKH();
            GUI();
        }
        public void GUI()
        {
            string[] tieuchi = { "ID", "Tên", "Giới Tính", "Địa Chỉ" };
            cbbSapXep.Items.AddRange(tieuchi);
        }
        public void ShowKH()
        {
            dgvKH.DataSource = BLL_KhachHang.Instance.GetAllKhachHang_BLL(); 
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowKH();
            txtSearch.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThongTinKH_f2 f = new fThongTinKH_f2(null);
            f.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 1)
            {
                string IDKH = dgvKH.SelectedRows[0].Cells["idkh"].Value.ToString();
                fThongTinKH_f2 f = new fThongTinKH_f2(IDKH);
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
            DataGridViewSelectedRowCollection data = dgvKH.SelectedRows;
            List<string> IDKH_Del = new List<string>();
            if (data.Count == 0)
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow i in data)
                {
                    IDKH_Del.Add(i.Cells["idkh"].Value.ToString());
                }
                foreach (string i in IDKH_Del)
                {
                    if (BLL_KhachHang.Instance.Del_BLL(i))
                    {
                        ShowKH();
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
                dgvKH.DataSource = BLL_KhachHang.Instance.Search(txtSearch.Text);
                if (dgvKH.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tên khách hàng này !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            List<KhachHang> lKH = new List<KhachHang>();
            switch (cbbSapXep.SelectedItem)
            {
                case "ID":
                    lKH = (from i in BLL_KhachHang.Instance.GetAllKhachHang_BLL()
                           orderby i.IDKH ascending
                            select i).ToList();
                    break;
                case "Tên":
                    lKH = (from i in BLL_KhachHang.Instance.GetAllKhachHang_BLL()
                           orderby i.TenKH ascending
                            select i).ToList();
                    break;
                case "Giới Tính":
                    lKH = (from i in BLL_KhachHang.Instance.GetAllKhachHang_BLL()
                           orderby i.GioiTinhKH ascending
                           select i).ToList();
                    break;
                case "Địa Chỉ":
                    lKH = (from i in BLL_KhachHang.Instance.GetAllKhachHang_BLL()
                           orderby i.DiaChiKH ascending
                            select i).ToList();
                    break;
                default:
                    break;
            }
            dgvKH.DataSource = lKH;
        }
    }
}
