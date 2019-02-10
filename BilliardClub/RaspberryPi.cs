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
    public partial class RaspberryPi
    {
        public static List<int> ReservedPins = new List<int>
        {1, 2, 4, 6, 9, 14, 17, 20, 25, 27, 28, 30, 34};

        public static List<int> GpioPins = new List<int>()
        {3, 5, 7, 8, 10, 11, 12, 13, 15, 16, 18, 19, 21, 22, 23, 24, 26, 29, 31, 32, 33, 35, 36, 37};

        public RaspberryPi(string pinNumber) : this()
        {
            this.PinNumber = pinNumber;

        }

        public override string ToString()
        {
            return this.PinNumber;
        }

        public static RaspberryPi Insert(string pinNumber, PlayingBoard playingBoard, DataBaseDataContext connection)
        {
            RaspberryPi raspberryPi = new RaspberryPi(pinNumber);

            raspberryPi.PlayingBoard = playingBoard;

            connection.RaspberryPis.InsertOnSubmit(raspberryPi);

            connection.SubmitChanges();

            return raspberryPi;

        }

        public static void Delete(RaspberryPi raspberryPi, DataBaseDataContext connection)
        {
            connection.RaspberryPis.DeleteOnSubmit(raspberryPi);

            connection.SubmitChanges();
        }

        public static void Edit(RaspberryPi raspberryPi, string pinNumber, PlayingBoard playingBoard,
            DataBaseDataContext connection)
        {
            raspberryPi.PinNumber = pinNumber;

            raspberryPi.PlayingBoard = playingBoard;

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox comboBox, DataBaseDataContext connection)
        {
            comboBox.Items.Clear();

            var query = connection.RaspberryPis.Select(a => a);


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
            var query = connection.RaspberryPis.Select(a => new
            {
                id = a.PlayingBoardID,
                pinNumber = a.PinNumber,
                playingboard = a.PlayingBoard.PlayingBoardTitle.Title + " " + a.PlayingBoard.Number
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "شماره پین";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            gridView.Columns[3].HeaderText = "میز بازی";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

       public static void SearchGridByPinNumber(RadGridView gridView, string text, DataBaseDataContext connection)
        {
            var query =
                connection.RaspberryPis.OrderByDescending(a => a.PlayingBoardID)
                    .Where(a => a.PinNumber.Contains(text))
                    .Select(a => new
                    {
                        id = a.PlayingBoardID,
                        pinNumber = a.PinNumber,
                        playingboard = a.PlayingBoard.PlayingBoardTitle.Title + " " + a.PlayingBoard.Number
                    });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "شماره پین";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            gridView.Columns[3].HeaderText = "میز بازی";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void SearchGridByPlayingBoard(RadGridView gridView, string text, DataBaseDataContext connection)
        {
            var query =
                connection.RaspberryPis.OrderByDescending(a => a.PlayingBoardID)
                    .Where(
                        a =>
                            a.PlayingBoard.PlayingBoardTitle.Title.Contains(text) ||
                            a.PlayingBoard.Number.Contains(text))
                    .Select(a => new
                    {
                        id = a.PlayingBoardID,
                        pinNumber = a.PinNumber,
                        playingboard = a.PlayingBoard.PlayingBoardTitle.Title + " " + a.PlayingBoard.Number
                    });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "شماره پین";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            gridView.Columns[3].HeaderText = "میز بازی";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void ShowList(ListView listView, DataBaseDataContext connection)
        {
            IQueryable<RaspberryPi> query = connection.RaspberryPis.Select(a => a);

            listView.Items.Clear();

            int counter = 1;

            foreach (RaspberryPi item in query)
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Tag = item;

                listViewItem.Text = counter++.ToString();

                listViewItem.SubItems.Add(item.PlayingBoard.PlayingBoardTitle.Title + " " + item.PlayingBoard.Number);

                //listViewItem.SubItems.Add(item.ToString());

                listViewItem.SubItems.Add((GpioPins.FindIndex(a => a == int.Parse(item.PinNumber)) + 1).ToString());

                listView.Items.Add(listViewItem);
            }
        }

        public static bool Validation(int playingBoardId, DataBaseDataContext connection)
        {
            return connection.RaspberryPis.Any(a => a.PlayingBoardID == playingBoardId);
        }

        public static RaspberryPi Get(int playingBoardId, DataBaseDataContext connection)
        {
            return connection.RaspberryPis.FirstOrDefault(a => a.PlayingBoardID == playingBoardId);
        }
    }
}
