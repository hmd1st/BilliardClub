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
        public Payment(string title, int price, DateTime date, bool type, string description, int rentIdentity) : this()
        {
            this.Title = title;

            this.Price = price;

            this.Date = date;

            this.Type = type;

            this.Description = description;

            this.RentIdentity = rentIdentity;
        }

        public static Payment Insert(string title, int price, DateTime date, bool type, string description, int rentIdentity,Member member,DataBaseDataContext connection)
        { 
            Payment peyment=new Payment( title,  price,  date,  type,  description,  rentIdentity);

            peyment.Member = Member.Get(member.ID, connection);

            connection.Payments.InsertOnSubmit(peyment);

            connection.SubmitChanges();

            return peyment;
        }

        public static void Edit(Payment payment, string title, int price, DateTime date, bool type, string description,
            int rentIdentity, Member member, DataBaseDataContext connection)
        {
            payment.Title = title;

            payment.Price = price;

            payment.Date = date;

            payment.Type = type;

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

        public static void LoadComboBox(ComboBox comboBox,DataBaseDataContext connection)
        {
            comboBox.Items.Clear();

            IQueryable<Payment> myQueryable = connection.Payments.OrderByDescending(a => a.ID).Select(a=>a);

            foreach (Payment item in myQueryable)
            {
                comboBox.Items.Add(item);
            }

            if (!myQueryable.Any())
            {
                comboBox.Items.Add("یک آیتم به ثبت برسانید;");

                comboBox.SelectedIndex = 0;

                return;
            }
            comboBox.SelectedIndex = 0;

        }

        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Payments.OrderByDescending(a => a.ID).Select(a=>new
            {
                Id=a.ID,
                title=a.Title,
                price=a.Price,
                date=a.Date,
                type=a.Type,
                description=a.Description
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 431;

            gridView.Columns[2].HeaderText = "عنوان";

            gridView.Columns[3].Width = 431;

            gridView.Columns[3].HeaderText = "مبلغ";

            gridView.Columns[4].Width = 431;

            gridView.Columns[4].HeaderText = "تاریخ";

            gridView.Columns[5].Width = 431;

            gridView.Columns[5].HeaderText = "نقدی/غیر نقدی";

            gridView.Columns[6].Width = 431;

            gridView.Columns[6].HeaderText = "توضیحات";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
