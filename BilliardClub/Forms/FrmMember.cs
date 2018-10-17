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
    public partial class FrmMember : FrmTemplate
    {
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Level.LoadComboBox(cmbLevel, myConnection);

            Phone.LoadComboBox(cmbPhone, myConnection);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            int levelId = ((Level)cmbLevel.SelectedItem).ID;

            if (!Level.Validation(levelId, myConnection))
            {
                //TODO Fix Message

                return;
            }

            Level level = Level.Get(levelId, myConnection);


            #region Phone Casting

            int phoneId = ((Phone)cmbPhone.SelectedItem).ID;

            if (!Phone.Validation(phoneId, myConnection))
            {
                //TODO Fix Message

                return;
            }

            Phone phone = Phone.Get(phoneId, myConnection);

            #endregion

            byte[] ms = new byte[2];

            for (int i = 0; i < ms.Length; i++)
            {
                ms[i] = new byte();
            }

            Member member = Member.Insert(txtCode.Text, txtFirstName.Text, txtLastName.Text, txtNationalCode.Text,
                     BTM.Date.ConvertToGorgianDate(txtBirthDate.Text), cmbType.Text, cmbSex.Text, ms, level, myConnection);

            PhoneNumber.Insert(phone, member, true, txtPhoneNumber.Text, myConnection);


        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }
    }
}
