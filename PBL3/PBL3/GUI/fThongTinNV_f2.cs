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
    public partial class fThongTinNV_f2 : Form
    {
        public string IDNV { get; set; }
        public fThongTinNV_f2(string m)
        {
            InitializeComponent();
            IDNV = m;
            GUI();
        }
        public void GUI()
        {
            txtSDT.MaxLength = 10;
            txtTuoi.MaxLength = 3;
            if (IDNV != null)
            {
                NhanVien NV = BLL_NhanVien.Instance.GetNhanVienByID(IDNV);
                txtIDNV.Text = NV.IDNV;
                txtTenNV.Text = NV.TenNV;
                rbtnMale.Checked = NV.GioiTinhNV;
                rbtnFemale.Checked = !(NV.GioiTinhNV);
                txtTuoi.Text = NV.TuoiNV.ToString();
                txtDiaChi.Text = NV.DiaChiNV;
                txtSDT.Text = NV.SDTNV;
                txtIDNV.Enabled = false;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtTuoi.Text) <= 5 || Convert.ToInt32(txtTuoi.Text) > 150)
                {
                    lbErAge.Text = "Số tuổi không hợp lệ";
                    return;
                }
                else
                {
                    lbErAge.Text = "";
                }
                if(txtSDT.Text.Length < 10 || txtSDT.Text.IndexOf("0") != 0)
                {
                    lbErSDT.Text = "Số điện thoại không hợp lệ";
                    return;
                }
                else
                {
                    lbErSDT.Text = "";
                }    
                lbErSDT.Text = "";
                lbErAge.Text = "";
                NhanVien NV = new NhanVien
                {
                    IDNV = txtIDNV.Text,
                    TenNV = txtTenNV.Text,
                    GioiTinhNV = Convert.ToBoolean(rbtnMale.Checked),
                    TuoiNV = Convert.ToInt32(txtTuoi.Text),
                    DiaChiNV = txtDiaChi.Text,
                    SDTNV = txtSDT.Text
                };
                bool check = BLL_NhanVien.Instance.ExecuteDB_BLL(NV);
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
                MessageBox.Show("Để trống giá trị cần thiết !!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fThongTinNV_f2_Load(object sender, EventArgs e)
        {
            lbTitle.Parent = picTitle;
            lbTitle.BackColor = Color.Transparent;
        }
    }
}
