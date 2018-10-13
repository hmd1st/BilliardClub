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
    public partial class FrmCabinet : FrmTemplate
    {
        public FrmCabinet()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }

        private void FrmCabinet_Load(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            Cabinet.LoadGrid(gridCabinet, myConnection);

        }


    

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrEmpty(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }
            if (myConnection.Cabinets.Any(a=>a.Title==txtTitle.Text.Trim()))
            {
                DataValidationMesaage.DuplicateData("عنوان");

                return;
            }

            Cabinet cabinet = Cabinet.Insert(txtTitle.Text, myConnection);

            DataValidationMesaage.AcceptMessage(cabinet.Title);

            clearTextBox();
            
            Cabinet.LoadGrid(gridCabinet,myConnection);

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridCabinet.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridCabinet.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Cabinet Casting

            int cabinetID = int.Parse(gridCabinet.SelectedRows[0].Cells[1].Value.ToString());

            if (!Cabinet.Validation(cabinetID,myConnection))
            {
                DataValidationMesaage.NoDataInBank();
                
                return;
            }

            Cabinet cabinet=Cabinet.Get(cabinetID,myConnection);

            #endregion

            txtTitle.Text = cabinet.Title;

            FormManagement.EnableYesNo(this.Controls);

            txtTitle.Focus();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridCabinet.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridCabinet.Text);

                return;
            }
            DataBaseDataContext myConnection = Setting.DataBase;

            #region Cabinet Casting

            int cabinetID = int.Parse(gridCabinet.SelectedRows[0].Cells[1].Value.ToString());

            if (!Cabinet.Validation(cabinetID,myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Cabinet cabinet=Cabinet.Get(cabinetID,myConnection);

            #endregion

            if (cabinet.MemberCabinets.Any())
            {
                DataValidationMesaage.DataInUse(cabinet.Title,gridCabinet.Text);

                return;
            }
            DialogResult message = DataValidationMesaage.ConfirmDeleteData(cabinet.Title);

            if (message == DialogResult.Yes)
            {
                Cabinet.Delete(cabinet, myConnection);

                DataValidationMesaage.DeleteMessage();

                Cabinet.LoadGrid(gridCabinet, myConnection);

            }


        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            #region Cabinet Casting

            int cabinetID = int.Parse(gridCabinet.SelectedRows[0].Cells[1].Value.ToString());

            if (!Cabinet.Validation(cabinetID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;
            }

            Cabinet cabinet = Cabinet.Get(cabinetID, myConnection);

            #endregion

            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrEmpty(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }

            if (myConnection.Cabinets.Any(a=>a.Title==txtTitle.Text.Trim() && a.ID!=cabinet.ID))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            Cabinet.Edit(cabinet,txtTitle.Text.Trim(), myConnection);

            DataValidationMesaage.EditMessage();

            clearTextBox();

            Cabinet.LoadGrid(gridCabinet,myConnection);

            FormManagement.DisableYesNo(this.Controls);

        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();

            FormManagement.DisableYesNo(this.Controls);
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e,btnYes,btnSave);
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void gridCabinet_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyDelToRemove(e,btnDelete);
        }
    }
}
