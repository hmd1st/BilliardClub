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
    public partial class PlayingBoardGroupTitle
    {
        public PlayingBoardGroupTitle(string groupTitle) : this()
        {
            this.GroupTitle = groupTitle;
        }

        public override string ToString()
        {
            return this.GroupTitle;
        }

        public static PlayingBoardGroupTitle Insert(string groupTitle, DataBaseDataContext connection)
        {
            PlayingBoardGroupTitle playingBoardGroupTitle = new PlayingBoardGroupTitle(groupTitle);

            connection.PlayingBoardGroupTitles.InsertOnSubmit(playingBoardGroupTitle);

            connection.SubmitChanges();

            return playingBoardGroupTitle;
        }

        public static void Edit(PlayingBoardGroupTitle playingBoardGroupTitle, string groupTitle, DataBaseDataContext connection)
        {
            playingBoardGroupTitle.GroupTitle = groupTitle;

            connection.SubmitChanges();
        }

        public static void Delete(PlayingBoardGroupTitle playingBoardGroupTitle, DataBaseDataContext connection)
        {
            connection.PlayingBoardGroupTitles.DeleteOnSubmit(playingBoardGroupTitle);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<PlayingBoardGroupTitle> myQuery =
                connection.PlayingBoardGroupTitles.OrderByDescending(a => a.ID).Select(a => a);

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
            var myQuery = connection.PlayingBoardGroupTitles.Select(a => new
            {
                id = a.ID,
                groupTitle = a.GroupTitle
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
            return connection.PlayingBoardGroupTitles.Any(a => a.ID == id);
        }

        public static PlayingBoardGroupTitle Get(int id, DataBaseDataContext connection)
        {
            return connection.PlayingBoardGroupTitles.FirstOrDefault(a => a.ID == id);
        }
    }
}
