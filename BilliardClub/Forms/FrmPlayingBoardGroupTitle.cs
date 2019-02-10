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
    public partial class FrmPlayingBoardGroupTitle : FrmTemplate
    {
        public FrmPlayingBoardGroupTitle()
        {
            InitializeComponent();
        }

        private void ClearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }

        public static bool ActivatePlayingBoardGroupTitle = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }
            if (myConnection.PlayingBoardGroupTitles.Any(a => a.GroupTitle == txtTitle.Text.Trim()))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Insert(txtTitle.Text.Trim(), myConnection);

            ClearTextBox();

            DataValidationMesaage.AcceptMessage(playingBoardGroupTitle.GroupTitle);

            PlayingBoardGroupTitle.LoadGrid(gridPlayingBoardGroupTitle, myConnection);

            myConnection.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridPlayingBoardGroupTitle.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoardGroupTitle.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoardGroupTitle Casting

            int playingBoardGroupTitleID = int.Parse(gridPlayingBoardGroupTitle.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleID, myConnection);

            #endregion

            if (playingBoardGroupTitle.PlayingBoardTitles.Any())
            {
                DataValidationMesaage.DataInUse(playingBoardGroupTitle.GroupTitle, gridPlayingBoardGroupTitle.Text);

                return;
            }
            DialogResult message = DataValidationMesaage.ConfirmDeleteData(playingBoardGroupTitle.GroupTitle);

            if (message == DialogResult.Yes)
            {
                PlayingBoardGroupTitle.Delete(playingBoardGroupTitle, myConnection);

                DataValidationMesaage.DeleteMessage();

                PlayingBoardGroupTitle.LoadGrid(gridPlayingBoardGroupTitle, myConnection);

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

            #region PlayingBoardGroupTitle Casting

            int playingBoardGroupTitleID = int.Parse(gridPlayingBoardGroupTitle.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleID, myConnection);

            #endregion

            if (myConnection.PlayingBoardGroupTitles.Any(a => a.GroupTitle == txtTitle.Text.Trim() && a.ID != playingBoardGroupTitleID))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            PlayingBoardGroupTitle.Edit(playingBoardGroupTitle, txtTitle.Text.Trim(), myConnection);

            DataValidationMesaage.EditMessage();

            ClearTextBox();

            txtTitle.Focus();

            PlayingBoardGroupTitle.LoadGrid(gridPlayingBoardGroupTitle, myConnection);

            FormManagement.DisableYesNo(this.Controls);

            myConnection.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridPlayingBoardGroupTitle.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoardGroupTitle.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoardGroupTitle Casting

            int playingBoardGroupTitleID = int.Parse(gridPlayingBoardGroupTitle.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleID, myConnection);

            #endregion

            txtTitle.Text = playingBoardGroupTitle.GroupTitle;

            FormManagement.EnableYesNo(this.Controls);

            txtTitle.Focus();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormManagement.DisableYesNo(this.Controls);

            txtTitle.Focus();
        }

        private void FrmPlayingBoardGroupTitle_Load(object sender, EventArgs e)
        {
            PlayingBoardGroupTitle.LoadGrid(gridPlayingBoardGroupTitle, Setting.DataBase);

        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e, btnYes, btnSave);
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void gridPlayingBoardGroupTitle_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyDelToRemove(e, btnDelete);
        }

        private void gridPlayingBoardGroupTitle_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmPlayingBoardGroupTitle_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActivatePlayingBoardGroupTitle = true;  
        }
    }
}
