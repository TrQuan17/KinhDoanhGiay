using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fDangNhap : Form
    {

        public fDangNhap()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            lbWel.Parent = picWel;
            lbWel.BackColor = Color.Transparent;
            txtMK.UseSystemPasswordChar = true;
            txtMK.MaxLength = 10;
            txtTenDN.MaxLength = 10;
        }
        private void ShowfManHinhChinh(string Quyen)
        {
            if(Quyen == "admin")
            {
                fManHinhChinhAdmin f = new fManHinhChinhAdmin();
                f.ShowDialog();
            }
            if(Quyen == "user")
            {
                fManHinhChinhUser fu = new fManHinhChinhUser();
                fu.ShowDialog();
            }

        }
        public void SetDangNhap(string Quyen)
        {
            if (txtTenDN.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Để trống giá trị cần thiết !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string TenDN = txtTenDN.Text;
                string MK = txtMK.Text;
                if (BLL_Account.Instance.CheckAccount_BLL(TenDN, MK, Quyen))
                {
                    MessageBox.Show("Đăng nhập thành công !!!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ShowfManHinhChinh(Quyen);
                }
                else
                {
                    string error = string.Format("Vui lòng kiểm tra lại : \n" +
                        "- Tên đăng nhập \n" +
                        "- Mật khẩu \n");
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMK.Text = "";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn muốn thoát chương trình ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SetDangNhap(BLL_Account.Instance.GetQuyenByTenDN(txtTenDN.Text));
        }

        private void lkbSetMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(BLL_Account.Instance.CheckTenDN(txtTenDN.Text))
            {
                fQuenMatKhau f = new fQuenMatKhau(txtTenDN.Text);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không tồn tại !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Text = "";
            }
        }
    }
}
