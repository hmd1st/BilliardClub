using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
  public partial  class Payment
    {
        ///TODO ADD USER INSTANCE TO THIS CLASS

        public Payment(int price, DateTime date, bool isCredit, bool isCard, string description, int rentIdentity) : this()
        {
           
            this.Price = price;

            this.Date = date;

            this.IsCredit = isCredit;

            this.IsCard = isCard;

            this.Description = description;

            this.RentIdentity = rentIdentity;
        }

        public static Payment Insert(int price, DateTime date, bool isCredit, bool isCard, string description, int rentIdentity,Member member,DataBaseDataContext connection)
        { 
            Payment peyment=new Payment( price,  date, isCredit, isCard,  description,  rentIdentity);

            peyment.Member = Member.Get(member.ID, connection);

            connection.Payments.InsertOnSubmit(peyment);

            connection.SubmitChanges();

            return peyment;
        }

        public static void Edit(Payment payment, int price, DateTime date, bool isCredit, bool isCard, string description,
            int rentIdentity, Member member, DataBaseDataContext connection)
        {
            payment.Price = price;

            payment.Date = date;

            payment.IsCredit = isCredit;

            payment.IsCard = isCard;

            payment.Description = description;

            payment.RentIdentity = rentIdentity;

            payment.Member=Member.Get(member.ID,connection);

            connection.SubmitChanges();

        }

        public static void Delete(Payment payment,DataBaseDataContext connection)
        {
            connection.Payments.DeleteOnSubmit(payment);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<BankAccount> myQuery = connection.BankAccounts.Select(a => a);

            cmbBox.Items.Clear();

            foreach (BankAccount item in myQuery)
            {
                cmbBox.Items.Add(item);
            }
            if (!myQuery.Any())
            {
                cmbBox.Items.Add("یک آیتم به ثبت برسانید");

                cmbBox.SelectedIndex = 0;

                return;
            }
            cmbBox.SelectedIndex = 0;
        }
        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Payments.OrderByDescending(a => a.ID).Select(a=>new
            {
                Id=a.ID,
                price=a.Price,
                date=a.Date,
                isCredit=a.IsCredit,
                isCard = a.IsCard,
                description = a.Description
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 431;

            gridView.Columns[2].HeaderText = "مبلغ";

            gridView.Columns[3].Width = 431;

            gridView.Columns[3].HeaderText = "تاریخ";

            gridView.Columns[4].Width = 431;

            gridView.Columns[4].HeaderText = "نقدی/غیر نقدی";

            gridView.Columns[5].Width = 431;

            gridView.Columns[5].HeaderText = "نقدی/کارتی";

            gridView.Columns[6].Width = 431;

            gridView.Columns[6].HeaderText = "توضیحات";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.Payments.Any(a => a.ID == id);
        }

        public static Payment Get(int id, DataBaseDataContext connection)
        {
            return connection.Payments.First(a => a.ID == id);
        }
    }
}
