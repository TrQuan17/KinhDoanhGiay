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
    public partial class fThongTinNCC : Form
    {
        public fThongTinNCC()
        {
            InitializeComponent();
            ShowNCC();
            GUI();
        }
        public void GUI()
        {
            string[] tieuchi = { "ID", "Tên", "Địa Chỉ" };
            cbbSort.Items.AddRange(tieuchi);
        }
        public void ShowNCC()
        {
            dgvNCC.DataSource = BLL_NhaCungCap.Instance.GetAllNhaCungCap_BLL();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowNCC();
            txtSearch.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThongTinNCC_f2 f = new fThongTinNCC_f2(null);
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvNCC.SelectedRows;
            List<string> IDNCC_Del = new List<string>();
            if (data.Count == 0)
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow i in data)
                {
                    IDNCC_Del.Add(i.Cells["idncc"].Value.ToString());
                }
                foreach (string i in IDNCC_Del)
                {
                    if (BLL_NhaCungCap.Instance.Del_BLL(i))
                    {
                        ShowNCC();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được !", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count == 1)
            {
                string IDNCC = dgvNCC.SelectedRows[0].Cells["idncc"].Value.ToString();
                fThongTinNCC_f2 f = new fThongTinNCC_f2(IDNCC);
                f.Show();
            }
            else
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                dgvNCC.DataSource = BLL_NhaCungCap.Instance.Search(txtSearch.Text);
                if (dgvNCC.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tên nhà cung cấp này !", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<NhaCungCap> lNCC = new List<NhaCungCap>();
            switch (cbbSort.SelectedItem)
            {
                case "ID":
                    lNCC = (from i in BLL_NhaCungCap.Instance.GetAllNhaCungCap_BLL()
                           orderby i.IDNCC ascending
                           select i).ToList();
                    break;
                case "Tên":
                    lNCC = (from i in BLL_NhaCungCap.Instance.GetAllNhaCungCap_BLL()
                           orderby i.TenNCC ascending
                           select i).ToList();
                    break;
                case "Địa Chỉ":
                    lNCC = (from i in BLL_NhaCungCap.Instance.GetAllNhaCungCap_BLL()
                           orderby i.DiaChiNCC ascending
                           select i).ToList();
                    break;
                default:
                    break;
            }
            dgvNCC.DataSource = lNCC;
        }

    }
}
