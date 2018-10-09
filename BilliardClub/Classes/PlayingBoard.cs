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
    public partial class PlayingBoard
    {
        public PlayingBoard(string number) : this()
        {
            this.Number = number;
        }

        public override string ToString()
        {
            return this.Number;
        }

        public static PlayingBoard Insert(PlayingBoardTitle playingBoardTitle,string number, DataBaseDataContext connection)
        {
            PlayingBoard playingBoard = new PlayingBoard(number);

            playingBoard.PlayingBoardTitle = playingBoardTitle;

            connection.PlayingBoards.InsertOnSubmit(playingBoard);

            connection.SubmitChanges();

            return playingBoard;
        }

        public static void Edit(PlayingBoard playingBoard, PlayingBoardTitle playingBoardTitle, 
            string number, DataBaseDataContext connection)
        { 
            playingBoard.Number = number;

            playingBoard.PlayingBoardTitle = playingBoardTitle;

            connection.SubmitChanges();
        }

        public static void Delete(PlayingBoard playingBoard, DataBaseDataContext connection)
        {
            connection.PlayingBoards.DeleteOnSubmit(playingBoard);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<PlayingBoard> myQuery = connection.PlayingBoards.Select(a => a);

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

        public static void LoadFilteredComboBox(ComboBox cmbBox, PlayingBoardTitle playingBoardTitle, DataBaseDataContext connection)
        {
            IQueryable<PlayingBoard> myQuery = connection.PlayingBoards.Where(a => a.PlayingBoardTitle==playingBoardTitle);

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
            var myQuery = connection.PlayingBoards.Select(a => new
            {
                id = a.ID,
                number = a.Number
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "شماره";

            grid.Columns[2].Width = 300;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGrid(RadGridView grid, PlayingBoardTitle playingBoardTitle, DataBaseDataContext connection)
        {
            var myQuery = connection.PlayingBoards.Where(a=>a.PlayingBoardTitle==playingBoardTitle)
                .Select(a => new
            {
                id = a.ID,
                number = a.Number
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "شماره";

            grid.Columns[2].Width = 300;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.PlayingBoards.Any(a => a.ID == id);
        }

        public static PlayingBoard Get(int id, DataBaseDataContext connection)
        {
            return connection.PlayingBoards.FirstOrDefault(a => a.ID == id);
        }
    }
}
