using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BilliardClub
{
    public partial class FrmMember : FrmTemplate
    {
        MemoryStream _memoryStream = new MemoryStream();

        private Image _image;

        bool flag = false;

        byte[] _myArray;

        public static Member MemberProfile;

        void ClearTextBox()
        {
            picBox.Image = Properties.Resources.Images_icon;
        }
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Level.LoadComboBox(cmbLevel, myConnection);

            Phone.LoadComboBox(cmbPhone, myConnection);

            SocialNetworkType.LoadComboBox(cmbSocialNetworkType, myConnection);

            cmbType.SelectedIndex = 0;

            cmbSex.SelectedIndex = 0;

            GetCode();

            Member.LoadGrid_Join_SocialNetworkAccount_PhoneNumber(gridMember, myConnection);

            myConnection.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            #region Level Casting

            int levelId = ((Level)cmbLevel.SelectedItem).ID;

            if (!Level.Validation(levelId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Level level = Level.Get(levelId, myConnection);

            #endregion

            #region Phone Casting

            int phoneId = ((Phone)cmbPhone.SelectedItem).ID;

            if (!Phone.Validation(phoneId, myConnection))
            {
                //TODO Fix Message

                DataValidationMesaage.NoDataInBank();

                return;
            }

            Phone phone = Phone.Get(phoneId, myConnection);

            #endregion

            #region SocialNetwork Casting

            int socialNetworkTypeID = ((SocialNetworkType)cmbSocialNetworkType.SelectedItem).ID;

            if (!Phone.Validation(socialNetworkTypeID, myConnection))
            {
                //TODO Fix Message

                DataValidationMesaage.NoDataInBank();

                return;
            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeID, myConnection);

            #endregion

            if (!flag)
            {
                Image picImage = Properties.Resources.Images_icon;

                picBox.Image = picImage;

                picImage.Save(_memoryStream, picBox.Image.RawFormat);

                _myArray = _memoryStream.GetBuffer();
            }

            if (flag)
            {
                _image.Save(_memoryStream, picBox.Image.RawFormat);

                _myArray = _memoryStream.GetBuffer();
            }


            if (myConnection.Members.Any(a => a.Code == txtCode.Text))
            {
                MessageBox.Show("Error");

                return;
            }

            if (!BTM.Date.Validation(txtBirthDate.Text))
            {
                MessageBox.Show("قالب تاریخ تولد صحیح نمی باشد", "اخطار در ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            Member member = Member.Insert(txtCode.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtNationalCode.Text.Trim(),
                     BTM.Date.ConvertToGorgianDate(txtBirthDate.Text.Trim()), cmbType.Text.Trim(), cmbSex.Text.Trim(), _myArray, level, myConnection);

            PhoneNumber.Insert(phone, member, true, txtPhoneNumber.Text.Trim(), myConnection);

            SocialNetworkAccount.Insert(socialNetworkType, member, true, txtSocialAccount.Text.Trim(), myConnection);

            GetCode();

            Member.LoadGrid_Join_SocialNetworkAccount_PhoneNumber(gridMember, myConnection);

            ClearTextBox();

            myConnection.Dispose();

        }

        private void GetCode()
        {
            txtCode.Clear();

            DataBaseDataContext myConnection = Setting.DataBase;

            int memberId = myConnection.Members.Count() + 1;

            DateTime dt = DateTime.Now;

            PersianCalendar ps = new PersianCalendar();

            string[] dateStrings = new string[3]
            {
                ps.GetYear(dt).ToString(),
                ps.GetMonth(dt).ToString(),
                ps.GetDayOfMonth(dt).ToString(),
            };

            foreach (string item in dateStrings)
            {
                txtCode.Text += item;
            }

            txtCode.Text += memberId;

            myConnection.Dispose();
        }

        private void btnLevelGet_Click(object sender, EventArgs e)
        {
            FrmLevel frm = new FrmLevel();

            frm.ShowDialog();
        }

        private void پروفایلکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridMember.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridMember.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            int memberId = int.Parse(gridMember.SelectedRows[0].Cells[1].Value.ToString());

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);

            MemberProfile = member;

            FrmProfile frm = new FrmProfile();

            frm.Show();

            myConnection.Dispose();
        }

        private void gridMember_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("کاربر گرامی توجه داشته باشید که سایز عکس شما بیشتر از 100 کیلوبایت نباشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            var opd = new OpenFileDialog();

            opd.Title = "انتخاب عکس";

            opd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.tfif,*.tif, *.png) | *.jpg; *.jpeg; *.jpe; *.tfif;*.tif; *.png";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                _image = Image.FromFile(opd.FileName);

                picBox.Load(opd.FileName);

                flag = true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridMember.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridMember.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            int memeberId = int.Parse(gridMember.SelectedRows[0].Cells[1].Value.ToString());

            if (!Member.Validation(memeberId, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memeberId, myConnection);

            //TODO TextBox Loaded Fix

            byte[] myBytes = member.Image;

            if (myBytes != null)
            {
                _memoryStream = new MemoryStream(myBytes);

                picBox.Image = Image.FromStream(_memoryStream);
            }

            myConnection.Dispose();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                txtLastName.Focus();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            BTM.Text.FreezeToLetter(e);
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }
    }
}
