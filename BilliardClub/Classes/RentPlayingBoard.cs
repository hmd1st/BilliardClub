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

        public static RentPlayingBoard Insert(PlayingBoard playingBoard, DateTime registerDate,
            string startTime, string endTime, bool status, DataBaseDataContext connection)
        {
            RentPlayingBoard rentPlayingBoard = new RentPlayingBoard(registerDate, startTime, endTime, status);

            rentPlayingBoard.PlayingBoard = playingBoard;

            connection.RentPlayingBoards.InsertOnSubmit(rentPlayingBoard);

            connection.SubmitChanges();

            return rentPlayingBoard;
        }

        public static void Edit(RentPlayingBoard rentPlayingBoard, PlayingBoard playingBoard,
            DateTime registerDate, string startTime, string endTime, bool status,
            DataBaseDataContext connection)
        {
            rentPlayingBoard.RegisterDate = registerDate;

            rentPlayingBoard.StartTime = startTime;

            rentPlayingBoard.EndTime = endTime;

            rentPlayingBoard.Status = status;

            connection.SubmitChanges();
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

        public static void LoadFilteredGrid(RadGridView grid, PlayingBoard playingBoard,
            DataBaseDataContext connection)
        {
            var myQuery = connection.RentPlayingBoards.Where(a => a.PlayingBoard == playingBoard)
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

        public static TileGroupElement AddTileGroupElement(string name, string text)
        {
            TileGroupElement tileGroupElement = new Telerik.WinControls.UI.TileGroupElement();

            tileGroupElement.Font = new System.Drawing.Font("B Yekan", 20F);
            tileGroupElement.Name = name;
            tileGroupElement.Text = text;
            tileGroupElement.RowsCount = 4;

            return tileGroupElement;
        }

        public static void AddPanoramaTile(TileGroupElement tileGroupElement, RadPanorama radPanorama, string name, string text)
        {

            Timer timer=new Timer();

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Start();
            
            RadTileElement radTileElement = new Telerik.WinControls.UI.RadTileElement();
            tileGroupElement.Items.AddRange(new Telerik.WinControls.RadItem[] {
            radTileElement});
            radTileElement.Font = new System.Drawing.Font("B Yekan", 10F);
            radTileElement.Name = name;
            radTileElement.RightToLeft = true;
            radTileElement.Text = text;
            radTileElement.ColSpan = 1;
            radTileElement.TextAlignment=ContentAlignment.TopCenter;
            //radTileElement.AllowDrag = false;

            if (text.Length > 13)
                radTileElement.ColSpan = 2;


            //radTileElement.TextWrap = true;

            radTileElement.Text += Environment.NewLine + DateTime.Now.ToString("HH:mm");
            radTileElement.Text += Environment.NewLine ;

            radPanorama.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            tileGroupElement});
        }
    }
}
