using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardClub
{
    public partial class FrmLevel : FrmTemplate
    {
        public FrmLevel()
        {
            InitializeComponent();
        }
        void ClearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Level.LoadGrid(gridLevel, myConnection);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("کاربر گرامی لطفا مقدار نام را کامل کنید", "اخطار در ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (myConnection.Levels.Any(a => a.Title == txtTitle.Text.Trim()))
            {
                MessageBox.Show("تکراری");

                return;
            }

            Level.Insert(txtTitle.Text.Trim(), myConnection);

            DataValidationMesaage.Accept();

            Level.LoadGrid(gridLevel, myConnection);

            ClearTextBox();
        }
    }
}
