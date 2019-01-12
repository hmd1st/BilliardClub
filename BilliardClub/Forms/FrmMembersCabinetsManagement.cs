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
    public partial class FrmMembersCabinetsManagement : FrmTemplate
    {

        public FrmMembersCabinetsManagement()
        {
            InitializeComponent();
        }

        private void FrmMembersCabinetsManagement_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            cmbSearchBy.SelectedIndex = 0;

            MemberCabinet.LoadGridMemberCabinet(gridCabinetMembers, myConnection);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridCabinetMembers.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridCabinetMembers.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region MemberCabinet Cast

            int memberCabinetID = int.Parse(gridCabinetMembers.SelectedRows[0].Cells[1].Value.ToString());

            if (!MemberCabinet.Validation(memberCabinetID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            MemberCabinet memberCabinet = MemberCabinet.Get(memberCabinetID, myConnection);

            #endregion

    //        MemberCabinet.Delete(memberCabinet, myConnection);

            memberCabinet.Cabinet.IsAvailable = true;

            memberCabinet.Status = false;

            myConnection.SubmitChanges();

            MemberCabinet.LoadGridMemberCabinet(gridCabinetMembers, myConnection);

            myConnection.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (cmbSearchBy != null && cmbSearchBy.Text == "عضو")
            {
                MemberCabinet.SearchGridMemberCabinetByMemberName(txtSearch.Text, gridCabinetMembers, myConnection);
            }
            else if (cmbSearchBy != null && cmbSearchBy.Text == "صندوق امانت")
            {
                MemberCabinet.SearchGridMemberCabinetByCabinetTitle(txtSearch.Text, gridCabinetMembers, myConnection);
            }
            myConnection.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (cmbSearchBy != null && cmbSearchBy.Text == "عضو")
            {
                MemberCabinet.SearchGridMemberCabinetByMemberName(txtSearch.Text, gridCabinetMembers, myConnection);
            }
            else if (cmbSearchBy != null && cmbSearchBy.Text == "صندوق امانت")
            {
                MemberCabinet.SearchGridMemberCabinetByCabinetTitle(txtSearch.Text, gridCabinetMembers, myConnection);
            }
            myConnection.Dispose();
        }

        private void gridCabinetMembers_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
