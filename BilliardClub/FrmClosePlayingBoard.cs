using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private MemberRentPlayingBoard memberRentPlaying;

        public FrmClosePlayingBoard(MemberRentPlayingBoard memberRent)
        {
            this.memberRentPlaying = memberRent;

            InitializeComponent();
        }

        private void FrmClosePlayingBoard_Load(object sender, EventArgs e)
        {
            if (memberRentPlaying.Day > 0)
            {
                lblElapsedTime.Text = memberRentPlaying.Day + ":" +
                                      memberRentPlaying.Hour.ToString("d2") + ":" +
                                      memberRentPlaying.Minute.ToString("d2") + ":" +
                                      memberRentPlaying.Second.ToString("d2");
            }
            else
            {
                lblElapsedTime.Text = memberRentPlaying.Hour.ToString("d2") + ":" +
                                      memberRentPlaying.Minute.ToString("d2") + ":" +
                                      memberRentPlaying.Second.ToString("d2");
            }

            lblPayment.Text = memberRentPlaying.Payment.ToString();

            lblPlayingBorad.Text = memberRentPlaying.RentPlayingBoard.PlayingBoard.PlayingBoardTitle.Title + " " +
                                   memberRentPlaying.RentPlayingBoard.PlayingBoard.Number;

            DataBaseDataContext myConnection = Setting.DataBase;

            var memberRentPlayingBoard =
                myConnection.MemberRentPlayingBoards.First(
                    a => a.RentPlayingBoard.ID == memberRentPlaying.RentPlayingBoard.ID);


            lblMemberRenter.Text = memberRentPlayingBoard.Member.FirstName + " " +
                                   memberRentPlayingBoard.Member.LastName;


            Member.LoadGridBriefly(gridMember, myConnection);

            cmbSearchMemberBy.SelectedIndex = 0;

            myConnection.Dispose();

            cmbSearchMemberBy.Enabled = false;

            txtSearchMember.Enabled = false;

            btnSelect.Enabled = false;

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
            if ((sender as RadioButton).Name.Equals("radioMySelf"))
            {
                cmbSearchMemberBy.Enabled = false;
                txtSearchMember.Enabled = false;
                btnSelect.Enabled = false;
                gridMember.Enabled = false;
            }
            if ((sender as RadioButton).Name.Equals("radioOther"))
            {
                cmbSearchMemberBy.Enabled = true;
                txtSearchMember.Enabled = true;
                btnSelect.Enabled = true;
                gridMember.Enabled = true;
            }
        }
    }
}
