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

        private void radRibbonBarGroup1_Click(object sender, EventArgs e)
        {
           FrmPlayingBoard frm=new FrmPlayingBoard();

            frm.ShowDialog();
        }

        private void radRibbonBarGroup2_Click(object sender, EventArgs e)
        {
            FrmMember frm=new FrmMember();
            
            frm.ShowDialog();
        }
    }
}
