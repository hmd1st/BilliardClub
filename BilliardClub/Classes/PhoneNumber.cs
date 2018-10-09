using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class PhoneNumber
    {
        public PhoneNumber(bool status, string number) : this()
        {
            this.Status = status;

            this.Number = number;


        }

        //public override string ToString()
        //{
        //    return this.Status;
        //}

        public static PhoneNumber Insert(Phone phone, Member member,
            bool status, string number, DataBaseDataContext connection)
        {
            PhoneNumber phoneNumber = new PhoneNumber(status, number);

            phoneNumber.Phone = phone;

            phoneNumber.Member = member;

            connection.PhoneNumbers.InsertOnSubmit(phoneNumber);

            connection.SubmitChanges();

            return phoneNumber;
        }

        public static void Edit(PhoneNumber phoneNumber, Phone phone, Member member,
            bool status, string number, DataBaseDataContext connection)
        {
            phoneNumber.Status = status;

            phoneNumber.Number = number;

            phoneNumber.Phone = phone;

            phoneNumber.Member = member;

            connection.SubmitChanges();
        }

        public static void Delete(PhoneNumber phoneNumber, DataBaseDataContext connection)
        {
            connection.PhoneNumbers.DeleteOnSubmit(phoneNumber);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<PhoneNumber> myQuery = connection.PhoneNumbers.Select(a => a);

            cmbBox.Items.Clear();

            foreach (var item in myQuery)
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

        public static void LoadFilteredComboBoxByPhone(ComboBox cmbBox, Phone phone,
            DataBaseDataContext connection)
        {
            IQueryable<PhoneNumber> myQuery = connection.PhoneNumbers.
                Where(a => a.Phone == phone);

            cmbBox.Items.Clear();

            foreach (var item in myQuery)
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

        public static void LoadFilteredComboBoxByMember(ComboBox cmbBox, Member member,
            DataBaseDataContext connection)
        {
            IQueryable<PhoneNumber> myQuery = connection.PhoneNumbers.
                Where(a => a.Member == member);

            cmbBox.Items.Clear();

            foreach (var item in myQuery)
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
        public static void LoadGrid(RadGridView grid, DataBaseDataContext connection)
        {
            var myQuery = connection.PhoneNumbers.Select(a => new
            {
                id = a.ID,
                status = a.Status,
                number = a.Number
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "شماره تماس";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByPhone(RadGridView grid, Phone phone,
            DataBaseDataContext connection)
        {
            var myQuery = connection.PhoneNumbers.Where(a => a.Phone == phone)
                .Select(a => new
                {
                    id = a.ID,
                    status = a.Status,
                    number = a.Number

                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "شماره تماس";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByMember(RadGridView grid, Member member,
            DataBaseDataContext connection)
        {
            var myQuery = connection.PhoneNumbers.Where(a => a.Member == member)
                .Select(a => new
                {
                    id = a.ID,
                    status = a.Status,
                    number = a.Number
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "شماره تماس";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.PhoneNumbers.Any(a => a.ID == id);
        }

        public static PhoneNumber Get(int id, DataBaseDataContext connection)
        {
            return connection.PhoneNumbers.FirstOrDefault(a => a.ID == id);
        }
    }
}
