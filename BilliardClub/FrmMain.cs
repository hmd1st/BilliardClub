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

        public RentPlayingBoard rentPlayingBoard;

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
            RaspberryPi r=new RaspberryPi("1");


        }

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

                var myJoin =
                    Queryable.Join(myConnection.RentPlayingBoards.Where(a => a.Status), myConnection.PlayingBoardTypes,
                        playingboard => playingboard.PlayingBoardID, playingboardtype => playingboardtype.ID,
                        (a, b) => new
                        {
                            rentPlayingBoardID = a.ID,
                            type = b.Type,
                            price = b.Price
                        });

                foreach (var query in myQuery.Select(a => a.PlayingBoard.PlayingBoardTitle).Distinct())
                    tileGroupElements.Add(MemberRentPlayingBoard.AddTileGroupElement("PlayingBoard_Group_" + query.ID,
                        query.Title));

                foreach (var item in myQuery)
                {
                    DateTime oDate = item.RegisterDate;

                    TimeSpan timeSpan = DateTime.Now.Subtract(item.RegisterDate);

                    int second = timeSpan.Seconds;
                    int minute = timeSpan.Minutes;
                    int hour = timeSpan.Hours;
                    int day = timeSpan.Days;

                    foreach (var tileGroupElement in tileGroupElements)
                    {
                        if (item.PlayingBoard.PlayingBoardTitle.ToString() == tileGroupElement.Text)
                        {
                            foreach (var itemJoin in myJoin)
                            {
                                MemberRentPlayingBoard memberRentPlayingBoard = new MemberRentPlayingBoard();

                                memberRentPlayingBoard.RentPlayingBoard = item;

                                if (itemJoin != null && itemJoin.rentPlayingBoardID == item.ID)
                                    memberRentPlayingBoard.AddPanoramaTile(memberRentPlayingBoard, tileGroupElement,
                                        panUsingPlayingBoards,
                                        "PlayingBoard_Tile_" + item.ID,
                                        item.PlayingBoard.PlayingBoardTitle.Title + " " + item.PlayingBoard.Number,
                                        second, minute, hour, day, (double) itemJoin.price/3600);

                            }
                        }
                    }
                }
            }
        }

        private void radButtonElement10_Click(object sender, EventArgs e)
        {
            FrmPlayingBoardGroupTitle frm=new FrmPlayingBoardGroupTitle();

            frm.ShowDialog();
        }

        private void radButtonElement11_Click(object sender, EventArgs e)
        {
            FrmSetRaspberryRelays frm=new FrmSetRaspberryRelays();

            frm.ShowDialog();
        }
    }
}
