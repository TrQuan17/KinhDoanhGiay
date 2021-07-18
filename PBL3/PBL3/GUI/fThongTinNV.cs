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
    public partial class fThongTinNV : Form
    {
        public fThongTinNV()
        {
            InitializeComponent();
            ShowNV();
            GUI();
        }
        public void GUI()
        {
            string[] tieuchi = { "ID", "Tên", "Giới Tính", "Tuổi", "Địa Chỉ" };
            cbbSort.Items.AddRange(tieuchi);
        }
        public void ShowNV()
        {
            dgvNV.DataSource = BLL_NhanVien.Instance.GetAllNhanVien_BLL();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowNV();
            txtSearch.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThongTinNV_f2 f = new fThongTinNV_f2(null);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count == 1)
            {
                string IDNV = dgvNV.SelectedRows[0].Cells["idnv"].Value.ToString();
                fThongTinNV_f2 f = new fThongTinNV_f2(IDNV);
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
            DataGridViewSelectedRowCollection data = dgvNV.SelectedRows;
            List<string> IDNV_Del = new List<string>();
            if (data.Count == 0)
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow i in data)
                {
                    IDNV_Del.Add(i.Cells["idnv"].Value.ToString());
                }
                foreach (string i in IDNV_Del)
                {
                    if (BLL_NhanVien.Instance.Del_BLL(i))
                    {
                        ShowNV();
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
                dgvNV.DataSource = BLL_NhanVien.Instance.Search(txtSearch.Text);
                if (dgvNV.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tên nhân viên này !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<NhanVien> lNV = new List<NhanVien>();
            switch (cbbSort.SelectedItem)
            {
                case "ID":
                    lNV = (from i in BLL_NhanVien.Instance.GetAllNhanVien_BLL()
                           orderby i.IDNV ascending
                           select i).ToList();
                    break;
                case "Tên":
                    lNV = (from i in BLL_NhanVien.Instance.GetAllNhanVien_BLL()
                           orderby i.TenNV ascending
                           select i).ToList();
                    break;
                case "Giới Tính":
                    lNV = (from i in BLL_NhanVien.Instance.GetAllNhanVien_BLL()
                           orderby i.GioiTinhNV ascending
                           select i).ToList();
                    break;
                case "Tuổi":
                    lNV = (from i in BLL_NhanVien.Instance.GetAllNhanVien_BLL()
                           orderby i.TuoiNV ascending
                           select i).ToList();
                    break;
                case "Địa Chỉ":
                    lNV = (from i in BLL_NhanVien.Instance.GetAllNhanVien_BLL()
                           orderby i.DiaChiNV ascending
                           select i).ToList();
                    break;
                default:
                    break;
            }
            dgvNV.DataSource = lNV;
        }

        private void btnAddTK_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvNV.SelectedRows;
            if(data.Count != 1)
            {
                MessageBox.Show("Đối tượng bạn chọn không hợp lệ !", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string SDTNV = data[0].Cells["sdtnv"].Value.ToString();
                if (BLL_Account.Instance.CheckSDTNV(SDTNV))
                {
                    fThongTinNV_f3 f = new fThongTinNV_f3(SDTNV);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đã có tài khoản được đăng kí với nhân viên này !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
