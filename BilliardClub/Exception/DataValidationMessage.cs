using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardClub
{
    public static class DataValidationMesaage
    {
        public static void Accept()
        {
            MessageBox.Show("اطلاعات شما با موفقیت در بانک اطلاعاتی ذخیره گردید.", "کاربر گرامی", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }
    }
}
