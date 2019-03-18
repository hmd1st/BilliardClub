using System;
using System.Collections.Generic;
using System.Drawing;
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
        public PlayingBoard(string number, bool isAvailable) : this()
        {
            this.Number = number;

            this.IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return this.Number;
        }

        public static PlayingBoard Insert(PlayingBoardTitle PlayingBoardTitle, string number, bool isAvailable, DataBaseDataContext connection)
        {
            PlayingBoard playingBoard = new PlayingBoard(number, isAvailable);

            playingBoard.PlayingBoardTitle = PlayingBoardTitle;

            connection.PlayingBoards.InsertOnSubmit(playingBoard);

            connection.SubmitChanges();

            return playingBoard;
        }

        public static void Edit(PlayingBoard playingBoard, PlayingBoardTitle PlayingBoardTitle,
            string number, bool isAvailable, DataBaseDataContext connection)
        {
            playingBoard.Number = number;

            playingBoard.PlayingBoardTitle = PlayingBoardTitle;

            playingBoard.IsAvailable = isAvailable;

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

        public static void LoadComboBoxByFilter(ComboBox cmbBox, PlayingBoardTitle PlayingBoardTitle, DataBaseDataContext connection)
        {
            IQueryable<PlayingBoard> myQuery = connection.PlayingBoards.Where(a => a.PlayingBoardTitle == PlayingBoardTitle);

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
                title = a.PlayingBoardTitle.Title,
                number = a.Number
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "شماره";

            grid.Columns[3].Width = 300;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadGridAvailables(RadGridView grid, DataBaseDataContext connection)
        {
            var myQuery = connection.PlayingBoards.Where(a => a.IsAvailable).Select(a => new
            {
                id = a.ID,
                title = a.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " + a.PlayingBoardTitle.Title,
                number = a.Number
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";

            grid.Columns[2].Width = (int)Math.Ceiling(0.5 * grid.Width);

            grid.Columns[3].HeaderText = "شماره";

            grid.Columns[3].Width = (int)Math.Ceiling(0.4 * grid.Width);

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void Search_By_PlayingBoardTitle_LoadGridAvailables(string text, RadGridView grid, DataBaseDataContext connection)
        {
            var myQuery =
                connection.PlayingBoards.Where(
                        a => (a.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle.Contains(text.Trim()) ||
                        a.PlayingBoardTitle.Title.Contains(text.Trim())) && a.IsAvailable)
                    .Select(a => new
                    {
                        id = a.ID,
                        title = a.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " + a.PlayingBoardTitle.Title,
                        number = a.Number
                    });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";

            grid.Columns[2].Width = (int)Math.Ceiling(0.5 * grid.Width);

            grid.Columns[3].HeaderText = "شماره";

            grid.Columns[3].Width = (int)Math.Ceiling(0.4 * grid.Width);

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadGridColorful_By_PlayingBoardTitle(RadGridView grid, PlayingBoardTitle PlayingBoardTitle,
            DataBaseDataContext connection)
        {
            var myQuery =
                connection.PlayingBoards
                    .Where(a => a.PlayingBoardTitle == PlayingBoardTitle)
                    .Select(a => new
                    {
                        id = a.ID,
                        title = a.PlayingBoardTitle.Title,
                        number = a.Number,
                        isAvailable = a.IsAvailable
                    });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";

            grid.Columns[2].Width = (int)Math.Ceiling(0.44 * grid.Width);

            grid.Columns[3].HeaderText = "شماره";

            grid.Columns[3].Width = (int)Math.Ceiling(0.44 * grid.Width);

            grid.Columns[4].IsVisible = false;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;

                for (int j = 0; j < grid.Rows[i].Cells.Count; j++)
                {
                    grid.Rows[i].Cells[j].Style.CustomizeFill = true;

                    grid.Rows[i].Cells[j].Style.DrawFill = true;

                    grid.Rows[i].Cells[j].Style.BackColor = (bool)grid.Rows[i].Cells[4].Value
                        ? Color.LightGreen
                        : Color.Gray;
                }

            }

        }

        public static void LoadGrid_Join_PlayingBoardType(RadGridView grid,
            DataBaseDataContext connection)
        {
            //var myQuery = connection.PlayingBoards.Where(a => a.PlayingBoardTitle == playingBoardTitle).Select(a => new
            //{
            //    id = a.ID,
            //    title = a.PlayingBoardTitle.Title,
            //    number = a.Number
            //});

            var query = connection.PlayingBoards.Join(connection.PlayingBoardTypes,
                playingboard => playingboard.ID,
                playingboardtype => playingboardtype.PlayingBoardID,
                (a, b) => new
                {
                    id = a.ID,
                    title = a.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " + a.PlayingBoardTitle.Title + " " + a.Number,
                    type = b.Type,
                    price = b.Price
                });


            grid.DataSource = query;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";
            grid.Columns[2].Width = 207;

            grid.Columns[4].HeaderText = "نوع بازی";
            grid.Columns[4].Width = 100;

            grid.Columns[5].HeaderText = "قیمت به ساعت";
            grid.Columns[5].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadGrid_By_PlayingBoardTitle_Join_PlayingBoardType(PlayingBoardTitle playingBoardTitle, RadGridView grid,
            DataBaseDataContext connection)
        {
            //var myQuery = connection.PlayingBoards.Where(a => a.PlayingBoardTitle == playingBoardTitle).Select(a => new
            //{
            //    id = a.ID,
            //    title = a.PlayingBoardTitle.Title,
            //    number = a.Number
            //});

            var query =
                connection.PlayingBoards.Where(a => a.PlayingBoardTitle == playingBoardTitle)
                    .Join(connection.PlayingBoardTypes,
                        playingboard => playingboard.ID,
                        playingboardtype => playingboardtype.PlayingBoardID,
                        (a, b) => new
                        {
                            id = a.ID,
                            title =
                            a.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " + a.PlayingBoardTitle.Title +
                            " " + a.Number,
                            type = b.Type,
                            price = b.Price
                        });


            grid.DataSource = query;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";
            grid.Columns[2].Width = 207;

            grid.Columns[4].HeaderText = "نوع بازی";
            grid.Columns[4].Width = 100;

            grid.Columns[5].HeaderText = "قیمت به ساعت";
            grid.Columns[5].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        //public static void LoadGrid_By_PlayingBoardTitle_Join_PlayingBoardType(PlayingBoardTitle PlayingBoardTitle, RadGridView grid,
        //    DataBaseDataContext connection)
        //{
        //    //var myQuery = connection.PlayingBoards.Where(a => a.PlayingBoardTitle == playingBoardTitle).Select(a => new
        //    //{
        //    //    id = a.ID,
        //    //    title = a.PlayingBoardTitle.Title,
        //    //    number = a.Number
        //    //});

        //    var query = connection.PlayingBoards.Where(a => a.PlayingBoardTitle == PlayingBoardTitle).
        //        Join(connection.PlayingBoardTypes,
        //        playingboard => playingboard.ID,
        //        playingboardtype => playingboardtype.ID,
        //        (a, b) => new
        //        {
        //            id = a.ID,
        //            title = a.PlayingBoardTitle.Title,
        //            number = a.Number,
        //            type = b.Type,
        //            price = b.Price
        //        });


        //    grid.DataSource = query;

        //    grid.Columns[1].IsVisible = false;

        //    grid.Columns[2].HeaderText = "عنوان";

        //    grid.Columns[2].Width = 100;

        //    grid.Columns[3].HeaderText = "شماره";

        //    grid.Columns[3].Width = 100;

        //    grid.Columns[4].HeaderText = "نوع";
        //    grid.Columns[4].Width = 100;

        //    grid.Columns[5].HeaderText = "قیمت";
        //    grid.Columns[5].Width = 100;

        //    for (int i = 0; i < grid.RowCount; i++)
        //    {
        //        grid.Rows[i].Cells[0].Value = i + 1;
        //    }

        //}

        public static void LoadGridByPlayingBoardTitle(PlayingBoardTitle PlayingBoardTitle, RadGridView grid,
            DataBaseDataContext connection)
        {
            var myQuery = connection.PlayingBoards.Where(a => a.PlayingBoardTitle == PlayingBoardTitle).Select(a => new
            {
                id = a.ID,
                title = a.PlayingBoardTitle.Title,
                number = a.Number
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "شماره";

            grid.Columns[3].Width = 300;

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
