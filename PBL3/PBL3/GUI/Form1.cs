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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DonHangBan> l = new List<DonHangBan>();
            double tongtien = 0;
            int i = 1;
            while (i < 12)
            {
                l = BLL_DonHangBan.Instance.GetDonHangBanByDate_BLL(new DateTime(2021, i, 1), new DateTime(2021, i + 1, 1));
                tongtien = BLL_DonHangBan.Instance.GetTongTienByDate_DHB_BLL(l);
                //chThongKe.Series["chThongKe"].Points.AddXY("T " + i, tongtien);
                i++;
            }
        }
            
    }
}
