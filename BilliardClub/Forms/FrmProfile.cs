using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BilliardClub
{
    public partial class FrmProfile : FrmTemplate
    {
        private MemoryStream _memoryStream;

        public FrmProfile()
        {
            InitializeComponent();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Phone.LoadComboBox(cmbPhone, myConnection);

            PhoneNumber.ShowListByMember(lstPhoneNumber, FrmMember.MemberProfile, myConnection);

            SocialNetworkType.LoadComboBox(cmbSocialAccount, myConnection);

            SocialNetworkAccount.ShowListByMember(lstSocialNetwork, FrmMember.MemberProfile, myConnection);

            lblCode.Text = FrmMember.MemberProfile.Code;

            lblFirstName.Text = FrmMember.MemberProfile.FirstName;

            lblLastName.Text = FrmMember.MemberProfile.LastName;

            lblBirthDate.Text = BTM.Date.ConvertToPersianDate(FrmMember.MemberProfile.BirthDate);

            lblNationalCode.Text = FrmMember.MemberProfile.NationalCode;

            byte[] myBytes = FrmMember.MemberProfile.Image;

            if (myBytes != null)
            {
                _memoryStream = new MemoryStream(myBytes);

                PicBox.Image = Image.FromStream(_memoryStream);
            }

            if (lstPhoneNumber.Items.Count == 1)
            {
                btnPhoneDelete.Enabled = false;
            }

            if (lstSocialNetwork.Items.Count == 1)
            {
                btnSocialAccountDelete.Enabled = false;
            }

            myConnection.Dispose();

        }

        private void btnPhoneSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                DataValidationMesaage.BlankTextBox("شماره تماس");

                return;
            }

            #region Member Casting

            int memberId = FrmMember.MemberProfile.ID;

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);

            #endregion

            #region Phone Casting

            int phoneId = ((Phone)cmbPhone.SelectedItem).ID;

            if (!Phone.Validation(phoneId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Phone phone = Phone.Get(phoneId, myConnection);

            #endregion

            if (myConnection.PhoneNumbers.Any(a => a.Number == txtPhoneNumber.Text.Trim() && a.Member == member && a.Phone == phone))
            {
                DataValidationMesaage.DuplicateData(txtPhoneNumber.Text.Trim());

                return;
            }

            var query = myConnection.PhoneNumbers.Where(a => a.Member == member);

            foreach (var item in query)
            {
                item.Status = false;

                myConnection.SubmitChanges();
            }



            PhoneNumber phoneNumber = PhoneNumber.Insert(phone, member, true, txtPhoneNumber.Text, myConnection);

            DataValidationMesaage.AcceptMessage(phoneNumber.Number);

            PhoneNumber.ShowListByMember(lstPhoneNumber, member, myConnection);

            txtPhoneNumber.Clear();

            if (lstPhoneNumber.Items.Count > 1)
            {
                btnPhoneDelete.Enabled = true;
            }

            myConnection.Dispose();
        }

        private void btnPhoneEdit_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (lstPhoneNumber.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList("لیست شماره های تماس");

                return;
            }

            #region Member Casting

            int memberId = FrmMember.MemberProfile.ID;

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);

            #endregion

            #region Phone Casting

            int phoneId = ((Phone)cmbPhone.SelectedItem).ID;

            if (!Phone.Validation(phoneId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Phone phone = Phone.Get(phoneId, myConnection);

            #endregion

            #region PhoneNumber Casting

            PhoneNumber phoneNumber = (PhoneNumber)lstPhoneNumber.SelectedItems[0].Tag;

            if (!PhoneNumber.Validation(phoneNumber.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }
            phoneNumber = PhoneNumber.Get(phoneNumber.ID, myConnection);

            #endregion

            DialogResult message = MessageBox.Show("در صورت تایید شماره تماس فعلی فعال گردیده و مابقی غیرفعال میگردند",
                "کاربر گرامی", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (lstPhoneNumber.SelectedItems.Count == 0)
                {
                    DataValidationMesaage.NoSelectedItemFromList("لیست شماره های تماس");

                    return;
                }


                var query = myConnection.PhoneNumbers.Where(a => a.Member == member);

                foreach (var item in query)
                {
                    item.Status = false;

                    myConnection.SubmitChanges();
                }

                PhoneNumber.Edit(phoneNumber, phone, member, true, txtPhoneNumber.Text, myConnection);

                txtPhoneNumber.Clear();

                PhoneNumber.ShowListByMember(lstPhoneNumber, member, myConnection);

            }

            myConnection.Dispose();
        }

        private void btnPhoneDelete_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (lstPhoneNumber.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList("لیست شماره های تماس");

                return;
            }

            #region Member Casting

            int memberId = FrmMember.MemberProfile.ID;

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);

            #endregion

            #region Phone Casting

            int phoneId = ((Phone)cmbPhone.SelectedItem).ID;

            if (!Phone.Validation(phoneId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Phone phone = Phone.Get(phoneId, myConnection);

            #endregion

            #region PhoneNumber Casting

            PhoneNumber phoneNumber = (PhoneNumber)lstPhoneNumber.SelectedItems[0].Tag;

            if (!PhoneNumber.Validation(phoneNumber.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }
            phoneNumber = PhoneNumber.Get(phoneNumber.ID, myConnection);

            #endregion

            DialogResult messageResult =
                DataValidationMesaage.ConfirmDeleteData(lstPhoneNumber.SelectedItems[0].SubItems[1].Text);

            if (messageResult == DialogResult.Yes)
            {
                if (phoneNumber.Status)
                {
                    #region NextPhoneNumber Casting

                    int nextPhoneNumberIndex = (int.Parse(lstPhoneNumber.SelectedItems[0].Text)) %
                                               lstPhoneNumber.Items.Count;

                    PhoneNumber nextPhoneNumber = (PhoneNumber) lstPhoneNumber.Items[nextPhoneNumberIndex].Tag;

                    if (!PhoneNumber.Validation(nextPhoneNumber.ID, myConnection))
                    {
                        DataValidationMesaage.NoDataInBank();

                        return;
                    }
                    nextPhoneNumber = PhoneNumber.Get(nextPhoneNumber.ID, myConnection);

                    var query = myConnection.PhoneNumbers.Where(a => a.Member == member);

                    foreach (var item in query)
                    {
                        item.Status = false;

                        myConnection.SubmitChanges();
                    }

                    #endregion

                    nextPhoneNumber.Status = true;

                    myConnection.SubmitChanges();
                }
                PhoneNumber.Delete(phoneNumber, myConnection);

                PhoneNumber.ShowListByMember(lstPhoneNumber, FrmMember.MemberProfile, myConnection);

                if (lstPhoneNumber.Items.Count == 1)
                {
                    btnPhoneDelete.Enabled = false;
                }

            }

            txtPhoneNumber.Clear();

            myConnection.Dispose();
        }

        private void lstPhoneNumber_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            #region PhoneNumber Casting

            PhoneNumber phoneNumber = (PhoneNumber)lstPhoneNumber.SelectedItems[0].Tag;

            if (!PhoneNumber.Validation(phoneNumber.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }
            phoneNumber = PhoneNumber.Get(phoneNumber.ID, myConnection);

            #endregion

            txtPhoneNumber.Text = phoneNumber.Number;

            cmbPhone.SelectedItem = phoneNumber.Phone;

            myConnection.Dispose();
        }

        private void lblCleartxtPhoneNumber_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Clear();

            txtPhoneNumber.Focus();
        }

        private void lblCleartxtPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            tipHelp.Show("پاکسازی شماره تماس وارد شده", lblCleartxtPhoneNumber);
        }

        private void lblCleartxtSocialNetwork_MouseHover(object sender, EventArgs e)
        {
            tipHelp.Show("پاکسازی اکانت وارد شده", lblCleartxtSocialNetwork);
        }

        private void btnSocialAccountSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrWhiteSpace(txtSocialAccount.Text) || string.IsNullOrEmpty(txtSocialAccount.Text))
            {
                DataValidationMesaage.BlankTextBox("اکانت شبکه های اجتماعی");

                return;
            }

            #region Member Casting

            int memberId = FrmMember.MemberProfile.ID;

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);

            #endregion

            #region SocialNetworkType Casting

            int socialNetworkTypeId = ((SocialNetworkType)cmbSocialAccount.SelectedItem).ID;

            if (!SocialNetworkType.Validation(socialNetworkTypeId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeId, myConnection);

            #endregion

            if (myConnection.SocialNetworkAccounts.Any(
                a => a.Account == txtSocialAccount.Text.Trim() && a.Member == member &&
                     a.SocialNetworkType == socialNetworkType))
            {
                DataValidationMesaage.DuplicateData(txtSocialAccount.Text.Trim());

                return;
            }

            var query = myConnection.SocialNetworkAccounts.Where(a => a.Member == member);

            foreach (var item in query)
            {
                item.Status = false;

                myConnection.SubmitChanges();
            }



            SocialNetworkAccount socialNetworkAccount = SocialNetworkAccount.Insert(socialNetworkType, member, true, txtSocialAccount.Text.Trim(), myConnection);

            DataValidationMesaage.AcceptMessage(socialNetworkAccount.Account);

            SocialNetworkAccount.ShowListByMember(lstSocialNetwork, member, myConnection);

            txtSocialAccount.Clear();

            if (lstSocialNetwork.Items.Count > 1)
            {
                btnSocialAccountDelete.Enabled = true;
            }

            myConnection.Dispose();
        }

        private void btnSocialAccountEdit_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (lstSocialNetwork.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList("لیست اکانت های شبکه های اجتماعی");

                return;
            }

            #region Member Casting

            int memberId = FrmMember.MemberProfile.ID;

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);

            #endregion

            #region SocialNetworkType Casting

            int socialNetworkTypeId = ((SocialNetworkType)cmbSocialAccount.SelectedItem).ID;

            if (!SocialNetworkType.Validation(socialNetworkTypeId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeId, myConnection);

            #endregion

            #region SocialNetworkAccount Casting

            SocialNetworkAccount socialNetworkAccount = (SocialNetworkAccount)lstSocialNetwork.SelectedItems[0].Tag;

            if (!SocialNetworkAccount.Validation(socialNetworkAccount.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }
            socialNetworkAccount = SocialNetworkAccount.Get(socialNetworkAccount.ID, myConnection);

            #endregion

            DialogResult message = MessageBox.Show("در صورت تایید اکانت فعلی فعال گردیده و مابقی غیرفعال میگردند",
                "کاربر گرامی", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                if (lstSocialNetwork.SelectedItems.Count == 0)
                {
                    DataValidationMesaage.NoSelectedItemFromList("لیست اکانت های شبکه های اجتماعی");

                    return;
                }


                var query = myConnection.SocialNetworkAccounts.Where(a => a.Member == member);

                foreach (var item in query)
                {
                    item.Status = false;

                    myConnection.SubmitChanges();
                }

                SocialNetworkAccount.Edit(socialNetworkAccount, socialNetworkType, member, true, txtSocialAccount.Text.Trim(), myConnection);

                txtSocialAccount.Clear();

                SocialNetworkAccount.ShowListByMember(lstSocialNetwork, member, myConnection);

            }

            myConnection.Dispose();
        }

        private void btnSocialAccountDelete_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (lstSocialNetwork.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList("لیست اکانت های شبکه های اجتماعی");

                return;
            }

            #region Member Casting

            int memberId = FrmMember.MemberProfile.ID;

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);

            #endregion

            #region SocialNetworkType Casting

            int socialNetworkTypeId = ((SocialNetworkType)cmbSocialAccount.SelectedItem).ID;

            if (!SocialNetworkType.Validation(socialNetworkTypeId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeId, myConnection);

            #endregion

            #region SocialNetworkAccount Casting

            SocialNetworkAccount socialNetworkAccount = (SocialNetworkAccount)lstSocialNetwork.SelectedItems[0].Tag;

            if (!SocialNetworkAccount.Validation(socialNetworkAccount.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }
            socialNetworkAccount = SocialNetworkAccount.Get(socialNetworkAccount.ID, myConnection);

            #endregion

           DialogResult messageResult =
                DataValidationMesaage.ConfirmDeleteData(lstSocialNetwork.SelectedItems[0].SubItems[1].Text);

            if (messageResult == DialogResult.Yes)
            {
                if (socialNetworkAccount.Status)
                {

                    #region NextSocialNetworkAccount Casting

                    int nextSocialNetworkAccountIndex = (int.Parse(lstSocialNetwork.SelectedItems[0].Text)) %
                                                        lstSocialNetwork.Items.Count;

                    SocialNetworkAccount nextSocialNetworkAccount =
                        (SocialNetworkAccount) lstSocialNetwork.Items[nextSocialNetworkAccountIndex].Tag;

                    if (!SocialNetworkAccount.Validation(nextSocialNetworkAccount.ID, myConnection))
                    {
                        DataValidationMesaage.NoDataInBank();

                        return;
                    }
                    nextSocialNetworkAccount = SocialNetworkAccount.Get(nextSocialNetworkAccount.ID, myConnection);

                    var query = myConnection.SocialNetworkAccounts.Where(a => a.Member == member);

                    foreach (var item in query)
                    {
                        item.Status = false;

                        myConnection.SubmitChanges();
                    }

                    #endregion

                    nextSocialNetworkAccount.Status = true;

                    myConnection.SubmitChanges();
                }
                SocialNetworkAccount.Delete(socialNetworkAccount, myConnection);

                SocialNetworkAccount.ShowListByMember(lstSocialNetwork, FrmMember.MemberProfile, myConnection);

                if (lstSocialNetwork.Items.Count == 1)
                {
                    btnPhoneDelete.Enabled = false;
                }

            }

            txtSocialAccount.Clear();

            myConnection.Dispose();
        }

        private void lstSocialNetwork_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            #region SocialNetworkAccount Casting

            SocialNetworkAccount socialNetworkAccount = (SocialNetworkAccount)lstSocialNetwork.SelectedItems[0].Tag;

            if (!SocialNetworkAccount.Validation(socialNetworkAccount.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }
            socialNetworkAccount = SocialNetworkAccount.Get(socialNetworkAccount.ID, myConnection);

            #endregion

            txtSocialAccount.Text = socialNetworkAccount.Account;

            cmbSocialAccount.SelectedItem = socialNetworkAccount.SocialNetworkType;

            myConnection.Dispose();
        }

        private void lblCleartxtSocialNetwork_Click(object sender, EventArgs e)
        {
            txtSocialAccount.Clear();

            txtSocialAccount.Focus();
        }

        private void txtSocialAccount_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToEnglish();
        }
    }

}
