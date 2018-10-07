using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class Level
    {
        public Level(string title) : this()
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return this.Title;
        }
        public static Level Insert(string title, DataBaseDataContext connection)
        {
            Level level = new Level(title);

            connection.Levels.InsertOnSubmit(level);

            connection.SubmitChanges();

            return level;
        }
        public static void Edit(Level level, string title, DataBaseDataContext connection)
        {
            level.Title = title;

            connection.SubmitChanges();
        }
        public static void Delete(Level level, DataBaseDataContext connection)
        {
            connection.Levels.InsertOnSubmit(level);

            connection.SubmitChanges();
        }
        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<Level> myQuery = connection.Levels.Select(a => a);

            cmbBox.Items.Clear();

            foreach (Level item in myQuery)
            {
                cmbBox.Items.Add(item);
            }
            if (!myQuery.Any())
            {
                cmbBox.Items.Add("یک نوع عضویت به ثبت برسانید");

                cmbBox.SelectedIndex = 0;

                return;
            }
            cmbBox.SelectedIndex = 0;
        }
        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Levels.Select(a => new
            {
                id = a.ID,
                fullName = a.Title
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 200;

            gridView.Columns[2].HeaderText = "عنوان";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.Levels.Any(a => a.ID == id);
        }
        public static Level Get(int id, DataBaseDataContext connection)
        {
            return connection.Levels.FirstOrDefault(a => a.ID == id);
        }
    }
}
