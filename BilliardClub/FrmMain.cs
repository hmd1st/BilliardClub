using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardClub.Forms
{
    public partial class FrmMain : FrmTemplate
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

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
    }
}
