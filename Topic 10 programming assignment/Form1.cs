using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10_programming_assignment
{
    public partial class Computerinfo : Form
    {
        public Computerinfo()
        {
            InitializeComponent();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            imgCPU.Visible = true;
            lblCPU.Visible = true;
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            imgRAM.Visible = true;
            lblRAM.Visible = true;
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            imgSSD.Visible = true;
            lblSSD.Visible = true;
        }

        private void btnPSU_Click(object sender, EventArgs e)
        {
            imgPSU.Visible = true;
            lblPSU.Visible = true;
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            imgIP.Visible = true;
            lblIP.Visible = true;
        }

        private void btnOP_Click(object sender, EventArgs e)
        {
            imgOP.Visible = true;
            lblOP.Visible = true;
        }
    }
}
