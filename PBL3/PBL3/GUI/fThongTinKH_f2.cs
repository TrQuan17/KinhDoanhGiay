using PBL3.BLL;
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
    public partial class fThongTinKH_f2 : Form
    {
        public delegate void ShowDelegate();
        public ShowDelegate sd { get; set; }
        public string IDKH { get; set; }
        public fThongTinKH_f2(string m)
        {
            InitializeComponent();
            IDKH = m;
            GUI();
        }
        public void GUI()
        {
            txtSDTKH.MaxLength = 10;
            lbTitle.Parent = picTitle;
            lbTitle.BackColor = Color.Transparent;
            if(IDKH != null)
            {
                KhachHang KH = BLL_KhachHang.Instance.GetKhachHangByID(IDKH);
                txtIDKH.Text = KH.IDKH;
                txtTenKH.Text = KH.TenKH;
                rbtnMale.Checked = KH.GioiTinhKH;
                rbtnFemale.Checked = !(KH.GioiTinhKH);
                txtDiaChi.Text = KH.DiaChiKH;
                txtSDTKH.Text = KH.SDTKH;
                txtIDKH.Enabled = false;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDTKH.Text.Length < 10 || txtSDTKH.Text.IndexOf("0") != 0)
                {
                    lbErSDT.Text = "Số điện thoại không hợp lệ";
                    return;
                }
                lbErSDT.Text = "";
                KhachHang KH = new KhachHang
                {
                    IDKH = txtIDKH.Text,
                    TenKH = txtTenKH.Text,
                    GioiTinhKH = Convert.ToBoolean(rbtnMale.Checked),
                    DiaChiKH = txtDiaChi.Text,
                    SDTKH = txtSDTKH.Text
                };
                
                bool check = BLL_KhachHang.Instance.ExecuteDB_BLL(KH);
                if (check == true)
                {
                    sd();
                    this.Close();
                    MessageBox.Show("Đã Lưu !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xử lý xảy ra lỗi !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Để trống giá trị cần thiết !", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
