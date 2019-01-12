using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub.Forms
{
    public partial class FrmMain : FrmTemplate
    {
        public FrmMain()
        {
            InitializeComponent();

            this.panUsingPlayingBoards.PanoramaElement.DragDropService.PreviewDragOver += PreviewDragOver;

        }

        void PreviewDragOver(object sender, Telerik.WinControls.RadDragOverEventArgs e)
        {
            Point mousePos = MousePosition;
            Point panoramaPoint = this.panUsingPlayingBoards.PointToClient(mousePos);
            TileGroupElement groupElement = GetItemGroup((RadTileElement)e.DragInstance);
            e.CanDrop = groupElement.ControlBoundingRectangle.Contains(panoramaPoint);
        }

        private TileGroupElement GetItemGroup(RadTileElement item)
        {
            foreach (TileGroupElement group in this.panUsingPlayingBoards.Groups)
            {
                if (group.Items.Contains(item))
                {
                    return group;
                }
            }

            return null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            //timerTime.Tick += new EventHandler(TimerTime_Tick);

            //timerTime.Interval = 1000;

            //timerTime.Start();
        }
        //private void TimerTime_Tick(object sender, EventArgs e)
        //{
        //   // DateTime dt = DateTime.Now;

        //    //PersianCalendar ps = new PersianCalendar();

        //    //tssTime.Text = $"{dt.Hour.ToString("00")}:{dt.Minute.ToString("00")}:{dt.Second.ToString("00")}";

        //    lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        //   // tssDate.Text = ps.GetYear(DateTime.Now).ToString("00") + "/" + ps.GetMonth(DateTime.Now).ToString("00") + "/" +
        //                  // ps.GetDayOfMonth(DateTime.Now).ToString("00");
        //}
        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            FrmSocialNetworkType frm = new FrmSocialNetworkType();

            frm.ShowDialog();
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            FrmPhone frm = new FrmPhone();

            frm.ShowDialog();
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            FrmLevel frm = new FrmLevel();

            frm.ShowDialog();

        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            FrmPlayingBoardTitle frm = new FrmPlayingBoardTitle();

            frm.ShowDialog();
        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            FrmCabinet frm = new FrmCabinet();

            frm.ShowDialog();
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {

            FrmMember frm = new FrmMember();

            frm.ShowDialog();
        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            FrmPlayingBoard frm = new FrmPlayingBoard();

            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButtonElement6_Click(object sender, EventArgs e)
        {
            FrmRent frm = new FrmRent();

            frm.ShowDialog();
        }

        private void btnCabinetMemberManagement_Click(object sender, EventArgs e)
        {
            FrmMembersCabinetsManagement frm = new FrmMembersCabinetsManagement();

            frm.ShowDialog();
        }

        private void radButtonElement9_Click(object sender, EventArgs e)
        {
            FrmMembersCabinetsManagement frm = new FrmMembersCabinetsManagement();

            frm.ShowDialog();
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            panUsingPlayingBoards.Groups.Clear();

            DataBaseDataContext myConnection = Setting.DataBase;

            List<TileGroupElement> tileGroupElements = new List<TileGroupElement>();


            if (myConnection.RentPlayingBoards.Any(a => a.Status))
            {
                var myQuery = myConnection.RentPlayingBoards.Where(a => a.Status);

                //var myQuery = myConnection.RentPlayingBoards.First(a => a.ID == FrmRent.MyRentPlayingBoard.ID);

                foreach (var query in myQuery.Select(a => a.PlayingBoard.PlayingBoardTitle).Distinct())
                {
                    

                    tileGroupElements.Add(RentPlayingBoard.AddTileGroupElement("PlayingBoardGroup" + query.ID,
                        query.Title));



                }
                foreach (var query in myQuery)
                {
                    foreach (var tileGroupElement in tileGroupElements)
                    {
                        if (query.PlayingBoard.PlayingBoardTitle.ToString() == tileGroupElement.Text)
                        {
                            RentPlayingBoard.AddPanoramaTile(tileGroupElement, panUsingPlayingBoards, "PlayingBoard" + query.ID,
                            query.PlayingBoard.PlayingBoardTitle.Title + " " + query.PlayingBoard.Number);
                        }

                    }
                }

            }
        }
    }
}
