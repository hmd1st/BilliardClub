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

            cmbSearchMemberBy.SelectedIndex = 0;

            cmbSearchPlayingBoardBy.SelectedIndex = 0;

            myConnection.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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

            #region RaspberryPi Cast

            if (!RaspberryPi.Validation(playingBoardId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            RaspberryPi raspberryPi = RaspberryPi.Get(playingBoardId, myConnection);

            #endregion

            MyRentPlayingBoard = RentPlayingBoard.Insert(playingBoard, DateTime.Now,
                 DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("HH:mm:ss"), true, myConnection);

            MemberRentPlayingBoard.Insert(MyRentPlayingBoard, member, "opener", myConnection);

            MemberRentPlayingBoard.PowerOnOff(raspberryPi,"1", Setting.RaspberryIPAddress,Setting.RaspberryPortNumber);

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

            lblName.Text = gridPlayingBoard.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void gridPlayingBoard_Click(object sender, EventArgs e)
        {
            if (gridPlayingBoard.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridPlayingBoard.Text);

                return;
            }

            lblPlayingBoardTitle.Text = gridPlayingBoard.SelectedRows[0].Cells[1].Value.ToString() + " " +
                                        gridPlayingBoard.SelectedRows[0].Cells[2].Value.ToString();
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
    }
}
