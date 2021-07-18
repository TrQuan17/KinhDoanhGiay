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
    public partial class fThongTinNV_f3 : Form
    {
        public string SDTNV { get; set; }
        public fThongTinNV_f3(string S)
        {
            InitializeComponent();
            SDTNV = S;
            GUI();
        }
        public void GUI()
        {
            txtTDN.MaxLength = 10;
            txtMK.MaxLength = 10;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string TDN = txtTDN.Text;
            string MK = txtMK.Text;
            string Email = txtEmail.Text;
            if (BLL_Account.Instance.CheckTenDN(TDN))
            {
                lbErTDN.Text = "Tên đăng nhập đã tồn tại !";
                return;
            }
            else
            {
                lbErTDN.Text = "";
            }
            if (Email.IndexOf("@") == 0 || Email.IndexOf("@") == Email.Length - 1 || Email.IndexOf("@") == -1)
            {
                lbErEmail.Text = "Email không hợp lệ !";
                return;
            }
            else
            {
                lbErEmail.Text = "";
            }
            
            if(BLL_Account.Instance.Add_BLL(TDN, MK, Email, SDTNV))
            {
                this.Close();
                MessageBox.Show("Đã Lưu !", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
                MessageBox.Show("Xử lý xảy ra lỗi !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
