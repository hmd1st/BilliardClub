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
            cmbRaspberryRelay.SelectedIndex = 0;

            DataBaseDataContext myConnection = Setting.DataBase;

            RaspberryPi.ShowList(lstRaspberryRelays, myConnection);

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

            #region PlayingBoard Cast

            int playingBoardId = ((PlayingBoard)cmbPlayingBoard.SelectedItem).ID;

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            string pinNumber = RaspberryPi.GpioPins[int.Parse(cmbRaspberryRelay.SelectedItem.ToString()) - 1].ToString();

            RaspberryPi.Insert(pinNumber, playingBoard, myConnection);

            DataValidationMesaage.AcceptMessage();

            RaspberryPi.ShowList(lstRaspberryRelays, myConnection);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRaspberryRelays.SelectedItems.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList("لیست دستگاه ها و رله ها");

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region RaspberryPi Cast

            int playingBoardId = (int)((RaspberryPi)lstRaspberryRelays.SelectedItems[0].Tag).PlayingBoardID;

            if (!RaspberryPi.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            RaspberryPi raspberryPi = RaspberryPi.Get(playingBoardId, myConnection);
            #endregion

            DialogResult message = DataValidationMesaage.ConfirmDeleteData(raspberryPi.PinNumber);

            if (message == DialogResult.Yes)
            {
                RaspberryPi.Delete(raspberryPi, myConnection);

                DataValidationMesaage.DeleteMessage();

                RaspberryPi.ShowList(lstRaspberryRelays, myConnection);
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
