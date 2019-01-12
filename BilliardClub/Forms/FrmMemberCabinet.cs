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
    public partial class FrmMemberCabinet : FrmTemplate
    {
        private Member _selectedMember;

        public FrmMemberCabinet()
        {
            InitializeComponent();
        }

        private void FrmMemberCabinet_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            _selectedMember = FrmMember.MemberProfile;

            lblName.Text = _selectedMember.FirstName + " " + _selectedMember.LastName;

            Cabinet.LoadGridAvailables(gridCabinetAvailables, myConnection);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (gridCabinetAvailables.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridCabinetAvailables.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Cabinet Cast

            int cabinetId = int.Parse(gridCabinetAvailables.SelectedRows[0].Cells[1].Value.ToString());

            if (!Cabinet.Validation(cabinetId, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Cabinet cabinet = Cabinet.Get(cabinetId, myConnection);

            #endregion

            _selectedMember = FrmMember.MemberProfile;

            if (myConnection.MemberCabinets.Any(a => a.Member == _selectedMember && a.Status))
            {
                MessageBox.Show("به این عضو یک صندوق امانت اختصاص داده شده است", "کاربر گرامی", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);

                return;
            }

            MemberCabinet.Insert(cabinet, _selectedMember, DateTime.Now, DateTime.Now, true, myConnection);

            MessageBox.Show("عملیات اختصاص صندوق امانت به عضو با موفقیت انجام شد", "کاربر گرامی", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);

            cabinet.IsAvailable = false;

            myConnection.SubmitChanges();


            Cabinet.LoadGridAvailables(gridCabinetAvailables, myConnection);

            myConnection.Dispose();

        }

        private void btnMemberCabinetList_Click(object sender, EventArgs e)
        {
            FrmMembersCabinetsManagement frm = new FrmMembersCabinetsManagement();

            frm.ShowDialog();

            DataBaseDataContext myConnection = Setting.DataBase;

            Cabinet.LoadGridAvailables(gridCabinetAvailables, myConnection);

            myConnection.Dispose();

        }

        private void gridCabinetAvailables_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Cabinet.SearchGridByTitle_LoadGridAvailables(txtSearch.Text, gridCabinetAvailables, myConnection);

            myConnection.Dispose();
        }
    }
}
