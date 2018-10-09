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
    public partial class PlayingBoardType
    {
        public PlayingBoardType(string type,int price) : this()
        {
            this.Type = type;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Type;
        }

        public static PlayingBoardType Insert(PlayingBoard playingBoard, string type, int price, DataBaseDataContext connection)
        {
            PlayingBoardType playingBoardType = new PlayingBoardType(type, price);

            playingBoardType.PlayingBoard = playingBoard;

            connection.PlayingBoardTypes.InsertOnSubmit(playingBoardType);

            connection.SubmitChanges();

            return playingBoardType;
        }

        public static void Edit(PlayingBoardType playingBoardType,PlayingBoard playingBoard, 
            string type, int price, DataBaseDataContext connection)
        {
            playingBoardType.Type = type;

            playingBoardType.Price = price;

            playingBoardType.PlayingBoard = playingBoard;

            connection.SubmitChanges();
        }

        public static void Delete(PlayingBoardType playingBoardType, DataBaseDataContext connection)
        {
            connection.PlayingBoardTypes.DeleteOnSubmit(playingBoardType);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<PlayingBoardType> myQuery = connection.PlayingBoardTypes.Select(a => a);

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

        public static void LoadFilteredComboBox(ComboBox cmbBox, PlayingBoard playingBoard,
            DataBaseDataContext connection)
        {
            IQueryable<PlayingBoardType> myQuery = connection.PlayingBoardTypes.Where(a => a.PlayingBoard == playingBoard);

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
            var myQuery = connection.PlayingBoardTypes.Select(a => new
            {
                id = a.ID,
                type = a.Type,
                price=a.Price
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نوع";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "قیمت";

            grid.Columns[3].Width = 300;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGrid(RadGridView grid, PlayingBoard playingBoard,
            DataBaseDataContext connection)
        {
            var myQuery = connection.PlayingBoardTypes.Where(a=>a.PlayingBoard==playingBoard)
                .Select(a => new
            {
                id = a.ID,
                type = a.Type,
                price = a.Price
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نوع";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "قیمت";

            grid.Columns[3].Width = 300;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.PlayingBoardTypes.Any(a => a.ID == id);
        }

        public static PlayingBoardType Get(int id, DataBaseDataContext connection)
        {
            return connection.PlayingBoardTypes.FirstOrDefault(a => a.ID == id);
        }
    }
}
