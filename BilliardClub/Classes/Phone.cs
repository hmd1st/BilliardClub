using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class Phone
    {
        public Phone(string title) : this()
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return this.Title;
        }
        public static Phone Insert(string title, DataBaseDataContext connection)
        {
            Phone phone = new Phone(title);

            connection.Phones.InsertOnSubmit(phone);

            connection.SubmitChanges();

            return phone;
        }
        public static void Edit(Phone phone, string title, DataBaseDataContext connection)
        {
            phone.Title = title;

            connection.SubmitChanges();
        }
        public static void Delete(Phone phone, DataBaseDataContext connection)
        {
            connection.Phones.DeleteOnSubmit(phone);

            connection.SubmitChanges();
        }
        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<Phone> myQuery = connection.Phones.Select(a => a);

            cmbBox.Items.Clear();

            foreach (Phone item in myQuery)
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
            var myQuery = connection.Phones.Select(a => new
            {
                id = a.ID,
                title = a.Title
            });

            gridView.DataSource = myQuery;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 420;

            gridView.Columns[2].HeaderText = "عنوان";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.Phones.Any(a => a.ID == id);
        }
        public static Phone Get(int id, DataBaseDataContext connection)
        {
            return connection.Phones.FirstOrDefault(a => a.ID == id);
        }
    }
}
