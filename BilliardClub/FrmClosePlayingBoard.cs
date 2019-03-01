using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClub.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class FrmClosePlayingBoard : FrmTemplate
    {

        private MemberRentPlayingBoard _memberRentPlaying;

        private Member _member;

        public MemberRentPlayingBoard memberRentPlayingBoard;

        public FrmClosePlayingBoard(MemberRentPlayingBoard memberRent)
        {
            this._memberRentPlaying = memberRent;

            InitializeComponent();
        }

        private void FrmClosePlayingBoard_Load(object sender, EventArgs e)
        {
            if (_memberRentPlaying.Day > 0)
            {
                lblElapsedTime.Text = _memberRentPlaying.Day + ":" +
                                      _memberRentPlaying.Hour.ToString("d2") + ":" +
                                      _memberRentPlaying.Minute.ToString("d2") + ":" +
                                      _memberRentPlaying.Second.ToString("d2");
            }
            else
            {
                lblElapsedTime.Text = _memberRentPlaying.Hour.ToString("d2") + ":" +
                                      _memberRentPlaying.Minute.ToString("d2") + ":" +
                                      _memberRentPlaying.Second.ToString("d2");
            }

            lblPayment.Text = _memberRentPlaying.Payment.ToString();

            lblPlayingBorad.Text = _memberRentPlaying.RentPlayingBoard.PlayingBoardType.PlayingBoard.PlayingBoardTitle.Title + " " +
                                   _memberRentPlaying.RentPlayingBoard.PlayingBoardType.PlayingBoard.Number;

            DataBaseDataContext myConnection = Setting.DataBase;

            memberRentPlayingBoard =
                myConnection.MemberRentPlayingBoards.First(
                    a => a.RentPlayingBoard.ID == _memberRentPlaying.RentPlayingBoard.ID);


            lblMemberRenter.Text = memberRentPlayingBoard.Member.FirstName + " " +
                                   memberRentPlayingBoard.Member.LastName;


            Member.LoadGridBriefly(gridMember, myConnection);

            cmbSearchMemberBy.SelectedIndex = 0;

            myConnection.Dispose();

            cmbSearchMemberBy.Enabled = false;

            txtSearchMember.Enabled = false;

            gridMember.Enabled = false;

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

            myConnection.Dispose();

        }

        private void FrmClosePlayingBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (gridMember.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridMember.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region RentPlayingBoard Cast

            int rentid = memberRentPlayingBoard.RentPlayingBoardID;

            if (!RentPlayingBoard.Validation(rentid, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            RentPlayingBoard rentPlayingBoard = RentPlayingBoard.Get(rentid, myConnection);

            #endregion

            if (radioOther.Checked)
            {
                #region Member Cast

                int id = int.Parse(gridMember.SelectedRows[0].Cells[1].Value.ToString());

                if (!Member.Validation(id, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                _member = Member.Get(id, myConnection);

                #endregion
            }

            if (radioMySelf.Checked)
            {
                #region Member Cast

                int id = memberRentPlayingBoard.Member.ID;

                if (!Member.Validation(id, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                _member = Member.Get(id, myConnection);

                #endregion
            }

            RentPlayingBoard myRentPlayingBoard = RentPlayingBoard.Edit(rentPlayingBoard,
                DateTime.Now.ToString("HH:mm:ss"), false, myConnection);

            MemberRentPlayingBoard.Insert(myRentPlayingBoard, _member, "Closer", myConnection);

            myRentPlayingBoard.PlayingBoardType.PlayingBoard.IsAvailable = true;

            myConnection.SubmitChanges();

            MessageBox.Show("End");
        }



        private void radioMySelf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMySelf_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioMySelf.Checked)
            {
                cmbSearchMemberBy.Enabled = false;
                txtSearchMember.Enabled = false;
                gridMember.Enabled = false;
            }
        }
        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOther.Checked)
            {
                cmbSearchMemberBy.Enabled = true;
                txtSearchMember.Enabled = true;
                gridMember.Enabled = true;
            }
        }
    }
}
