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
    public partial class FrmPlayingBoardType : FrmTemplate
    {

        public FrmPlayingBoardType()
        {
            InitializeComponent();
        }


        private void clearTextBox()
        {
            txtPrice.Clear();

            txtPrice.Text = "0";

            txtPrice.Focus();
        }

        private void FrmPlayBoard_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;

            DataBaseDataContext myConnection = Setting.DataBase;

            lblTitle.Text = FrmPlayingBoard.SelectedPlayingBoard.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle
                            + " " + FrmPlayingBoard.SelectedPlayingBoard.PlayingBoardTitle.Title
                            + " " + FrmPlayingBoard.SelectedPlayingBoard.Number;

            PlayingBoardType.ShowList_By_PlayingBoard(FrmPlayingBoard.SelectedPlayingBoard, lstPlayingBoardTypes,
                myConnection);

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            BTM.Text.FreezeToDigit(e);
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e, btnYes, btnSave);
        }

        private void cmbType_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PlayingBoard playingBoard = FrmPlayingBoard.SelectedPlayingBoard;

            if (int.Parse(txtPrice.Text.Trim()).Equals(0) || string.IsNullOrWhiteSpace(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("بهای میز");

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            if (
                myConnection.PlayingBoardTypes.Any(
                    a => a.Type == cmbType.SelectedItem.ToString() && a.PlayingBoard == playingBoard))
            {
                DataValidationMesaage.DuplicateData(cmbType.SelectedItem.ToString());

                return;
            }


            PlayingBoardType.Insert(playingBoard, cmbType.SelectedItem.ToString(),
                int.Parse(txtPrice.Text.Trim()), myConnection);

            DataValidationMesaage.AcceptMessage();

            PlayingBoardType.ShowList_By_PlayingBoard(playingBoard, lstPlayingBoardTypes, myConnection);

            myConnection.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPlayingBoardTypes.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(lstPlayingBoardTypes.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            PlayingBoardType playingBoardType = (PlayingBoardType)lstPlayingBoardTypes.SelectedItems[0].Tag;

            if (!PlayingBoardType.Validation(playingBoardType.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            cmbType.SelectedItem = playingBoardType.Type;

            txtPrice.Text = playingBoardType.Price.ToString();

            FormManagement.EnableYesNo(this.Controls);

            myConnection.Dispose();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayingBoardTypes.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(lstPlayingBoardTypes.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            PlayingBoardType playingBoardType = (PlayingBoardType)(lstPlayingBoardTypes.SelectedItems[0].Tag);

            if (!PlayingBoardType.Validation(playingBoardType.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            playingBoardType = PlayingBoardType.Get(playingBoardType.ID, myConnection);

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(playingBoardType.Type);

            if (message == DialogResult.Yes)
            {
                PlayingBoardType.Delete(playingBoardType, myConnection);

                DataValidationMesaage.DeleteMessage();

                PlayingBoardType.ShowList_By_PlayingBoard(FrmPlayingBoard.SelectedPlayingBoard, lstPlayingBoardTypes,
                    myConnection);
            }

            myConnection.Dispose();

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            PlayingBoard playingBoard = FrmPlayingBoard.SelectedPlayingBoard;

            if (int.Parse(txtPrice.Text.Trim()).Equals(0) || string.IsNullOrWhiteSpace(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("بهای میز");

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            PlayingBoardType playingBoardType = (PlayingBoardType)lstPlayingBoardTypes.SelectedItems[0].Tag;

            if (!PlayingBoardType.Validation(playingBoardType.ID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            playingBoardType = PlayingBoardType.Get(playingBoardType.ID, myConnection);

            if (
                myConnection.PlayingBoardTypes.Any(
                    a =>
                        a.Type == cmbType.SelectedItem.ToString() && a.PlayingBoard == playingBoard &&
                        a.ID != playingBoardType.ID))
            {
                DataValidationMesaage.DuplicateData(cmbType.SelectedItem.ToString());

                return;
            }

            if (myConnection.PlayingBoardTypes.Any(a =>
                        a.PlayingBoard == playingBoard &&
                        !a.PlayingBoard.IsAvailable))
            {
                DataValidationMesaage.DataInUse("میز بازی", lstPlayingBoardTypes.Text);

                return;
            }

            PlayingBoardType.Edit(playingBoardType, cmbType.SelectedItem.ToString(),
                int.Parse(txtPrice.Text.Trim()), myConnection);

            DataValidationMesaage.EditMessage();

            PlayingBoardType.ShowList_By_PlayingBoard(playingBoard, lstPlayingBoardTypes, myConnection);

            FormManagement.DisableYesNo(this.Controls);

            myConnection.Dispose();

            clearTextBox();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormManagement.DisableYesNo(this.Controls);

            clearTextBox();
        }
    }
}

