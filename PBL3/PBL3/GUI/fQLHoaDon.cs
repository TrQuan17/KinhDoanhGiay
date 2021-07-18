using PBL3.BLL;
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
    public partial class fQLHoaDon : Form
    {
        public fQLHoaDon()
        {
            InitializeComponent();
            ShowHD();
        }
        public void ShowHD()
        {  
            dgvHoaDon.DataSource = BLL_DonHangBan.Instance.GetAllDonHangBan_BLL();
            dgvChiTietHoaDon.DataSource = BLL_ChiTietBan.Instance.GetAllChiTietBan_BLL();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvHoaDon.SelectedRows;
            List<int> IdBan_Del = new List<int>();
            if (data.Count == 0)
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow i in data)
                {
                    IdBan_Del.Add(Convert.ToInt32(i.Cells["idban"].Value.ToString()));
                }
                foreach (int i in IdBan_Del)
                {
                    if (BLL_DonHangBan.Instance.Del_BLL(i))
                    {
                        MessageBox.Show("Xóa thành công");
                        ShowHD();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được !", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
     
            if (dgvHoaDon.SelectedRows.Count == 1)
            {
                int IdBan = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["idban"].Value.ToString());
                dgvChiTietHoaDon.DataSource = BLL_ChiTietBan.Instance.GetChiTietBanByIdBan_BLL(IdBan);
            }
            else
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
