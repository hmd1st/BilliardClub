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

        MemoryStream _memory = new MemoryStream();

        private Image _image;

        bool flag = false;

        byte[] _myArray;

        public static Member MemberProfile;

        private void ClearTextBox()
        {
            picBox.Image = Properties.Resources.profile;
            foreach (Control control in this.Controls)
                if ((control is TextBox) && ((control != txtCode)))
                    (control as TextBox).Clear();
                else
                {
                    (control as MaskedTextBox)?.Clear();
                }
        }

        private string CorrectPhoneNumber()
        {
            return "09" + txtPhoneNumber.Text.Trim();
        }

        public FrmMember()
        {
            InitializeComponent();
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

        private void FrmMember_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Level.LoadComboBox(cmbLevel, myConnection);

            Phone.LoadComboBox(cmbPhone, myConnection);

            SocialNetworkType.LoadComboBox(cmbSocialNetworkType, myConnection);

            cmbType.SelectedIndex = 0;

            cmbSex.SelectedIndex = 0;

            GetCode();

            Member.LoadGridJoinSocialNetworkAccountJoinPhoneNumber(gridMember, myConnection);

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

         

            #region Save Image

            if (!flag)
            {
                Image picImage = Properties.Resources.profile;

                picBox.Image = picImage;

                picImage.Save(_memoryStream, picBox.Image.RawFormat);

                _myArray = _memoryStream.GetBuffer();
            }

            if (flag)
            {
                _image.Save(_memoryStream, picBox.Image.RawFormat);

                _myArray = _memoryStream.GetBuffer();
            }

            #endregion

            if (myConnection.Members.Any(a => a.Code == txtCode.Text))
            {
                DataValidationMesaage.DuplicateData(txtCode.Text);

                return;
            }

            if (myConnection.Members.Any(a => a.NationalCode == txtNationalCode.Text))
            {
                DataValidationMesaage.DuplicateData(txtNationalCode.Text);

                return;
            }

            if (string.IsNullOrEmpty(txtNationalCode.Text.Trim()) || string.IsNullOrWhiteSpace(txtNationalCode.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("کد ملی");    

                return;
                
            }

            if (!BTM.Date.Validation(txtBirthDate.Text))
            {
                MessageBox.Show("قالب تاریخ تولد وارد شده صحیح نمی باشد", "اخطار در ورود اطلاعات", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            Member member = Member.Insert(txtCode.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim(),
                txtNationalCode.Text.Trim(),
                BTM.Date.ConvertToGorgianDate(txtBirthDate.Text.Trim()), cmbType.Text.Trim(), cmbSex.Text.Trim(),
                _myArray, false, level, myConnection);

            PhoneNumber.Insert(phone, member, true, CorrectPhoneNumber(), myConnection);


            if (txtSocialAccount.Text.Length > 0)
            {

                #region SocialNetwork Casting

                int socialNetworkTypeID = ((SocialNetworkType) cmbSocialNetworkType.SelectedItem).ID;

                if (!Phone.Validation(socialNetworkTypeID, myConnection))
                {
                    //TODO Fix Message

                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeID, myConnection);

                #endregion

                SocialNetworkAccount.Insert(socialNetworkType, member, true, txtSocialAccount.Text.Trim(), myConnection);
            }
            GetCode();

            Member.LoadGridJoinSocialNetworkAccountJoinPhoneNumber(gridMember, myConnection);

            ClearTextBox();

            myConnection.Dispose();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridMember.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridMember.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Member Casting

            int memeberId = int.Parse(gridMember.SelectedRows[0].Cells[1].Value.ToString());

            if (!Member.Validation(memeberId, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memeberId, myConnection);

            #endregion

            #region PhoneNumber Casting

            string gridPhoneNumber = gridMember.SelectedRows[0].Cells[9].Value.ToString();

            PhoneNumber phoneNumber =
                myConnection.PhoneNumbers.FirstOrDefault(a => a.Number == gridPhoneNumber && a.Member == member);

            if (!PhoneNumber.Validation(phoneNumber.ID, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            #endregion

            #region SocialNetworkAccount Casting

            string gridSocialAccount = gridMember.SelectedRows[0].Cells[8].Value.ToString();

            SocialNetworkAccount socialNetworkAccount =
                myConnection.SocialNetworkAccounts.FirstOrDefault(
                    a => a.Account == gridSocialAccount && a.Member == member);

            if (!SocialNetworkAccount.Validation(socialNetworkAccount.ID, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            #endregion

            #region Fill TextBoxes

            txtCode.Text = member.Code;

            txtFirstName.Text = member.FirstName;

            txtLastName.Text = member.LastName;

            txtBirthDate.Text = BTM.Date.ConvertToPersianDate(member.BirthDate);

            txtNationalCode.Text = member.NationalCode;

            cmbSex.SelectedItem = member.Sex;

            cmbType.SelectedItem = member.Type;

            cmbLevel.SelectedItem = member.Level;

            cmbPhone.SelectedItem = phoneNumber.Phone;

            txtPhoneNumber.Text = phoneNumber.Number;

            cmbSocialNetworkType.SelectedItem = socialNetworkAccount.SocialNetworkType;

            txtSocialAccount.Text = socialNetworkAccount.Account;

            byte[] myBytes = member.Image;

            if (myBytes != null)
            {
                _memoryStream = new MemoryStream(myBytes);

                picBox.Image = Image.FromStream(_memoryStream);
            }

            #endregion

            FormManagement.EnableYesNo(this.Controls);

            btnImageSelect.Enabled = true;

            txtFirstName.Focus();

            myConnection.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridMember.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridMember.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Member Casting

            int memeberId = int.Parse(gridMember.SelectedRows[0].Cells[1].Value.ToString());

            if (!Member.Validation(memeberId, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memeberId, myConnection);

            #endregion

            #region PhoneNumber Casting

            string gridPhoneNumber = gridMember.SelectedRows[0].Cells[9].Value.ToString();

            PhoneNumber phoneNumber =
                myConnection.PhoneNumbers.FirstOrDefault(a => a.Number == gridPhoneNumber && a.Member == member);

            if (!PhoneNumber.Validation(phoneNumber.ID, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            #endregion

            #region SocialNetworkAccount Casting

            string gridSocialAccount = gridMember.SelectedRows[0].Cells[8].Value.ToString();

            SocialNetworkAccount socialNetworkAccount =
                myConnection.SocialNetworkAccounts.FirstOrDefault(
                    a => a.Account == gridSocialAccount && a.Member == member);

            if (!SocialNetworkAccount.Validation(socialNetworkAccount.ID, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            #endregion

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(member.Code);

            if (message == DialogResult.Yes)
            {

                PhoneNumber.Delete(phoneNumber, myConnection);

                SocialNetworkAccount.Delete(socialNetworkAccount, myConnection);

                Member.Delete(member, myConnection);

                DataValidationMesaage.DeleteMessage();

                GetCode();

                Member.LoadGridJoinSocialNetworkAccountJoinPhoneNumber(gridMember, myConnection);
            }

        }

        private void btnLevelGet_Click(object sender, EventArgs e)
        {
            FrmLevel frm = new FrmLevel();

            frm.ShowDialog();

            Level.LoadComboBox(cmbLevel, Setting.DataBase);

            Setting.DataBase.Dispose();
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

        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog();

            opd.Title = "انتخاب عکس";

            opd.Filter =
                "Image files (*.jpg, *.jpeg, *.jpe, *.tfif,*.tif, *.png) | *.jpg; *.jpeg; *.jpe; *.tfif;*.tif; *.png";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                _image = Image.FromFile(opd.FileName);

                picBox.Load(opd.FileName);

                flag = true;
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtNationalCode.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtNationalCode.Text))
            {
                MessageBox.Show("کاربر گرامی مقادیر نام یا نام خانوادگی یا کد ملی نمی توانند خالی باشند ", "اخطار در ورود اطلاعات", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

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

            #region Member Casting

            int memeberId = int.Parse(gridMember.SelectedRows[0].Cells[1].Value.ToString());

            if (!Member.Validation(memeberId, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memeberId, myConnection);

            #endregion

            #region PhoneNumber Casting

            string gridPhoneNumber = gridMember.SelectedRows[0].Cells[9].Value.ToString();

            PhoneNumber phoneNumber =
                myConnection.PhoneNumbers.FirstOrDefault(a => a.Number == gridPhoneNumber && a.Member == member);

            if (phoneNumber != null && !PhoneNumber.Validation(phoneNumber.ID, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            #endregion

            #region SocialNetworkAccount Casting

            string gridSocialAccount = gridMember.SelectedRows[0].Cells[8].Value.ToString();

            SocialNetworkAccount socialNetworkAccount =
                myConnection.SocialNetworkAccounts.FirstOrDefault(
                    a => a.Account == gridSocialAccount && a.Member == member);

            if (socialNetworkAccount != null && !SocialNetworkAccount.Validation(socialNetworkAccount.ID, myConnection))

            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

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

            bool query = myConnection.PhoneNumbers.Any(a => a.Number == CorrectPhoneNumber() &&
                                                           a.Member == member && a.ID != phoneNumber.ID);
            if (query)
            {
                DataValidationMesaage.DuplicateData("شماره تماس برای این کاربر");

                return;
            }

            query =
                myConnection.SocialNetworkAccounts.Any(
                    a =>
                        a.Account == txtSocialAccount.Text.Trim() && a.Member == member &&
                        a.ID != socialNetworkAccount.ID);

            if (query)
            {
                DataValidationMesaage.DuplicateData("اکانت شبکه های اجتماعی برای این کاربر");

                return;
            }

            query = myConnection.Members.Any(a => a.NationalCode == txtNationalCode.Text.Trim() && a.ID != memeberId);

            if (query)
            {
                DataValidationMesaage.DuplicateData("کاربر با این کد ملی");

                return;
            }

            if (!flag)
            {
                Image picImage = Properties.Resources.profile;

                picBox.Image = picImage;

                picImage.Save(_memory, picBox.Image.RawFormat);

                _myArray = _memory.GetBuffer();
            }

            if (flag)
            {
                _image.Save(_memory, picBox.Image.RawFormat);

                _myArray = _memory.GetBuffer();
            }


            Phone.Edit(phone, cmbPhone.Text.Trim(), myConnection);

            PhoneNumber.Edit(phoneNumber, phone, member, true, CorrectPhoneNumber(), myConnection);

            SocialNetworkType.Edit(socialNetworkType, cmbSocialNetworkType.Text.Trim(), myConnection);

            SocialNetworkAccount.Edit(socialNetworkAccount, socialNetworkType, member, true, txtSocialAccount.Text.Trim(), myConnection);

            //TODO How to check Has Cabinet or not? 

            Member.Edit(member, txtCode.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim(),
                txtNationalCode.Text.Trim(), BTM.Date.ConvertToGorgianDate(txtBirthDate.Text.Trim()),
                cmbType.Text.Trim(), cmbSex.Text.Trim(), _myArray, level, myConnection);

            DataValidationMesaage.EditMessage();

            ClearTextBox();

            txtFirstName.Focus();

            Member.LoadGridJoinSocialNetworkAccountJoinPhoneNumber(gridMember, myConnection);

            FormManagement.DisableYesNo(this.Controls);

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormManagement.DisableYesNo(this.Controls);

            ClearTextBox();

            txtFirstName.Focus();
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

        private void btnPhoneGet_Click(object sender, EventArgs e)
        {
            FrmPhone frm = new FrmPhone();

            frm.ShowDialog();

            Phone.LoadComboBox(cmbPhone, Setting.DataBase);

            Setting.DataBase.Dispose();
        }

        private void btnSocialAccountTypeGet_Click(object sender, EventArgs e)
        {
            FrmSocialNetworkType frm = new FrmSocialNetworkType();

            frm.ShowDialog();

            SocialNetworkType.LoadComboBox(cmbSocialNetworkType, Setting.DataBase);

            Setting.DataBase.Dispose();

        }

        private void gridMember_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 1)
            {
                cmsTeam.Enabled = false;
            }

            if (cmbType.SelectedIndex == 0)
            {
                cmsTeam.Enabled = false;
            }
        }

        private void صندوقچهاماناتToolStripMenuItem_Click(object sender, EventArgs e)
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

            FrmMemberCabinet frm = new FrmMemberCabinet();

            frm.ShowDialog();

            myConnection.Dispose();

        }

        private void txtSocialAccount_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToEnglish();
        }
    }
}
