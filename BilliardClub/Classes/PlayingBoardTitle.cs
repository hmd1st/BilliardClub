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
    public partial class PlayingBoardTitle
    {
        public PlayingBoardTitle(string title):this()
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public static PlayingBoardTitle Insert(string title,DataBaseDataContext connection)
        {
            PlayingBoardTitle playingBoardTitle =new PlayingBoardTitle(title);

            connection.PlayingBoardTitles.InsertOnSubmit(playingBoardTitle);

            connection.SubmitChanges();

            return playingBoardTitle;
        }

        public static void Edit(PlayingBoardTitle playingBoardTitle, string title, DataBaseDataContext connection)
        {
            playingBoardTitle.Title = title;

            connection.SubmitChanges();
        }

        public static void Delete(PlayingBoardTitle playingBoardTitle, DataBaseDataContext connection)
        {
            connection.PlayingBoardTitles.DeleteOnSubmit(playingBoardTitle);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<PlayingBoardTitle> myQuery = connection.PlayingBoardTitles.Select(a => a);

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
            var myQuery = connection.PlayingBoardTitles.Select(a => new
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
            return connection.PlayingBoardTitles.Any(a => a.ID == id);
        }

        public static PlayingBoardTitle Get(int id, DataBaseDataContext connection)
        {
            return connection.PlayingBoardTitles.FirstOrDefault(a => a.ID == id);
        }
    }
}
