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
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            dgvTK.DataSource = BLL_Account.Instance.GetAccountNV_BLL();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = dgvTK.SelectedRows;
            List<string> TenDangNhap_Del = new List<string>();
            if (data.Count == 0)
            {
                MessageBox.Show("Đối tượng bạn chọn không chính xác !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow i in data)
                {
                    TenDangNhap_Del.Add(i.Cells["tendangnhap"].Value.ToString());
                }
                foreach (string i in TenDangNhap_Del)
                {
                    if (BLL_Account.Instance.Del_BLL(i))
                    {
                        GUI();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được !", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI();
        }
    }
}
