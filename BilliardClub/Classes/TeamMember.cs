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

    public partial class TeamMember
    {
        public TeamMember(bool status, DateTime dateStart, DateTime dateEnd) : this()
        {
            this.Status = status;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;

        }

        //public override string ToString()
        //{
        //    return this.Status;
        //}

        public static TeamMember Insert(Team team, Member member,
            bool status, DateTime dateStart, DateTime dateEnd, DataBaseDataContext connection)
        {
            TeamMember teamMember = new TeamMember(status, dateStart, dateEnd);

            teamMember.Team = team;

            teamMember.Member = member;

            connection.TeamMembers.InsertOnSubmit(teamMember);

            connection.SubmitChanges();

            return teamMember;
        }

        public static void Edit(TeamMember teamMember, Team team, Member member,
            bool status, DateTime dateStart, DateTime dateEnd, DataBaseDataContext connection)
        {
            teamMember.Status = status;

            teamMember.DateStart = dateStart;

            teamMember.DateEnd = dateEnd;

            teamMember.Team = team;

            teamMember.Member = member;

            connection.SubmitChanges();
        }

        public static void Delete(TeamMember teamMember, DataBaseDataContext connection)
        {
            connection.TeamMembers.DeleteOnSubmit(teamMember);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<TeamMember> myQuery = connection.TeamMembers.Select(a => a);

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

        public static void LoadFilteredComboBoxByTeam(ComboBox cmbBox, Team team,
            DataBaseDataContext connection)
        {
            IQueryable<TeamMember> myQuery = connection.TeamMembers.
                Where(a => a.Team == team);

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
            IQueryable<TeamMember> myQuery = connection.TeamMembers.
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
            var myQuery = connection.TeamMembers.Select(a => new
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

        public static void LoadFilteredGridByTeam(RadGridView grid, Team team,
            DataBaseDataContext connection)
        {
            var myQuery = connection.TeamMembers.Where(a => a.Team == team)
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
            var myQuery = connection.TeamMembers.Where(a => a.Member == member)
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
            return connection.TeamMembers.Any(a => a.ID == id);
        }

        public static TeamMember Get(int id, DataBaseDataContext connection)
        {
            return connection.TeamMembers.FirstOrDefault(a => a.ID == id);
        }
    }
}
