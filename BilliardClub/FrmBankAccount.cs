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
    public partial class FrmBankAccount : FrmTemplate
    {
        public FrmBankAccount()
        {
            InitializeComponent();
        }

        void ClearTextBoxes()
        {
            txtAccountNumber.Clear();

            txtBankTitle.Clear();

            txtCardNumber.Clear();

            txtBankTitle.Focus();

        }

        private void FrmBankAccount_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            BankAccount.LoadGrid(gridBankAccount, myConnection);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBankTitle.Text.Trim()) || string.IsNullOrEmpty(txtBankTitle.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("عنوان بانک");

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            if (myConnection.BankAccounts.Any(a => a.BankTitle.Equals(txtBankTitle.Text.Trim())))
            {
                DataValidationMesaage.DuplicateData("عنوان بانک");

                return;
            }

            BankAccount.Insert(txtBankTitle.Text.Trim(), txtCardNumber.Text.Trim(), txtAccountNumber.Text.Trim(),
                myConnection);

            ClearTextBoxes();

            myConnection.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridBankAccount.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridBankAccount.Text);
                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region BankAccount Casting

            int bankAccountId = int.Parse(gridBankAccount.SelectedRows[0].Cells[1].Value.ToString());

            if (!BankAccount.Validation(bankAccountId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            BankAccount bankAccount = BankAccount.Get(bankAccountId, myConnection);

            #endregion

            txtBankTitle.Text = bankAccount.BankTitle;

            txtCardNumber.Text = bankAccount.CardNumber;

            txtAccountNumber.Text = bankAccount.AccountNumber;

            FormManagement.EnableYesNo(this.Controls);

            txtBankTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridBankAccount.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridBankAccount.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region BankAccount Casting

            int bankAccountId = int.Parse(gridBankAccount.SelectedRows[0].Cells[1].Value.ToString());

            if (!BankAccount.Validation(bankAccountId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            BankAccount bankAccount = BankAccount.Get(bankAccountId, myConnection);

            #endregion

            if (bankAccount.CardSerialPayments.Any())
            {
                DataValidationMesaage.DataInUse(bankAccount.BankTitle, gridBankAccount.Text);

                return;
            }

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(bankAccount.ToString());

            if (message == DialogResult.Yes)
            {
                BankAccount.Delete(bankAccount, myConnection);

                DataValidationMesaage.DeleteMessage();

                BankAccount.LoadGrid(gridBankAccount, myConnection);

            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            #region BankAccount Casting

            int bankAccountId = int.Parse(gridBankAccount.SelectedRows[0].Cells[1].Value.ToString());

            if (!BankAccount.Validation(bankAccountId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            BankAccount bankAccount = BankAccount.Get(bankAccountId, myConnection);

            #endregion

            if (string.IsNullOrWhiteSpace(txtBankTitle.Text.Trim()) || string.IsNullOrEmpty(txtBankTitle.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("عنوان بانک");

                return;
            }

            if (myConnection.BankAccounts.Any(a => a.BankTitle.Equals(txtBankTitle.Text.Trim()) && a.ID!=bankAccountId))
            {
                DataValidationMesaage.DuplicateData("عنوان بانک");

                return;
            }
            BankAccount.Edit(bankAccount, txtBankTitle.Text.Trim(), txtCardNumber.Text.Trim(),
                txtAccountNumber.Text.Trim(), myConnection);

            DataValidationMesaage.EditMessage();

            ClearTextBoxes();

            BankAccount.LoadGrid(gridBankAccount, myConnection);

            FormManagement.DisableYesNo(this.Controls);

            myConnection.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            FormManagement.DisableYesNo(this.Controls);
        }

        private void txtBankTitle_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void txtCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e, btnYes, btnSave);
        }

        private void gridBankAccount_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }


        private void txtAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            BTM.Text.FreezeToDigit(e);
        }

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            BTM.Text.FreezeToDigit(e);
        }
    }
}
