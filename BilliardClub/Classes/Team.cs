using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class Team
    {
        public Team(string title):this()
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public static Team Insert(string title, DataBaseDataContext connection)
        {
            Team team=new Team(title);

            connection.Teams.InsertOnSubmit(team);

            connection.SubmitChanges();

            return team;
        }

        public static void Edit(Team team,string title, DataBaseDataContext connection)
        {
            team.Title = title;

            connection.SubmitChanges();
        }

        public static void Delete(Team team, DataBaseDataContext connection)
        {
            connection.Teams.DeleteOnSubmit(team);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<Team> myQuery = connection.Teams.Select(a => a);

            cmbBox.Items.Clear();

            foreach (Team item in myQuery)
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
            var myQuery = connection.Teams.Select(a => new
            {
                id = a.ID,
                title = a.Title
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";

            grid.Columns[2].Width = 420;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.Teams.Any(a => a.ID == id);
        }

        public static Team Get(int id, DataBaseDataContext connection)
        {
            return connection.Teams.FirstOrDefault(a => a.ID == id);
        }
    }
}
