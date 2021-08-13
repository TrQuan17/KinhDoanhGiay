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
    public partial class fThongTinSP_f2 : Form
    {
        public delegate void ShowDelegate();
        public ShowDelegate sd { get; set; }
        public string IDSP { get; set; }
        
        public fThongTinSP_f2(string m)
        {
            InitializeComponent();
            IDSP = m;
            GUI();
        }
        public void GUI()
        {
            if (IDSP != null)
            {
                SanPham SP = BLL_SanPham.Instance.GetSanPhamByID(IDSP);
                txtIDSP.Text = SP.IDSP;
                txtTenSP.Text = SP.TenSP;
                txtSize.Text = SP.SizeSP.ToString();
                txtDonGia.Text = SP.DonGiaSP.ToString();
                txtSL.Text = SP.SoLuongSP.ToString();
                txtIDSP.Enabled = false;
                picSP.SizeMode = PictureBoxSizeMode.StretchImage;
                picSP.ImageLocation = fChiTietThongTinSP.DuongDan + BLL_HinhAnhSanPham.Instance.GetLinkImageByIDSP(IDSP);
                txtFileName.Text = BLL_HinhAnhSanPham.Instance.GetLinkImageByIDSP(IDSP);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(txtSize.Text) < 35 || Convert.ToInt32(txtSize.Text) > 70)
                {
                    lbErSize.Text = "Size giày không hợp lệ";
                    return;
                }
                if (Convert.ToDouble(txtDonGia.Text) < 1000)
                {
                    lbErSize.Text = "Giá giày không hợp lệ";
                    return;
                }
                lbErSize.Text = "";
                lbErDonGia.Text = "";
                SanPham SP = new SanPham
                {
                    IDSP = txtIDSP.Text,
                    TenSP = txtTenSP.Text,
                    SizeSP = Convert.ToInt32(txtSize.Text),
                    DonGiaSP = Convert.ToDouble(txtDonGia.Text),
                    SoLuongSP = Convert.ToInt32(txtSL.Text)
                };
                HinhAnhSanPham ISP = new HinhAnhSanPham
                {
                    IDSP = txtIDSP.Text,
                    LinkImage = txtFileName.Text
                };
                bool check = BLL_SanPham.Instance.ExecuteDB_BLL(SP) && BLL_HinhAnhSanPham.Instance.ExecuteDB_BLL(ISP);
                
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

        private void picSP_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            picSP.SizeMode = PictureBoxSizeMode.StretchImage;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picSP.ImageLocation = ofd.FileName;
                txtFileName.Text = System.IO.Path.GetFileName(ofd.FileName);
            }
        }
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fThongTinSP_f2_Load(object sender, EventArgs e)
        {
            lbTitle.Parent = picTitle;
            lbTitle.BackColor = Color.Transparent;
        }
    }
}
