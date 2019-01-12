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
        public MemberCabinet(DateTime dateStart, DateTime dateEnd, bool status) : this()
        {
            this.DateStart = dateStart;

            this.DateEnd = dateEnd;

            this.Status = status;

        }

        public static MemberCabinet Insert(Cabinet cabinet, Member member, DateTime dateStart, DateTime dateEnd, bool status,
            DataBaseDataContext connection)
        {
            MemberCabinet memberCabinet = new MemberCabinet(dateStart, dateEnd, status);

            memberCabinet.Member = Member.Get(member.ID, connection);

            memberCabinet.Cabinet = Cabinet.Get(cabinet.ID, connection);

            connection.MemberCabinets.InsertOnSubmit(memberCabinet);

            connection.SubmitChanges();

            return memberCabinet;
        }

        public static void Edit(MemberCabinet memberCabinet, Cabinet cabinet, Member member,
            DateTime dateStart, DateTime dateEnd, DataBaseDataContext connection)
        {
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

        public static void LoadComboBoxByCabinet(ComboBox cmbBox, Cabinet cabinet,
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

        public static void LoadComboBoxByMember(ComboBox cmbBox, Member member,
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
                dateStart = a.DateStart,
                dateend = a.DateEnd
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "تاریخ شروع";

            grid.Columns[2].Width = 100;

            grid.Columns[3].HeaderText = "تاریخ پایان";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadGridMemberCabinet(RadGridView grid,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberCabinets.OrderByDescending(a => a.ID).Where(a => a.Status).Select(a => new
            {
                id = a.ID,
                memberFullName = a.Member.FirstName + " " + a.Member.LastName,
                cabinet = a.Cabinet.Title
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نام و نام خانوادگی";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "صندوق";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadGridByCabinet(RadGridView grid, Cabinet cabinet,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberCabinets.Where(a => a.Cabinet == cabinet)
                .Select(a => new
                {
                    id = a.ID,
                    memberFullName = a.Member.FirstName + " " + a.Member.LastName,
                    dateStart = a.DateStart,
                    dateEnd = a.DateEnd

                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نام و نام خانوادگی";

            grid.Columns[2].Width = 200;

            grid.Columns[3].HeaderText = "تاریخ شروع";

            grid.Columns[3].Width = 100;

            grid.Columns[4].HeaderText = "تاریخ پایان";

            grid.Columns[4].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }


        public static void LoadGridByMember(RadGridView grid, Member member,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberCabinets.Where(a => a.Member == member)
                .Select(a => new
                {
                    id = a.ID,
                    cabinetTitle = a.Cabinet.Title,
                    dateStart = a.DateStart,
                    dateend = a.DateEnd
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "شماره صندوق";

            grid.Columns[2].Width = 200;

            grid.Columns[3].HeaderText = "تاریخ شروع";

            grid.Columns[3].Width = 100;

            grid.Columns[4].HeaderText = "تاریخ پایان";

            grid.Columns[4].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void SearchGridMemberCabinetByMemberName(string text, RadGridView grid,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberCabinets.Where(a => a.Member.FirstName.Contains(text))
                .Select(a => new
                {
                    id = a.ID,
                    memberFullName = a.Member.FirstName + " " + a.Member.LastName,
                    cabinet = a.Cabinet.Title
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نام و نام خانوادگی";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "صندوق";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }
        public static void SearchGridMemberCabinetByCabinetTitle(string text, RadGridView grid,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberCabinets
                .Where(a => a.Cabinet.Title.Contains(text))
                .Select(a => new
                {
                    id = a.ID,
                    memberFullName = a.Member.FirstName + " " + a.Member.LastName,
                    cabinet = a.Cabinet.Title
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نام و نام خانوادگی";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "صندوق";

            grid.Columns[3].Width = 100;

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
