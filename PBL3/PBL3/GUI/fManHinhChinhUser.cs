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
    public partial class fManHinhChinhUser : Form
    {
        public fManHinhChinhUser()
        {
            InitializeComponent();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            fThongTinKH f = new fThongTinKH();
            f.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            fQLHoaDon f = new fQLHoaDon();
            f.ShowDialog();
        }
        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            fQLNhapKho f = new fQLNhapKho();
            f.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            fQLBanHang f = new fQLBanHang();
            f.ShowDialog();
        }
        private void fManHinhChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fManHinhChinhUser_Load(object sender, EventArgs e)
        {
            lbTitle.Parent = picTitle;
            lbTitle.BackColor = Color.Transparent;
        }
    }
}
