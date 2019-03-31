using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            BankAccount.LoadComboBox(cmbBankAccount, Setting.DataBase);

            cmbSearchMemberBy.SelectedIndex = 0;

            cmbSearchMemberBy.Enabled = false;

            txtSearchMember.Enabled = false;

            gridMember.Enabled = false;

            cmbIsCredit.SelectedIndex = 0;

            int price = int.Parse(lblPayment.Text);

            int roundedPrice = 500 * ((price / 500) + 1);

            txtPrice.Text = roundedPrice.ToString();

            myConnection.Dispose();


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

            MemberRentPlayingBoard closerMemberRentPlayingBoard = MemberRentPlayingBoard.Insert(myRentPlayingBoard, _member, "Closer", myConnection);

            myRentPlayingBoard.PlayingBoardType.PlayingBoard.IsAvailable = true;

            int playingBoardID = myRentPlayingBoard.PlayingBoardType.PlayingBoardID;

            #region Raspberry Check and Turn off

            if (myConnection.RaspBerryPlayingBoards.Any(a => a.PlayingBoardID.Equals(playingBoardID)))
            {

                if (!RaspBerryPlayingBoard.Validation_By_PlayingBoardID(playingBoardID, myConnection))
                {
                    DataValidationMesaage.NoDataInBank();

                    return;
                }

                #region RaspBerryPlayingBoard Cast

                RaspBerryPlayingBoard raspBerryPlayingBoard = RaspBerryPlayingBoard.Get_By_PlayingBoardID(
                    playingBoardID, myConnection);

                #endregion

                MemberRentPlayingBoard.PowerOnOff(raspBerryPlayingBoard.RaspberryPin, "0", Setting.RaspberryIPAddress,
                    Setting.RaspberryPortNumber);
            }

            #endregion

            bool isCredit = true && cmbIsCredit.SelectedText.Equals("نسیه");

            bool isCard = true && radioCard.Checked;

            if (string.IsNullOrWhiteSpace(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                DataValidationMesaage.BlankTextBox("مبلغ پرداختی");

                return;
            }

            if (isCard)
            {
                if (string.IsNullOrWhiteSpace(txtCardPaymentIdentity.Text.Trim()) || string.IsNullOrEmpty(txtCardPaymentIdentity.Text.Trim()))
                {
                    DataValidationMesaage.BlankTextBox("شناسه پرداخت");

                    return;
                }

                if (myConnection.CardSerialPayments.Any(a=>a.CardPaymentIdentity.Equals(txtCardPaymentIdentity.Text.Trim())))
                {
                    DataValidationMesaage.DuplicateData("شناسه پرداخت");

                    return;
                }

            }

            Payment payment = Payment.Insert(int.Parse(txtPrice.Text.Trim()), DateTime.Now, isCredit, isCard, "", closerMemberRentPlayingBoard.ID, _member, myConnection);

            if (isCard)
            {


                CardSerialPayment.Insert(txtCardPaymentIdentity.Text.Trim(), txtCardNumber.Text.Trim(),
                    txtAccountNumber.Text.Trim(), payment, (BankAccount)cmbBankAccount.SelectedItem, myConnection);
            }

            myConnection.SubmitChanges();



            MessageBox.Show("بازی تمام شد.");

            DialogResult message = MessageBox.Show(
                "پرداخت انجام شد و میز بازی بسته شد. آیا مایل هستید پنجره جاری بسته شود؟ ",
                "کاربر گرامی", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                this.Close();
            }
            myConnection.Dispose();



        }

        private void radioMySelf_CheckedChanged(object sender, EventArgs e)
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

        private void radioCard_CheckedChanged(object sender, EventArgs e)
        {
            int origHeight = this.Height;

            if (radioCard.Checked)
            {
                while (this.Height < (origHeight + 80))
                {
                    this.Height++;

                    Application.DoEvents();

                }

                txtCardPaymentIdentity.Enabled = true;
                txtCardNumber.Enabled = true;
                txtAccountNumber.Enabled = true;
                cmbBankAccount.Enabled = true;


            }
            else
            {

                while (this.Height > (origHeight - 80))
                {
                    this.Height--;

                    Application.DoEvents();

                }

                txtCardPaymentIdentity.Enabled = false;
                txtCardNumber.Enabled = false;
                txtAccountNumber.Enabled = false;
                cmbBankAccount.Enabled = false;

            }
        }

    }
}
