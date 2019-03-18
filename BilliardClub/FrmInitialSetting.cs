using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardClub
{
    public partial class FrmInitialSetting : FrmTemplate
    {
        public FrmInitialSetting()
        {
            InitializeComponent();
        }

        private void FrmInitialSetting_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Setting.RaspberryIPAddress = txtRaspBerryIP.Text;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
