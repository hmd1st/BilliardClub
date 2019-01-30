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

    public partial class MemberRentPlayingBoard
    {
        private RadTileElement _radTileElement;

        public int Day { get; private set; }

        public int Hour { get; private set; }

        public int Minute { get; private set; }

        public int Second { get; private set; }

        public double Price { get; private set; }

        public double Payment { get; private set; }


        private string _radTileText = "";

        public MemberRentPlayingBoard(string type) : this()
        {
            this.Type = type;
        }

        public override string ToString()
        {
            return this.Type;
        }

        public static MemberRentPlayingBoard Insert(RentPlayingBoard rentPlayingBoard, Member member,
            string type, DataBaseDataContext connection)
        {
            MemberRentPlayingBoard memberRentPlayingBoard = new MemberRentPlayingBoard(type);

            memberRentPlayingBoard.RentPlayingBoard = rentPlayingBoard;

            memberRentPlayingBoard.Member = member;

            connection.MemberRentPlayingBoards.InsertOnSubmit(memberRentPlayingBoard);

            connection.SubmitChanges();

            return memberRentPlayingBoard;
        }

        public static void Edit(MemberRentPlayingBoard memberRentPlayingBoard, RentPlayingBoard rentPlayingBoard, Member member,
            string type, DataBaseDataContext connection)
        {
            memberRentPlayingBoard.Type = type;

            memberRentPlayingBoard.RentPlayingBoard = rentPlayingBoard;

            memberRentPlayingBoard.Member = member;

            connection.SubmitChanges();
        }

        public static void Delete(MemberRentPlayingBoard memberRentPlayingBoard, DataBaseDataContext connection)
        {
            connection.MemberRentPlayingBoards.DeleteOnSubmit(memberRentPlayingBoard);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<MemberRentPlayingBoard> myQuery = connection.MemberRentPlayingBoards.Select(a => a);

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

        public static void LoadFilteredComboBoxByRentPlayingBoard(ComboBox cmbBox, RentPlayingBoard rentPlayingBoard,
            DataBaseDataContext connection)
        {
            IQueryable<MemberRentPlayingBoard> myQuery = connection.MemberRentPlayingBoards.
                Where(a => a.RentPlayingBoard == rentPlayingBoard);

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

        public static void LoadFilteredComboBoxByMember(ComboBox cmbBox, Member member,
            DataBaseDataContext connection)
        {
            IQueryable<MemberRentPlayingBoard> myQuery = connection.MemberRentPlayingBoards.
                Where(a => a.Member == member);

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
            var myQuery = connection.MemberRentPlayingBoards.Select(a => new
            {
                id = a.ID,
                type = a.Type
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نوع";

            grid.Columns[2].Width = 300;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByRentPlayingBoard(RadGridView grid, RentPlayingBoard rentPlayingBoard,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberRentPlayingBoards.Where(a => a.RentPlayingBoard == rentPlayingBoard)
                .Select(a => new
                {
                    id = a.ID,
                    type = a.Type
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نوع";

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByMember(RadGridView grid, Member member,
            DataBaseDataContext connection)
        {
            var myQuery = connection.MemberRentPlayingBoards.Where(a => a.Member == member)
                .Select(a => new
                {
                    id = a.ID,
                    type = a.Type
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "نوع";

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.MemberRentPlayingBoards.Any(a => a.ID == id);
        }

        public static MemberRentPlayingBoard Get(int id, DataBaseDataContext connection)
        {
            return connection.MemberRentPlayingBoards.FirstOrDefault(a => a.ID == id);
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

        public void AddPanoramaTile(MemberRentPlayingBoard memberRent, TileGroupElement tileGroupElement,
            RadPanorama radPanorama, string name, string text, int second, int minute, int hour, int day, double price)
        {

            Timer timer = new Timer();

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.Second = second;

            this.Minute = minute;

            this.Hour = hour;

            this.Day = day;

            this.Price = price;

            _radTileElement = new Telerik.WinControls.UI.RadTileElement();
            tileGroupElement.Items.AddRange(new Telerik.WinControls.RadItem[]
            {
                _radTileElement
            });


            _radTileElement.Font = new System.Drawing.Font("B Yekan", 10F);
            _radTileElement.Tag = memberRent;
            _radTileElement.Name = name;
            _radTileElement.RightToLeft = true;
            _radTileElement.Text = text;
            _radTileElement.ColSpan = 1;
            _radTileElement.TextAlignment = ContentAlignment.TopCenter;

           //radTileElement.AllowDrag = false;

            if (text.Length > 13)
                _radTileElement.ColSpan = 2;

            _radTileText = text;

            radPanorama.Groups.AddRange(new Telerik.WinControls.RadItem[]
            {
                tileGroupElement
            });

            _radTileElement.Click += _radTileElement_Click;

        }

        private void _radTileElement_Click(object sender, EventArgs e)
        {
            FrmClosePlayingBoard frmClosePlayingBoard = new FrmClosePlayingBoard((MemberRentPlayingBoard)_radTileElement.Tag);

            frmClosePlayingBoard.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _radTileElement.Text = _radTileText;
            this.Second++;
            if (this.Second > 60)
            {
                this.Minute++;
                this.Second = 0;
            }
            if (this.Minute > 60)
            {
                this.Hour++;
                this.Minute = 0;
                this.Second = 0;
            }

            if (this.Hour > 23 && this.Minute > 59 && this.Second > 59)
            {
                this.Day++;
                this.Hour = 0;
                this.Minute = 0;
                this.Second = 0;
            }
            // radTileElement.Text += Environment.NewLine + DateTime.Now.ToString("HH:mm:ss");
            if (this.Day > 30)
            {
                _radTileElement.Text += Environment.NewLine + "متوقف کنید";
            }
            else if (this.Day > 0)
            {
                _radTileElement.Text += Environment.NewLine + this.Day.ToString() + ":" + this.Hour.ToString("d2") +
                                        ":" + this.Minute.ToString("d2") + ":" +
                                        this.Second.ToString("d2");
            }
            else
            {
                _radTileElement.Text += Environment.NewLine + this.Hour.ToString("d2") +
                                        ":" + this.Minute.ToString("d2") + ":" +
                                        this.Second.ToString("d2");
            }


            int mySec = this.Second;
            int myMin = this.Minute;
            int myhour = this.Hour;
            int myDay = this.Day;

            myMin *= 60;
            myhour *= 3600;
            myDay *= 86400;

            this.Payment = Math.Round(((myDay + myhour + myMin + mySec) * this.Price));

            _radTileElement.Text += Environment.NewLine + this.Payment;

        }
    }
}
