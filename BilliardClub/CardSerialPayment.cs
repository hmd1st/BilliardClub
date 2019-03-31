using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class CardSerialPayment
    {
        public CardSerialPayment(string cardPaymentIdentity, string cardNumber, string accountNumber) : this()
        {
            this.CardPaymentIdentity = cardPaymentIdentity;

            this.CardNumber = cardNumber;

            this.AccountNumber = accountNumber;

        }

        public static CardSerialPayment Insert(string cardPaymentIdentity, string cardNumber, string accountNumber,
            Payment payment, BankAccount bankAccount, DataBaseDataContext connection)
        {
            CardSerialPayment cardSerialPayment = new CardSerialPayment(cardPaymentIdentity, cardNumber, accountNumber);

            cardSerialPayment.BankAccount=BankAccount.Get(bankAccount.ID,connection);

            cardSerialPayment.Payment=Payment.Get(payment.ID,connection);

            connection.CardSerialPayments.InsertOnSubmit(cardSerialPayment);

            connection.SubmitChanges();

            return cardSerialPayment;

        }

        public static void Edit(CardSerialPayment cardSerialPayment,string cardPaymentIdentity, string cardNumber, string accountNumber,
           Payment payment, BankAccount bankAccount, DataBaseDataContext connection)
        {
            cardSerialPayment.CardPaymentIdentity = cardPaymentIdentity;

            cardSerialPayment.CardNumber = cardNumber;

            cardSerialPayment.AccountNumber = accountNumber;

            cardSerialPayment.BankAccount = BankAccount.Get(bankAccount.ID, connection);

            cardSerialPayment.Payment = Payment.Get(payment.ID, connection);

            connection.SubmitChanges();

        }

        public static void Delete(CardSerialPayment cardSerialPayment, DataBaseDataContext connection)
        {
            connection.CardSerialPayments.DeleteOnSubmit(cardSerialPayment);

            connection.SubmitChanges();

        }

        public static void LoadComboBox(ComboBox comboBox, DataBaseDataContext connection)
        {
            comboBox.Items.Clear();

            IQueryable<CardSerialPayment> queryable = connection.CardSerialPayments.Select(a => a);

            foreach (CardSerialPayment item in queryable)
            {
                comboBox.Items.Add(item);
            }

            if (!connection.CardSerialPayments.Any())
            {
                comboBox.Items.Add("یک آیتم به ثبت برسانید");

                comboBox.SelectedIndex = 0;

                return;
            }

            comboBox.SelectedIndex = 0;

        }

        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.CardSerialPayments.OrderByDescending(a => a.ID).Select(a => new
            {

                id=a.ID,
                cardPaymentIdentity=a.CardPaymentIdentity,
                cardNumber=a.CardNumber,
                accountNumber=a.AccountNumber
                
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 400;

            gridView.Columns[2].HeaderText = "شناسه پرداخت";

            gridView.Columns[3].Width = 400;

            gridView.Columns[3].HeaderText = "شماره کارت";

            gridView.Columns[4].Width = 400;

            gridView.Columns[4].HeaderText = "شماره حساب";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }



        }

        public static void LoadGrid_By_BankAccount(RadGridView gridView, BankAccount bankAccount, DataBaseDataContext connection)
        {
            var query = connection.CardSerialPayments.OrderByDescending(a => a.ID).Where(a=>a.BankAccount.Equals(bankAccount)).Select(a => new
            {

                id = a.ID,
                cardPaymentIdentity = a.CardPaymentIdentity,
                cardNumber = a.CardNumber,
                accountNumber = a.AccountNumber

            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 400;

            gridView.Columns[2].HeaderText = "شناسه پرداخت";

            gridView.Columns[3].Width = 400;

            gridView.Columns[3].HeaderText = "شماره کارت";

            gridView.Columns[4].Width = 400;

            gridView.Columns[4].HeaderText = "شماره حساب";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }



        }

        public static void LoadGrid_By_Payment(RadGridView gridView, Payment payment, DataBaseDataContext connection)
        {
            var query = connection.CardSerialPayments.OrderByDescending(a => a.ID).Where(a => a.Payment.Equals(payment)).Select(a => new
            {

                id = a.ID,
                cardPaymentIdentity = a.CardPaymentIdentity,
                cardNumber = a.CardNumber,
                accountNumber = a.AccountNumber

            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 400;

            gridView.Columns[2].HeaderText = "شناسه پرداخت";

            gridView.Columns[3].Width = 400;

            gridView.Columns[3].HeaderText = "شماره کارت";

            gridView.Columns[4].Width = 400;

            gridView.Columns[4].HeaderText = "شماره حساب";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }



        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.CardSerialPayments.Any(a => a.ID == id);
        }

        public static CardSerialPayment Get(int id, DataBaseDataContext connection)
        {
            return connection.CardSerialPayments.First(a => a.ID == id);
        }

    }
}
