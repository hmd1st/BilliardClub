using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class BankAccount
    {
        public BankAccount(string bankTitle, string cardNumber, string accountNumber) : this()
        {
            this.BankTitle = bankTitle;

            this.CardNumber = cardNumber;

            this.AccountNumber = accountNumber;
        }

        public override string ToString()
        {
            return this.BankTitle;
        }

        public static BankAccount Insert(string bankTitle, string cardNumber, string accountNumber, DataBaseDataContext connection)
        {
            BankAccount bankAccount = new BankAccount(bankTitle, cardNumber, accountNumber);

            connection.BankAccounts.InsertOnSubmit(bankAccount);

            connection.SubmitChanges();

            return bankAccount;
        }

        public static void Edit(BankAccount bankAccount, string bankTitle, string cardNumber, string accountNumber, DataBaseDataContext connection)
        {
            bankAccount.BankTitle = bankTitle;

            bankAccount.CardNumber = cardNumber;

            bankAccount.AccountNumber = cardNumber;

            connection.SubmitChanges();
        }

        public static void Delete(BankAccount bankAccount, DataBaseDataContext connection)
        {
            connection.BankAccounts.DeleteOnSubmit(bankAccount);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox comboBox, DataBaseDataContext connection)
        {
            comboBox.Items.Clear();

            var myQueryable = connection.BankAccounts.OrderByDescending(a => a.ID).Select(a => a);

            foreach (var item in myQueryable)
            {
                comboBox.Items.Add(item);
            }

            if (!myQueryable.Any())
            {
                comboBox.Items.Add("یک آیتم به ثبت برسانید");

                comboBox.SelectedIndex = 0;

                return;
            }

            comboBox.SelectedIndex = 0;

        }

        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var myQuery = connection.BankAccounts.Select(a => new
            {
                id = a.ID,
                bankTitle = a.BankTitle,
                cardNumber = a.CardNumber,
                accountNumber = a.AccountNumber

            });

            gridView.DataSource = myQuery;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = (int)Math.Ceiling(0.2 * gridView.Width);

            gridView.Columns[2].HeaderText = "نام بانک";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.4 * gridView.Width);

            gridView.Columns[3].HeaderText = "شماره کارت";

            gridView.Columns[4].Width = (int)Math.Ceiling(0.4 * gridView.Width);

            gridView.Columns[4].HeaderText = "شماره حساب";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.BankAccounts.Any(a => a.ID == id);
        }

        public static BankAccount Get(int id, DataBaseDataContext connection)
        {
            return connection.BankAccounts.First(a => a.ID == id);
        }

    }
}
