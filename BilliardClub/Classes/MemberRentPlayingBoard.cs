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
    public partial class MemberRentPlayingBoard
    {
        private int _notification;

        public int Notification
        {
            get { return _notification; }
            set { _notification = Notification; }

        }

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
                    type=a.Type
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
    }
}
