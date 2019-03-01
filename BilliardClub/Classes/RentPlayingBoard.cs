using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClub.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class RentPlayingBoard
    {

        public RentPlayingBoard(DateTime registerDate,
            string startTime, string endTime, bool status) : this()
        {
            this.RegisterDate = registerDate;

            this.StartTime = startTime;

            this.EndTime = endTime;

            this.Status = status;
        }

        public static RentPlayingBoard Insert(PlayingBoardType playingBoardType, DateTime registerDate,
            string startTime, string endTime, bool status, DataBaseDataContext connection)
        {
            RentPlayingBoard rentPlayingBoard = new RentPlayingBoard(registerDate, startTime, endTime, status);

            rentPlayingBoard.PlayingBoardType = playingBoardType;

            connection.RentPlayingBoards.InsertOnSubmit(rentPlayingBoard);

            connection.SubmitChanges();

            return rentPlayingBoard;
        }

        public static void Edit(RentPlayingBoard rentPlayingBoard, PlayingBoardType playingBoardType,
            DateTime registerDate, string startTime, string endTime, bool status,
            DataBaseDataContext connection)
        {
            rentPlayingBoard.RegisterDate = registerDate;

            rentPlayingBoard.StartTime = startTime;

            rentPlayingBoard.EndTime = endTime;

            rentPlayingBoard.Status = status;

            rentPlayingBoard.PlayingBoardType = playingBoardType;

            connection.SubmitChanges();
        }
        public static RentPlayingBoard Edit(RentPlayingBoard rentPlayingBoard, string endTime, bool status,
           DataBaseDataContext connection)
        {
            rentPlayingBoard.EndTime = endTime;

            rentPlayingBoard.Status = status;

            connection.SubmitChanges();

            return rentPlayingBoard;
        }

        public static void Delete(RentPlayingBoard rentPlayingBoard, DataBaseDataContext connection)
        {
            connection.RentPlayingBoards.DeleteOnSubmit(rentPlayingBoard);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<RentPlayingBoard> myQuery = connection.RentPlayingBoards.Select(a => a);

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

        public static void LoadComboBox_By_PlayingBoardType(ComboBox cmbBox, PlayingBoardType playingBoardType,
            DataBaseDataContext connection)
        {
            IQueryable<RentPlayingBoard> myQuery = connection.RentPlayingBoards.Where(a => a.PlayingBoardType == playingBoardType);

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
            var myQuery = connection.RentPlayingBoards.Select(a => new
            {
                id = a.ID,
                registerDate = a.RegisterDate,
                startTime = a.StartTime,
                endTime = a.EndTime,
                status = a.Status
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "تاریخ";

            grid.Columns[2].Width = 200;

            grid.Columns[2].HeaderText = "زمان شروع";

            grid.Columns[2].Width = 100;

            grid.Columns[2].HeaderText = "زمان پایان";

            grid.Columns[2].Width = 100;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGrid(RadGridView grid, PlayingBoardType playingBoardType,
            DataBaseDataContext connection)
        {
            var myQuery = connection.RentPlayingBoards.Where(a => a.PlayingBoardType == playingBoardType)
                .Select(a => new
                {
                    id = a.ID,
                    registerDate = a.RegisterDate,
                    startTime = a.StartTime,
                    endTime = a.EndTime,
                    status = a.Status
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "تاریخ";

            grid.Columns[2].Width = 200;

            grid.Columns[2].HeaderText = "زمان شروع";

            grid.Columns[2].Width = 100;

            grid.Columns[2].HeaderText = "زمان پایان";

            grid.Columns[2].Width = 100;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 100;


            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.RentPlayingBoards.Any(a => a.ID == id);
        }

        public static RentPlayingBoard Get(int id, DataBaseDataContext connection)
        {
            return connection.RentPlayingBoards.FirstOrDefault(a => a.ID == id);
        }


    }
}
