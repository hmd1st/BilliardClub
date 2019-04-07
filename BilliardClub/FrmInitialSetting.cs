using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');

            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DataBaseDataContext connection = Setting.DataBase;

            if (string.IsNullOrWhiteSpace(txtRaspBerryIP.Text.Trim()) || string.IsNullOrEmpty(txtRaspBerryIP.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("آدرس آی پی کنترلر برق");

                return;
            }

           if (!ValidateIPv4(txtRaspBerryIP.Text.Trim()))
            {
                MessageBox.Show(" کاربر گرامی  مقدار وارد شده یک آدرس آی پی معتبر نمی باشد ", "اخطار",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Configuration.Insert(txtRaspBerryIP.Text.Trim(), "9999", connection);
            
            MessageBox.Show("تنظیمات اولیه با موفقیت انجام شد ",
               "کاربر گرامی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tipHelp.Show("مثال: 192.168.1.10", pictureBox1);
        }

        private void txtRaspBerryIP_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

        }

        private void txtRaspBerryIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnYes.PerformClick();
            }
        }
    }
}
