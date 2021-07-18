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
    public partial class fWellcome : Form
    {
        public fWellcome()
        {
            InitializeComponent();
        }

        private void tmrRun_Tick(object sender, EventArgs e)
        {
            pnLoad.Width += 3;
            if(pnLoad.Width >= pnProgress.Width)
            {
                tmrRun.Stop();
                fDangNhap f = new fDangNhap();
                f.Show();
                this.Hide();
            }
        }
    }
}
