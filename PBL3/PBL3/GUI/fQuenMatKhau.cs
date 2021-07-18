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
    public partial class fQuenMatKhau : Form
    {
        public string TenDN { get; set; }
        public fQuenMatKhau(string s)
        {
            InitializeComponent();
            TenDN = s;
            GUI();
        }
        public void GUI()
        {
            txtMKNew.MaxLength = 10;
            txtCfMK.MaxLength = 10;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCfMK.Text == "" || txtEmail.Text == "" || txtMKNew.Text == "")
            {
                MessageBox.Show("Để trống giá trị cần thiết !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMKNew.Text != txtCfMK.Text)
            {
                lbTB.Text = "Mật khẩu xác nhận không đúng";
            }
            else
            {
                if (BLL_Account.Instance.GetTenDNByEmail_BLL(txtEmail.Text) == TenDN)
                {
                    if (BLL_Account.Instance.UpdateMKByEmail_BLL(txtEmail.Text, txtCfMK.Text))
                    {
                        MessageBox.Show("Đã cập nhập mật khẩu !!!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xử lý xảy ra lỗi !!!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lbTBEmail.Text = "Email xác nhận không đúng";
                    lbTB.Text = "";
                }
            }
        }
    }
}
