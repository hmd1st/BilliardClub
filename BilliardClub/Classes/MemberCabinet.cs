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
    public partial class MemberCabinet
    {
        public MemberCabinet(bool status, DateTime dateStart, DateTime dateEnd) : this()
        {
            this.Status = status;

            this.DateStart = dateStart;

            this.DateEnd = dateEnd;

        }

        //public override string ToString()
        //{
        //    return this.Status;
        //}

        public static MemberCabinet Insert(Cabinet cabinet, Member member,
            bool status, DateTime dateStart, DateTime dateEnd, DataBaseDataContext connection)
        {
            MemberCabinet memberCabinet = new MemberCabinet(status, dateStart, dateEnd);

            memberCabinet.Cabinet = cabinet;

            memberCabinet.Member = member;

            connection.MemberCabinets.InsertOnSubmit(memberCabinet);

            connection.SubmitChanges();

            return memberCabinet;
        }

        public static void Edit(MemberCabinet memberCabinet, Cabinet cabinet, Member member,
            bool status, DateTime dateStart, DateTime dateEnd, DataBaseDataContext connection)
        {
            memberCabinet.Status = status;

            memberCabinet.DateStart = dateStart;

            memberCabinet.DateEnd = dateEnd;

            memberCabinet.Cabinet = cabinet;

            memberCabinet.Member = member;

            connection.SubmitChanges();
        }

        public static void Delete(MemberCabinet memberCabinet, DataBaseDataContext connection)
        {
            connection.MemberCabinets.DeleteOnSubmit(memberCabinet);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<MemberCabinet> myQuery = connection.MemberCabinets.Select(a => a);

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

        public static void LoadFilteredComboBoxByCabinet(ComboBox cmbBox, Cabinet cabinet,
            DataBaseDataContext connection)
        {
            IQueryable<MemberCabinet> myQuery = connection.MemberCabinets.
                Where(a => a.Cabinet == cabinet);

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
            IQueryable<MemberCabinet> myQuery = connection.MemberCabinets.
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
            var myQuery = connection.MemberCabinets.Select(a => new
            {
                id = a.ID,
                status = a.Status,
                dateStart = a.DateStart,
                dateend = a.DateEnd
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "تاریخ شروع";

            grid.Columns[3].Width = 100;

            grid.Columns[4].HeaderText = "تاریخ پایان";

            grid.Columns[4].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByCabinet(RadGridView grid, Cabinet cabinet,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberCabinets.Where(a => a.Cabinet == cabinet)
                .Select(a => new
                {
                    id = a.ID,
                    status = a.Status,
                    dateStart = a.DateStart,
                    dateend = a.DateEnd

                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "تاریخ شروع";

            grid.Columns[3].Width = 100;

            grid.Columns[4].HeaderText = "تاریخ پایان";

            grid.Columns[4].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByMember(RadGridView grid, Member member,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberCabinets.Where(a => a.Member == member)
                .Select(a => new
                {
                    id = a.ID,
                    status = a.Status,
                    dateStart = a.DateStart,
                    dateend = a.DateEnd
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "تاریخ شروع";

            grid.Columns[3].Width = 100;

            grid.Columns[4].HeaderText = "تاریخ پایان";

            grid.Columns[4].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.MemberCabinets.Any(a => a.ID == id);
        }

        public static MemberCabinet Get(int id, DataBaseDataContext connection)
        {
            return connection.MemberCabinets.FirstOrDefault(a => a.ID == id);
        }
    }
}
