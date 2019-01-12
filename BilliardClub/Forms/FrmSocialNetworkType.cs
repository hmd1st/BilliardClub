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
    public partial class FrmSocialNetworkType : FrmTemplate
    {
        public FrmSocialNetworkType()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }

        private void FrmSocialNetworkType_Load(object sender, EventArgs e)
        {
            SocialNetworkType.LoadGrid(gridSocialNetworkType, Setting.DataBase);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }
            if (myConnection.SocialNetworkTypes.Any(a => a.Title == txtTitle.Text.Trim()))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Insert(txtTitle.Text.Trim(), myConnection);

            clearTextBox();

            DataValidationMesaage.AcceptMessage(socialNetworkType.Title);

            SocialNetworkType.LoadGrid(gridSocialNetworkType, myConnection);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (gridSocialNetworkType.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridSocialNetworkType.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region SocialNetworkType Casting

            int socialNetworkTypeID = int.Parse(gridSocialNetworkType.SelectedRows[0].Cells[1].Value.ToString());

            if (!SocialNetworkType.Validation(socialNetworkTypeID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeID, myConnection);

            #endregion

            txtTitle.Text = socialNetworkType.Title;

            FormManagement.EnableYesNo(this.Controls);

            txtTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridSocialNetworkType.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridSocialNetworkType.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region SocialNetworkType Casting

            int socialNetworkTypeID = int.Parse(gridSocialNetworkType.SelectedRows[0].Cells[1].Value.ToString());

            if (!SocialNetworkType.Validation(socialNetworkTypeID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeID, myConnection);

            #endregion

            if (socialNetworkType.SocialNetworkAccounts.Any())
            {
                DataValidationMesaage.DataInUse(socialNetworkType.Title, gridSocialNetworkType.Text);

                return;
            }
            DialogResult message = DataValidationMesaage.ConfirmDeleteData(socialNetworkType.Title);

            if (message == DialogResult.Yes)
            {
                SocialNetworkType.Delete(socialNetworkType, myConnection);

                DataValidationMesaage.DeleteMessage();

                SocialNetworkType.LoadGrid(gridSocialNetworkType, myConnection);

            }



        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }

            #region SocialNetworkType Casting

            int socialNetworkTypeID = int.Parse(gridSocialNetworkType.SelectedRows[0].Cells[1].Value.ToString());

            if (!SocialNetworkType.Validation(socialNetworkTypeID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            SocialNetworkType socialNetworkType = SocialNetworkType.Get(socialNetworkTypeID, myConnection);

            #endregion

            if (myConnection.SocialNetworkTypes.Any(a => a.Title == txtTitle.Text.Trim() && a.ID != socialNetworkType.ID))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            SocialNetworkType.Edit(socialNetworkType, txtTitle.Text.Trim(), myConnection);

            DataValidationMesaage.EditMessage();

            clearTextBox();

            txtTitle.Focus();

            SocialNetworkType.LoadGrid(gridSocialNetworkType, myConnection);

            FormManagement.DisableYesNo(this.Controls);

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormManagement.DisableYesNo(this.Controls);

            txtTitle.Focus();
        }
        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e, btnYes, btnSave);
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void gridSocialNetworkType_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyDelToRemove(e, btnDelete);
        }

        private void gridSocialNetworkType_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
