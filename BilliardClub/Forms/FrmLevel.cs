using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class FrmLevel : FrmTemplate
    {
        public FrmLevel()
        {
            InitializeComponent();
        }
        void ClearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }
        private void FrmLevel_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Level.LoadGrid(gridLevel, myConnection);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrEmpty(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }

            if (myConnection.Levels.Any(a => a.Title == txtTitle.Text.Trim()))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            Level level = Level.Insert(txtTitle.Text, myConnection);

            DataValidationMesaage.AcceptMessage(level.Title);

            ClearTextBox();

            Level.LoadGrid(gridLevel, myConnection);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridLevel.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridLevel.Text);
                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Level Casting

            int levelID = int.Parse(gridLevel.SelectedRows[0].Cells[1].Value.ToString());

            if (!Level.Validation(levelID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Level level = Level.Get(levelID, myConnection);

            #endregion

            txtTitle.Text = level.Title;

            //FormsManagement.EnableYesNo(btnSave, btnEdit, btnDelete, btnYes, btnNo, gridLevel);
            FormManagement.EnableYesNo(this.Controls);
            txtTitle.Focus();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ClearTextBox();

            //FormsManagement.DisableYesNo(btnSave, btnEdit, btnDelete, btnYes, btnNo, gridLevel);
            FormManagement.DisableYesNo(this.Controls);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            #region Level Casting

            int levelID = int.Parse(gridLevel.SelectedRows[0].Cells[1].Value.ToString());

            if (!Level.Validation(levelID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Level level = Level.Get(levelID, myConnection);

            #endregion

            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrEmpty(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }
            if (myConnection.Levels.Any(a => a.Title == txtTitle.Text.Trim() && a.ID != levelID))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }
            Level.Edit(level, txtTitle.Text.Trim(), myConnection);

            if (myConnection.Levels.Any(a => a.ID != levelID && a.Title == txtTitle.Text.Trim()))
                DataValidationMesaage.EditMessage();

            ClearTextBox();

            Level.LoadGrid(gridLevel, myConnection);

            //FormsManagement.DisableYesNo(btnSave, btnEdit, btnDelete, btnYes, btnNo, gridLevel);
            FormManagement.DisableYesNo(this.Controls);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridLevel.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridLevel.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Level Casting

            int levelID = int.Parse(gridLevel.SelectedRows[0].Cells[1].Value.ToString());

            if (!Level.Validation(levelID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Level level = Level.Get(levelID, myConnection);

            #endregion

            if (level.Members.Any())
            {
                DataValidationMesaage.DataInUse(level.Title, gridLevel.Text);

                return;
            }

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(level.Title);

            if (message == DialogResult.Yes)
            {
                Level.Delete(level, myConnection);

                DataValidationMesaage.DeleteMessage();

                Level.LoadGrid(gridLevel, myConnection);

            }
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e,btnYes,btnSave);
        }

    }
}
