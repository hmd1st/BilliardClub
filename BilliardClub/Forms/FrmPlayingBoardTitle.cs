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
    public partial class FrmPlayingBoardTitle : FrmTemplate
    {
        public FrmPlayingBoardTitle()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }

        private void FrmPlayingBoardTitle_Load(object sender, EventArgs e)
        {
            PlayingBoardTitle.LoadGrid(gridPlayingBoardTitle, Setting.DataBase);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }
            if (myConnection.PlayingBoardTitles.Any(a => a.Title == txtTitle.Text.Trim()))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Insert(txtTitle.Text.Trim(), myConnection);

            clearTextBox();

            DataValidationMesaage.AcceptMessage(playingBoardTitle.Title);

            PlayingBoardTitle.LoadGrid(gridPlayingBoardTitle, myConnection);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (gridPlayingBoardTitle.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoardTitle.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoardTitle Casting

            int playingBoardTitleID = int.Parse(gridPlayingBoardTitle.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoardTitle.Validation(playingBoardTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleID, myConnection);

            #endregion

            txtTitle.Text = playingBoardTitle.Title;

            FormManagement.EnableYesNo(this.Controls);

            txtTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridPlayingBoardTitle.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoardTitle.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoardTitle Casting

            int playingBoardTitleID = int.Parse(gridPlayingBoardTitle.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoardTitle.Validation(playingBoardTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleID, myConnection);

            #endregion

            if (playingBoardTitle.PlayingBoards.Any())
            {
                DataValidationMesaage.DataInUse(playingBoardTitle.Title, gridPlayingBoardTitle.Text);

                return;
            }
            DialogResult message = DataValidationMesaage.ConfirmDeleteData(playingBoardTitle.Title);

            if (message == DialogResult.Yes)
            {
                PlayingBoardTitle.Delete(playingBoardTitle, myConnection);

                DataValidationMesaage.DeleteMessage();

                PlayingBoardTitle.LoadGrid(gridPlayingBoardTitle, myConnection);

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

            #region PlayingBoardTitle Casting

            int playingBoardTitleID = int.Parse(gridPlayingBoardTitle.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoardTitle.Validation(playingBoardTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleID, myConnection);

            #endregion

            if (myConnection.PlayingBoardTitles.Any(a => a.Title == txtTitle.Text.Trim() && a.ID != playingBoardTitleID))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            PlayingBoardTitle.Edit(playingBoardTitle, txtTitle.Text.Trim(), myConnection);

            DataValidationMesaage.EditMessage();

            clearTextBox();

            txtTitle.Focus();

            PlayingBoardTitle.LoadGrid(gridPlayingBoardTitle, myConnection);

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

        private void gridPlayingBoardTitle_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyDelToRemove(e, btnDelete);
        }
    }
}
