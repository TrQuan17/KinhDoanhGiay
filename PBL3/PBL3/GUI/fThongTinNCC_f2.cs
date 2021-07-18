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
    public partial class fThongTinNCC_f2 : Form
    {
        public string IDNCC { get; set; }
        public fThongTinNCC_f2(string m)
        {
            InitializeComponent();
            IDNCC = m;
            GUI();
        }
        public void GUI()
        {
            if (IDNCC != null)
            {
                NhaCungCap NCC = BLL_NhaCungCap.Instance.GetNhaCungCapByID(IDNCC);
                txtIDNCC.Text = NCC.IDNCC;
                txtTenNCC.Text = NCC.TenNCC;
                txtDiaChi.Text = NCC.DiaChiNCC;
                txtEmail.Text = NCC.EmailNCC;
                txtIDNCC.Enabled = false;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text.IndexOf("@") == 0 || txtEmail.Text.IndexOf("@") == txtEmail.Text.Length - 1 || txtEmail.Text.IndexOf("@") == -1)
                {
                    lbErEmail.Text = "Email không hợp lệ";
                    return;
                }
                lbErEmail.Text = "";
                NhaCungCap NCC = new NhaCungCap
                {
                    IDNCC = txtIDNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    DiaChiNCC = txtDiaChi.Text,
                    EmailNCC = txtEmail.Text
                };
                bool check = BLL_NhaCungCap.Instance.ExecuteDB_BLL(NCC);
                if (check == true)
                {
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

        private void fThongTinNCC_f2_Load(object sender, EventArgs e)
        {
            lbTitle.Parent = picTitle;
            lbTitle.BackColor = Color.Transparent;
        }
    }
}
