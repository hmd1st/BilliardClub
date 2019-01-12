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
    public partial class FrmPhone : FrmTemplate
    {
        public FrmPhone()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }

        private void FrmPhone_Load(object sender, EventArgs e)
        {
            Phone.LoadGrid(gridPhone, Setting.DataBase);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }
            if (myConnection.Phones.Any(a => a.Title == txtTitle.Text.Trim()))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            Phone phone = Phone.Insert(txtTitle.Text.Trim(), myConnection);

            clearTextBox();

            DataValidationMesaage.AcceptMessage(phone.Title);

            Phone.LoadGrid(gridPhone, myConnection);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (gridPhone.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPhone.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Phone Casting

            int phoneID = int.Parse(gridPhone.SelectedRows[0].Cells[1].Value.ToString());

            if (!Phone.Validation(phoneID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            Phone phone = Phone.Get(phoneID, myConnection);

            #endregion

            txtTitle.Text = phone.Title;

            FormManagement.EnableYesNo(this.Controls);

            txtTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridPhone.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPhone.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Phone Casting

            int phoneID = int.Parse(gridPhone.SelectedRows[0].Cells[1].Value.ToString());

            if (!Phone.Validation(phoneID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            Phone phone = Phone.Get(phoneID, myConnection);

            #endregion

            if (phone.PhoneNumbers.Any())
            {
                DataValidationMesaage.DataInUse(phone.Title, gridPhone.Text);

                return;
            }
            DialogResult message = DataValidationMesaage.ConfirmDeleteData(phone.Title);

            if (message == DialogResult.Yes)
            {
                Phone.Delete(phone, myConnection);

                DataValidationMesaage.DeleteMessage();

                Phone.LoadGrid(gridPhone, myConnection);

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

            #region Phone Casting

            int phoneID = int.Parse(gridPhone.SelectedRows[0].Cells[1].Value.ToString());

            if (!Phone.Validation(phoneID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            Phone phone = Phone.Get(phoneID, myConnection);

            #endregion

            if (myConnection.Phones.Any(a => a.Title == txtTitle.Text.Trim() && a.ID != phoneID))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            Phone.Edit(phone, txtTitle.Text.Trim(), myConnection);

            DataValidationMesaage.EditMessage();

            clearTextBox();

            txtTitle.Focus();

            Phone.LoadGrid(gridPhone, myConnection);

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

        private void gridPhone_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyDelToRemove(e, btnDelete);
        }

        private void gridPhone_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
