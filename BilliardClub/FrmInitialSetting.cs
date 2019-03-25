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
            DataBaseDataContext connection = Setting.DataBase;

            Configuration.Insert(txtRaspBerryIP.Text.Trim(), "9999", connection);
            
            MessageBox.Show("تنظیمات اولیه با موفقیت انجام شد ",
               "کاربر گرامی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRaspBerryIP_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tipHelp.Show("مثال: 192.168.1.10", pictureBox1);
        }
    }
}
