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
    public partial class FrmSetRaspberryRelays : FrmTemplate
    {
        public FrmSetRaspberryRelays()
        {
            InitializeComponent();
        }

        private void FrmSetRaspberryRelays_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            RaspBerryPlayingBoard.ShowList(lstRaspberryRelays, myConnection);

            RaspberryPin.LoadComboBoxAvailables(cmbRaspberryRelay, myConnection);

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

                    PlayingBoard.LoadComboBoxByFilter(cmbPlayingBoard, playingBoardTitle, myConnection);
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (cmbPlayingBoard.SelectedItem==null)
            {
                DataValidationMesaage.NoSelectedItemFromList("لیست میزهای بازی");

                return;
            }

            #region PlayingBoard Cast

            int playingBoardId = ((PlayingBoard)cmbPlayingBoard.SelectedItem).ID;

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            #region RaspberryPin Cast

            int raspberryPinID = ((RaspberryPin)cmbRaspberryRelay.SelectedItem).ID;

            if (!RaspberryPin.Validation(raspberryPinID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            RaspberryPin raspberryPin = RaspberryPin.Get(raspberryPinID, myConnection);

            #endregion

            if (myConnection.RaspBerryPlayingBoards.Any(a=>a.PlayingBoard==playingBoard))
            {
                MessageBox.Show("برای این میز بازی یک رله اختصاص داده شده است.", "کاربر گرامی", MessageBoxButtons.OK,
              MessageBoxIcon.Error);

                return;
            }

            RaspBerryPlayingBoard.Insert(raspberryPin, playingBoard, myConnection);

            raspberryPin.IsAvailable = false;

            myConnection.SubmitChanges();

            DataValidationMesaage.AcceptMessage();

            RaspberryPin.LoadComboBoxAvailables(cmbRaspberryRelay, myConnection);
            
            RaspBerryPlayingBoard.ShowList(lstRaspberryRelays, myConnection);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRaspberryRelays.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList("لیست دستگاه ها و رله ها");

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region RaspBerryPlayingBoard Cast

            int playingBoardId = (int)((RaspBerryPlayingBoard)lstRaspberryRelays.SelectedItems[0].Tag).PlayingBoardID;

            if (!RaspBerryPlayingBoard.Validation_By_PlayingBoardID(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            RaspBerryPlayingBoard raspBerryPlayingBoard = RaspBerryPlayingBoard.Get_By_PlayingBoardID(playingBoardId, myConnection);
            #endregion

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(raspBerryPlayingBoard.RaspberryPin.PinNumber);

            if (message == DialogResult.Yes)
            {
                raspBerryPlayingBoard.RaspberryPin.IsAvailable = true;
                
                RaspBerryPlayingBoard.Delete(raspBerryPlayingBoard, myConnection);
                
                myConnection.SubmitChanges();

                DataValidationMesaage.DeleteMessage();

                RaspberryPin.LoadComboBoxAvailables(cmbRaspberryRelay, myConnection);
                
                RaspBerryPlayingBoard.ShowList(lstRaspberryRelays, myConnection);
            }

            myConnection.Dispose();

        }

        private void cmbPlayingBoardGroupTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
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

                    PlayingBoard.LoadComboBoxByFilter(cmbPlayingBoard, playingBoardTitle, myConnection);
                }
            }
        }

        private void cmbPlayingBoardTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
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

                    PlayingBoard.LoadComboBoxByFilter(cmbPlayingBoard, playingBoardTitle, myConnection);
                }
            }
        }

    }
}
