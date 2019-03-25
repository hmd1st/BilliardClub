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
    public partial class FrmRent : FrmTemplate
    {
        public FrmRent()
        {
            InitializeComponent();
        }

        public static RentPlayingBoard MyRentPlayingBoard;

        private void FrmRent_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Member.LoadGridBriefly(gridMember, myConnection);

            PlayingBoard.LoadGridAvailables(gridPlayingBoard, myConnection);

            if (myConnection.PlayingBoards.Any(a => a.IsAvailable))
            {
                #region PlayingBoard Cast

                int playingBoardId = int.Parse(gridPlayingBoard.SelectedRows[0].Cells[1].Value.ToString());

                if (!PlayingBoard.Validation(playingBoardId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                PlayingBoard playingBoard = PlayingBoard.Get(playingBoardId, myConnection);

                #endregion

                PlayingBoardType.LoadComboBox_By_PlayingBoard(cmbPlayingBoardType, playingBoard, myConnection);
            }
            cmbSearchMemberBy.SelectedIndex = 0;

            cmbSearchPlayingBoardBy.SelectedIndex = 0;

            gridPlayingBoard.ClearSelection();
            
            gridMember.ClearSelection();

            myConnection.Dispose();

        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {

            if (gridMember.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridMember.Text);

                return;
            }

            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region PlayingBoard Cast

            int playingBoardId = int.Parse(gridPlayingBoard.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            #region Memeber Cast

            int memberId = int.Parse(gridMember.SelectedRows[0].Cells[1].Value.ToString());

            if (!Member.Validation(memberId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Member member = Member.Get(memberId, myConnection);
            #endregion

            if (!myConnection.PlayingBoardTypes.Any(a => a.PlayingBoard == playingBoard))
            {
                MessageBox.Show("برای این میز بازی هیچ قیمتی ثبت نشده است.", "کاربر گرامی", MessageBoxButtons.OK,
               MessageBoxIcon.Error);

                return;
            }

            if (myConnection.RaspBerryPlayingBoards.Any(a => a.PlayingBoard == playingBoard))
            {
                #region RaspBerryPlayingBoard Cast

                if (!RaspBerryPlayingBoard.Validation_By_PlayingBoardID(playingBoardId, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                RaspBerryPlayingBoard raspBerryPlayingBoard = RaspBerryPlayingBoard.Get_By_PlayingBoardID(playingBoardId, myConnection);

                #endregion

                MemberRentPlayingBoard.PowerOnOff(raspBerryPlayingBoard.RaspberryPin, "1", Setting.RaspberryIPAddress, Setting.RaspberryPortNumber);

            }

            #region PlayingBoardType Cast

            int playingBoardTypeID = ((PlayingBoardType)cmbPlayingBoardType.SelectedItem).ID;

            if (!PlayingBoardType.Validation(playingBoardTypeID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoardType playingBoardType = PlayingBoardType.Get(playingBoardTypeID, myConnection);

            #endregion

            MyRentPlayingBoard = RentPlayingBoard.Insert(playingBoardType, DateTime.Now,
                  DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("HH:mm:ss"), true, myConnection);

            MemberRentPlayingBoard.Insert(MyRentPlayingBoard, member, "opener", myConnection);


            playingBoard.IsAvailable = false;

            myConnection.SubmitChanges();

            PlayingBoard.LoadGridAvailables(gridPlayingBoard, myConnection);

            MessageBox.Show("بازی شروع شد.", "کاربر گرامی", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

            myConnection.Dispose();

        }

        private void gridMember_Click(object sender, EventArgs e)
        {
            if (gridMember.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridMember.Text);

                return;
            }

            lblName.Text = gridMember.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void gridPlayingBoard_Click(object sender, EventArgs e)
        {
            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }

            lblPlayingBoardTitle.Text = gridPlayingBoard.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (cmbSearchMemberBy.SelectedIndex == 0)
                Member.SearchGridByMemberCode_LoadGridBriefly(txtSearchMember.Text, gridMember, myConnection);
            else if (cmbSearchMemberBy.SelectedIndex == 1)
                Member.SearchGridByMemberFullName_LoadGridBriefly(txtSearchMember.Text, gridMember, myConnection);
            else if (cmbSearchMemberBy.SelectedIndex == 2)
                Member.SearchGridByMemberNationalCode_LoadGridBriefly(txtSearchMember.Text, gridMember, myConnection);

        }

        private void gridPlayingBoard_SelectionChanged(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (gridPlayingBoard.SelectedRows.Count==0)
            {
                return;
            }

            #region PlayingBoard Cast

            int playingBoardId = int.Parse(gridPlayingBoard.SelectedRows[0].Cells[1].Value.ToString());

            if (!PlayingBoard.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            PlayingBoard playingBoard = PlayingBoard.Get(playingBoardId, myConnection);

            #endregion

            PlayingBoardType.LoadComboBox_By_PlayingBoard(cmbPlayingBoardType, playingBoard, myConnection);
        }

        private void txtSearchPlayingBoard_TextChanged(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            //if (cmbSearchPlayingBoardBy.SelectedIndex == 0)
            PlayingBoard.Search_By_PlayingBoardTitle_LoadGridAvailables(txtSearchPlayingBoard.Text, gridPlayingBoard, myConnection);
            //else if (cmbSearchPlayingBoardBy.SelectedIndex == 1)
            //    Member.SearchGridByMemberFullName_LoadGridBriefly(txtSearchMember.Text, gridMember, myConnection);
            //else if (cmbSearchPlayingBoardBy.SelectedIndex == 2)
            //Member.SearchGridByMemberNationalCode_LoadGridBriefly(txtSearchMember.Text, gridMember, myConnection);

        }

    }
}
