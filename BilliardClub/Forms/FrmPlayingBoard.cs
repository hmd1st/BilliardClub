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
    public partial class FrmPlayingBoard : FrmTemplate
    {
        public FrmPlayingBoard()
        {
            InitializeComponent();
        }


        private void clearTextBox()
        {
            txtNumber.Clear();

            txtPrice.Text = "0";

            txtNumber.Focus();
        }

        private void FrmPlayBoard_Load(object sender, EventArgs e)
        {

            DataBaseDataContext myConnection = Setting.DataBase;

            PlayingBoardTitle.LoadComboBox(cmbPlayingBoardTitle, myConnection);

            PlayingBoard.LoadGrid_Join_PlayingBoardType(
                gridPlayingBoard, myConnection);


        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            BTM.Text.FreezeToDigit(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                DataValidationMesaage.BlankTextBox("شماره میز");

                return;
            }

            #region PlayingBoard Casting

            int playingBoardTitleID = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

            if (!PlayingBoardTitle.Validation(playingBoardTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleID, myConnection);

            bool query = myConnection.PlayingBoards.Join(myConnection.PlayingBoardTypes,
                playingboard => playingboard.ID,
                playingboardtype => playingboardtype.ID,
                (playingboard, playingboardtype) => new
                {
                    mypb = playingboard,
                    mypbt = playingboardtype
                }).Any(a => a.mypb.Number == txtNumber.Text.Trim() &&
                            a.mypb.PlayingBoardTitle == playingBoardTitle &&
                            a.mypbt.Type == cmbType.Text);

            //if (myConnection.PlayingBoards.Any(a => a.Number == txtNumber.Text.Trim() &&
            //                                        a.PlayingBoardTitle == playingBoardTitle))
            if (query)
            {

                DataValidationMesaage.DuplicateData("میز با این شماره");

                return;
            }


            #endregion

            PlayingBoard playingBoard = PlayingBoard.Insert(playingBoardTitle, txtNumber.Text.Trim(), true, myConnection);

            PlayingBoardType playingBoardType = PlayingBoardType.Insert(playingBoard, cmbType.Text.Trim(),
                int.Parse(txtPrice.Text.Trim()), myConnection);

            DataValidationMesaage.AcceptMessage("میز");

            PlayingBoard.LoadGrid_By_Filter_PlayingBoardTitle_Join_PlayingBoardType(playingBoardTitle,
                gridPlayingBoard, myConnection);
        }

        private void cmbPlayingBoardTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (myConnection.PlayingBoardTitles.Any())
            {
                int playingBoardTitleID = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

                if (!PlayingBoardTitle.Validation(playingBoardTitleID, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleID, myConnection);

                PlayingBoard.LoadGrid_By_Filter_PlayingBoardTitle_Join_PlayingBoardType(playingBoardTitle,
                    gridPlayingBoard, myConnection);
            }
        }

        private void btnAddPlayingboardTitle_Click(object sender, EventArgs e)
        {
            FrmPlayingBoardTitle frm = new FrmPlayingBoardTitle();

            frm.ShowDialog();

            PlayingBoardTitle.LoadComboBox(cmbPlayingBoardTitle, Setting.DataBase);

            Setting.DataBase.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }

            #region PlayingBoard Casting

            int playingBoardID = int.Parse(gridPlayingBoard.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoard.Validation(playingBoardID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardID, myConnection);

            PlayingBoardType playingBoardType =
                myConnection.PlayingBoardTypes.FirstOrDefault(a => a.PlayingBoardID == playingBoardID);

            #endregion

            txtNumber.Text = playingBoard.Number;

            cmbPlayingBoardTitle.Text = playingBoard.PlayingBoardTitle.Title;

            cmbType.Text = playingBoardType.Type;

            txtPrice.Text = playingBoardType.Price.ToString();

            FormManagement.EnableYesNo(this.Controls);

            txtNumber.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoard Casting

            int playingBoardID = int.Parse(gridPlayingBoard.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoard.Validation(playingBoardID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardID, myConnection);

            PlayingBoardType playingBoardType =
                myConnection.PlayingBoardTypes.FirstOrDefault(a => a.PlayingBoardID == playingBoardID);

            #endregion

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(playingBoard.Number);

            if (message == DialogResult.Yes)
            {
                PlayingBoardType.Delete(playingBoardType, myConnection);

                PlayingBoard.Delete(playingBoard, myConnection);

                DataValidationMesaage.DeleteMessage();

                PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoard.PlayingBoardTitleID, myConnection);

                PlayingBoard.LoadGrid_By_Filter_PlayingBoardTitle_Join_PlayingBoardType(playingBoardTitle,
                    gridPlayingBoard, myConnection);

            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                DataValidationMesaage.BlankTextBox("شماره میز");

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoard Casting

            int playingBoardID = int.Parse(gridPlayingBoard.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoard.Validation(playingBoardID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardID, myConnection);


            if (!PlayingBoardTitle.Validation(playingBoard.PlayingBoardTitleID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoard.PlayingBoardTitleID, myConnection);

            PlayingBoardType playingBoardType =
                myConnection.PlayingBoardTypes.FirstOrDefault(a => a.PlayingBoardID == playingBoardID);

            #endregion

            bool query = myConnection.PlayingBoards.Join(myConnection.PlayingBoardTypes,
                playingboard => playingboard.ID,
                playingboardtype => playingboardtype.ID,
                (playingboard, playingboardtype) => new
                {
                    mypb = playingboard,
                    mypbt = playingboardtype
                }).Any(a => a.mypb.Number == txtNumber.Text.Trim() &&
                            a.mypb.PlayingBoardTitle == playingBoardTitle &&
                            a.mypbt.Type == cmbType.Text && a.mypb.ID != playingBoardID);

            if (query)
            {
                DataValidationMesaage.DuplicateData("میز با این شماره");

                return;
            }

            PlayingBoardTitle.Edit(playingBoardTitle, cmbPlayingBoardTitle.Text.Trim(), myConnection);

            PlayingBoard.Edit(playingBoard, playingBoardTitle, txtNumber.Text.Trim(), myConnection);

            PlayingBoardType.Edit(playingBoardType, playingBoard, cmbType.Text.Trim(), int.Parse(txtPrice.Text),
                myConnection);

            DataValidationMesaage.EditMessage();

            clearTextBox();

            txtNumber.Focus();

            PlayingBoard.LoadGrid_Join_PlayingBoardType(gridPlayingBoard, myConnection);

            FormManagement.DisableYesNo(this.Controls);

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormManagement.DisableYesNo(this.Controls);

            txtNumber.Focus();
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e, btnYes, btnSave);
        }

        private void txtNumber_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void gridPlayingBoard_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyDelToRemove(e, btnDelete);
        }

        private void cmbType_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnYes.Enabled)
            {
                FormManagement.KeyEnterToSaveChanges(e, btnYes, btnSave);
            }
        }

        private void gridPlayingBoard_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;

        }
    }
}

