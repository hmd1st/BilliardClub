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
    public partial class FrmPlayingBoard : FrmTemplate
    {
        public FrmPlayingBoard()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            txtNumber.Clear();

            txtNumber.Focus();
        }

        public static PlayingBoardGroupTitle SelectedPlayingBoardGroupTitle;

        public static PlayingBoard SelectedPlayingBoard;

        private void btnAddPlayingboardGroupTitle_Click(object sender, EventArgs e)
        {
            FrmPlayingBoardGroupTitle frm = new FrmPlayingBoardGroupTitle();

            frm.ShowDialog();
        }

        private void FrmPlayingBoard_Load(object sender, EventArgs e)
        {

            DataBaseDataContext myConnection = Setting.DataBase;

            PlayingBoardGroupTitle.LoadComboBox(cmbPlayingBoardGroupTitle, myConnection);

            if (myConnection.PlayingBoardGroupTitles.Any())
            {
                #region PlayingBoardGroupTitle Cast

                int playingBoardGroupTitleId = ((PlayingBoardGroupTitle)cmbPlayingBoardGroupTitle.SelectedItem).ID;

                if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleId,
                    myConnection);

                #endregion

                if (myConnection.PlayingBoardTitles.Any(a => a.PlayingBoardGroupTitle.Equals(playingBoardGroupTitle)))
                {
                    #region PlayingBoardTitle Cast

                    int playingBoardTitleId = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

                    if (!PlayingBoardTitle.Validation(playingBoardTitleId, myConnection))
                    {
                        DataValidationMesaage.NoDataInBank();

                        return;
                    }

                    PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleId, myConnection);

                    #endregion

                    PlayingBoard.LoadGridColorful_By_PlayingBoardTitle(gridPlayingBoard, playingBoardTitle, myConnection);
                }
            }

            myConnection.Dispose();
        }

        private void cmbPlayingBoardGroupTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridPlayingBoard.Rows.Clear();

            DataBaseDataContext myConnection = Setting.DataBase;

            if (myConnection.PlayingBoardGroupTitles.Any())
            {
                btnAddPlayingboardTitle.Visible = true;

                #region PlayingBoardGroupTitle Cast

                int playingBoardGroupTitleId = ((PlayingBoardGroupTitle)cmbPlayingBoardGroupTitle.SelectedItem).ID;

                if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleId,
                    myConnection);

                #endregion

                PlayingBoardTitle.LoadComboBox_By_PlayingBoardGroupTitle(cmbPlayingBoardTitle, playingBoardGroupTitle,
                    myConnection);

                if (myConnection.PlayingBoardTitles.Any(a => a.PlayingBoardGroupTitle.Equals(playingBoardGroupTitle)))
                {
                    #region PlayingBoardTitle Cast

                    int playingBoardTitleId = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

                    if (!PlayingBoardTitle.Validation(playingBoardTitleId, myConnection))
                    {
                        DataValidationMesaage.NoDataInBank();

                        return;
                    }

                    PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleId, myConnection);

                    #endregion

                    PlayingBoard.LoadGridColorful_By_PlayingBoardTitle(gridPlayingBoard, playingBoardTitle, myConnection);
                }


            }

            else
            {
                btnAddPlayingboardTitle.Visible = false;

                cmbPlayingBoardTitle.Items.Add("گروه بازی کامل شود");

                cmbPlayingBoardTitle.SelectedIndex = 0;

                return;
            }

        }

        private void FrmPlayingBoard_Activated(object sender, EventArgs e)
        {

            DataBaseDataContext myConnection = Setting.DataBase;

            btnAddPlayingboardTitle.Visible = true;

            if (FrmPlayingBoardGroupTitle.ActivatePlayingBoardGroupTitle)
            {
                gridPlayingBoard.Rows.Clear();

                PlayingBoardGroupTitle.LoadComboBox(cmbPlayingBoardGroupTitle, myConnection);

                FrmPlayingBoardGroupTitle.ActivatePlayingBoardGroupTitle = false;
            }

            if (FrmPlayingBoardTitle.ActivatePlayingBoardTitle)
            {
                gridPlayingBoard.Rows.Clear();

                #region PlayingBoardGroupTitle Cast

                int playingBoardGroupTitleId = ((PlayingBoardGroupTitle)cmbPlayingBoardGroupTitle.SelectedItem).ID;

                if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleId,
                    myConnection);

                #endregion

                PlayingBoardTitle.LoadComboBox_By_PlayingBoardGroupTitle(cmbPlayingBoardTitle, playingBoardGroupTitle,
                    myConnection);
                FrmPlayingBoardTitle.ActivatePlayingBoardTitle = false;

                if (myConnection.PlayingBoardTitles.Any(a => a.PlayingBoardGroupTitle.Equals(playingBoardGroupTitle)))
                {
                    #region PlayingBoardTitle Cast

                    int playingBoardTitleId = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

                    if (!PlayingBoardTitle.Validation(playingBoardTitleId, myConnection))
                    {
                        DataValidationMesaage.NoDataInBank();

                        return;
                    }

                    PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleId, myConnection);

                    #endregion

                    PlayingBoard.LoadGridColorful_By_PlayingBoardTitle(gridPlayingBoard, playingBoardTitle, myConnection);
                }

            }

            if (!myConnection.PlayingBoardGroupTitles.Any())
            {
                gridPlayingBoard.Rows.Clear();

                btnAddPlayingboardTitle.Visible = false;

                cmbPlayingBoardTitle.Items.Clear();

                cmbPlayingBoardTitle.Items.Add("گروه بازی کامل شود");

                cmbPlayingBoardTitle.SelectedIndex = 0;

                return;
            }

        }

        private void btnAddPlayingboardTitle_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoardGroupTitle Cast

            int playingBoardGroupTitleId = ((PlayingBoardGroupTitle)cmbPlayingBoardGroupTitle.SelectedItem).ID;

            if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            SelectedPlayingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleId,
                myConnection);

            #endregion

            FrmPlayingBoardTitle frm = new FrmPlayingBoardTitle();

            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                DataValidationMesaage.BlankTextBox("شماره دستگاه");

                return;
            }
            if (myConnection.PlayingBoardGroupTitles.Any())
            {
                #region PlayingBoardGroupTitle Cast

                int playingBoardGroupTitleId = ((PlayingBoardGroupTitle)cmbPlayingBoardGroupTitle.SelectedItem).ID;

                if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleId,
                    myConnection);

                #endregion

                if (!myConnection.PlayingBoardTitles.Any(a => a.PlayingBoardGroupTitle.Equals(playingBoardGroupTitle)))
                {
                    DataValidationMesaage.BlankComboBox("عنوان دستگاه");

                    return;
                }

                if (
                    myConnection.PlayingBoardTitles.Any(
                        a =>
                            a.Title.Equals(txtNumber.Text.Trim()) &&
                            a.PlayingBoardGroupTitle.Equals(playingBoardGroupTitle)))
                {
                    MessageBox.Show("کاربر گرامی مقادیر شماره میز و عنوان بازی نمیتوانند یکسان باشند.",
                        "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

            }

            #region PlayingBoardTitle Cast

            int id = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

            if (!PlayingBoardTitle.Validation(id, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(id, myConnection);

            #endregion

            if (myConnection.PlayingBoards.Any(a => a.PlayingBoardTitle == playingBoardTitle && a.Number.Equals(txtNumber.Text.Trim())))
            {
                DataValidationMesaage.DuplicateData("شماره میز");

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Insert(playingBoardTitle, txtNumber.Text, true, myConnection);

            DataValidationMesaage.AcceptMessage();

            DialogResult result1 = MessageBox.Show("آیا مایلید برق میز بازی ثبت شده را به صورت سیستمی کنترل نمایید؟", "کاربر گرامی", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                btnRaspberryRelay.PerformClick();
            }


            DialogResult result2 = MessageBox.Show("آیا مایلید برای میز بازی ثبت شده بهاء تعیین نمایید؟", "کاربر گرامی", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2==DialogResult.Yes)
            {
                btnPrice.PerformClick();
            }
            
            clearTextBox();

            PlayingBoard.LoadGridColorful_By_PlayingBoardTitle(gridPlayingBoard, playingBoardTitle, myConnection);

        }

        private void cmbPlayingBoardTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridPlayingBoard.Rows.Clear();

            DataBaseDataContext myConnection = Setting.DataBase;

            if (myConnection.PlayingBoardGroupTitles.Any())
            {
                #region PlayingBoardGroupTitle Cast

                int playingBoardGroupTitleId = ((PlayingBoardGroupTitle)cmbPlayingBoardGroupTitle.SelectedItem).ID;

                if (!PlayingBoardGroupTitle.Validation(playingBoardGroupTitleId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoardGroupTitle playingBoardGroupTitle = PlayingBoardGroupTitle.Get(playingBoardGroupTitleId,
                    myConnection);

                #endregion

                if (myConnection.PlayingBoardTitles.Any(a => a.PlayingBoardGroupTitle.Equals(playingBoardGroupTitle)))
                {
                    #region PlayingBoardTitle Cast

                    int playingBoardTitleId = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

                    if (!PlayingBoardTitle.Validation(playingBoardTitleId, myConnection))
                    {
                        DataValidationMesaage.NoDataInBank();

                        return;
                    }

                    PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleId, myConnection);

                    #endregion

                    PlayingBoard.LoadGridColorful_By_PlayingBoardTitle(gridPlayingBoard, playingBoardTitle, myConnection);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoard Cast

            int playingBoardId = (int)gridPlayingBoard.SelectedRows[0].Cells[1].Value;

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            txtNumber.Text = playingBoard.Number;

            FormManagement.EnableYesNoIncludingComboBox(this.Controls);

            myConnection.Dispose();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region No ListItem Selected

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }


            #endregion

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoard Cast

            int playingBoardId = (int)gridPlayingBoard.SelectedRows[0].Cells[1].Value;

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            #region Check Data In Use (RaspberryPin)

            if (playingBoard.PlayingBoardTypes.Any() ||
                myConnection.RaspBerryPlayingBoards.Any(a => a.PlayingBoard.Equals(playingBoard)))
            {
                DataValidationMesaage.DataInUse(playingBoard.Number, gridPlayingBoard.Text);

                return;
            }


            #endregion

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(playingBoard.Number);

            if (message == DialogResult.Yes)
            {
                PlayingBoard.Delete(playingBoard, myConnection);

                DataValidationMesaage.DeleteMessage();

                PlayingBoard.LoadGridColorful_By_PlayingBoardTitle(gridPlayingBoard, playingBoard.PlayingBoardTitle,
                    myConnection);
            }

            myConnection.Dispose();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            #region Check Blank txtNumber

            if (string.IsNullOrEmpty(txtNumber.Text.Trim()) && string.IsNullOrWhiteSpace(txtNumber.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("شماره دستگاه");

                return;
            }

            #endregion

            DataBaseDataContext myConnection = Setting.DataBase;

            if (myConnection.PlayingBoardGroupTitles.Any())
            {
                #region PlayingBoardTitle Cast

                int playingBoardTitleId = ((PlayingBoardTitle)cmbPlayingBoardTitle.SelectedItem).ID;

                if (!PlayingBoardTitle.Validation(playingBoardTitleId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoardTitle playingBoardTitle = PlayingBoardTitle.Get(playingBoardTitleId,
                    myConnection);

                #endregion

                #region Check Duplicate cmbPlayingBoardTitle and txtNumber
                if (
                    myConnection.PlayingBoards.Any(
                        a =>
                            a.PlayingBoardTitle.Title.Equals(txtNumber.Text.Trim())))
                {
                    MessageBox.Show("کاربر گرامی مقادیر شماره میز و عنوان بازی نمیتوانند یکسان باشند.",
                        "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }


                #endregion

                #region Check Duplicate Data

                if (
                    myConnection.PlayingBoards.Any(
                        a =>
                            a.Number.Equals(txtNumber.Text.Trim()) &&
                            a.PlayingBoardTitle.Equals(playingBoardTitle)))
                {
                    DataValidationMesaage.DuplicateData("شماره میز");

                    return;
                }

                #endregion

                #region PlayingBoard Cast

                int PlayingBoardId = (int)gridPlayingBoard.SelectedRows[0].Cells[1].Value;

                if (!PlayingBoard.Validation(PlayingBoardId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoard playingBoard = PlayingBoard.Get(PlayingBoardId, myConnection);

                #endregion

                PlayingBoard.Edit(playingBoard, playingBoardTitle, txtNumber.Text.Trim(), true, myConnection);

                DataValidationMesaage.EditMessage();

                clearTextBox();

                FormManagement.DisableYesNoIncludingComboBox(this.Controls);

                PlayingBoard.LoadGridColorful_By_PlayingBoardTitle(gridPlayingBoard, playingBoardTitle, myConnection);


            }

            myConnection.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormManagement.DisableYesNoIncludingComboBox(this.Controls);

            txtNumber.Focus();
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
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

        private void gridPlayingBoard_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            #region No ListItem Selected

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }


            #endregion

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoard Cast

            int playingBoardId = (int)gridPlayingBoard.SelectedRows[0].Cells[1].Value;

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            SelectedPlayingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            FrmPlayingBoardType frm = new FrmPlayingBoardType();

            frm.ShowDialog();
        }

        private void btnRaspberryRelay_Click(object sender, EventArgs e)
        {
            #region No ListItem Selected

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }


            #endregion

            FrmSetRaspberryRelays frm = new FrmSetRaspberryRelays();

            frm.ShowDialog();
        }

        private void تعیینبهاءToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            #region No ListItem Selected

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }


            #endregion

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoard Cast

            int playingBoardId = (int)gridPlayingBoard.SelectedRows[0].Cells[1].Value;

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            SelectedPlayingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            FrmPlayingBoardType frm = new FrmPlayingBoardType();

            frm.ShowDialog();
        }

        private void کنترلبرقToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            #region No ListItem Selected

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }


            #endregion

            FrmSetRaspberryRelays frm = new FrmSetRaspberryRelays();

            frm.ShowDialog();
        }
    }
}
