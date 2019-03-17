using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class RaspBerryPlayingBoard
    {
        //public static List<int> ReservedPins = new List<int>
        //{1, 2, 4, 6, 9, 14, 17, 20, 25, 27, 28, 30, 34};

        //public static List<int> GpioPins = new List<int>()
        //{3, 5, 7, 8, 10, 11, 12, 13, 15, 16, 18, 19, 21, 22, 23, 24, 26, 29, 31, 32, 33, 35, 36, 37};

        public static RaspBerryPlayingBoard Insert(RaspberryPin raspberryPin, PlayingBoard playingBoard, DataBaseDataContext connection)
        {
            RaspBerryPlayingBoard raspBerryPlayingBoard = new RaspBerryPlayingBoard();

            raspBerryPlayingBoard.RaspberryPin = raspberryPin;

            raspBerryPlayingBoard.PlayingBoard = playingBoard;

            connection.RaspBerryPlayingBoards.InsertOnSubmit(raspBerryPlayingBoard);

            connection.SubmitChanges();

            return raspBerryPlayingBoard;

        }

        public static void Delete(RaspBerryPlayingBoard raspBerryPlayingBoard, DataBaseDataContext connection)
        {
            connection.RaspBerryPlayingBoards.DeleteOnSubmit(raspBerryPlayingBoard);

            connection.SubmitChanges();
        }

        public static void Edit(RaspBerryPlayingBoard raspBerryPlayingBoard, PlayingBoard playingBoard, RaspberryPin raspberryPin,
            DataBaseDataContext connection)
        {
            raspBerryPlayingBoard.RaspberryPin = raspberryPin;

            raspBerryPlayingBoard.PlayingBoard = playingBoard;

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox comboBox, DataBaseDataContext connection)
        {
            comboBox.Items.Clear();

            var query = connection.RaspBerryPlayingBoards.Select(a => a);

            foreach (var item in query)
            {
                comboBox.Items.Add(item);
            }

            if (!query.Any())
            {
                comboBox.Items.Add("یک آیتم به ثبت برسانید.");

                comboBox.SelectedIndex = 0;
            }

            comboBox.SelectedIndex = 0;

        }

        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.RaspBerryPlayingBoards.Select(a => new
            {
                playingBoard = a.PlayingBoard.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " + a.PlayingBoard.PlayingBoardTitle.Title + " " + a.PlayingBoard.Number,
                raspberryPin = a.RaspberryPin.PinNumber
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "میز بازی";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            gridView.Columns[2].HeaderText = "رله";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);


            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void SearchGridByPinNumber(RadGridView gridView, string text, DataBaseDataContext connection)
        {
            var query =
                connection.RaspBerryPlayingBoards
                    .Where(a => a.RaspberryPin.PinNumber.Contains(text))
                    .Select(a => new
                    {
                        playingBoard = a.PlayingBoard.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " + a.PlayingBoard.PlayingBoardTitle.Title + " " + a.PlayingBoard.Number,
                        raspberryPin = a.RaspberryPin.PinNumber
                    });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "میز بازی";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            gridView.Columns[2].HeaderText = "رله";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void SearchGridByPlayingBoard(RadGridView gridView, string text, DataBaseDataContext connection)
        {
            var query =
                connection.RaspBerryPlayingBoards
                    .Where(
                        a =>
                            a.PlayingBoard.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle.Contains(text) ||
                            a.PlayingBoard.PlayingBoardTitle.Title.Contains(text) ||
                            a.PlayingBoard.Number.Contains(text))
                    .Select(a => new
                    {
                        playingBoard = a.PlayingBoard.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " + a.PlayingBoard.PlayingBoardTitle.Title + " " + a.PlayingBoard.Number,
                        raspberryPin = a.RaspberryPin.PinNumber
                    });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "میز بازی";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            gridView.Columns[2].HeaderText = "رله";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void ShowList(ListView listView, DataBaseDataContext connection)
        {
            IQueryable<RaspBerryPlayingBoard> query = connection.RaspBerryPlayingBoards.Select(a => a);

            listView.Items.Clear();

            int counter = 1;

            foreach (RaspBerryPlayingBoard item in query)
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Tag = item;

                listViewItem.Text = counter++.ToString();

                listViewItem.SubItems.Add(item.PlayingBoard.PlayingBoardTitle.PlayingBoardGroupTitle.GroupTitle + " " +
                                          item.PlayingBoard.PlayingBoardTitle.Title + " " + item.PlayingBoard.Number);

                listViewItem.SubItems.Add(item.RaspberryPin.PinNumber);

                listView.Items.Add(listViewItem);
            }
        }

        public static bool Validation_By_PlayingBoardID(int playingBoardID, DataBaseDataContext connection)
        {
            return connection.RaspBerryPlayingBoards.Any(a => a.PlayingBoardID == playingBoardID);
        }
        public static bool Validation_By_RaspberryPinID(int raspberryPinID, DataBaseDataContext connection)
        {
            return connection.RaspBerryPlayingBoards.Any(a => a.RaspberryPinID == raspberryPinID);
        }
        public static RaspBerryPlayingBoard Get_By_PlayingBoardID(int playingBoardID, DataBaseDataContext connection)
        {
            return connection.RaspBerryPlayingBoards.FirstOrDefault(a => a.PlayingBoardID == playingBoardID);
        }
        public static RaspBerryPlayingBoard Get_By_RaspberryPinID(int raspberryPinID, DataBaseDataContext connection)
        {
            return connection.RaspBerryPlayingBoards.FirstOrDefault(a => a.RaspberryPinID == raspberryPinID);
        }
    }
}
