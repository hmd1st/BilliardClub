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
    public partial class FrmTeam : FrmTemplate
    {
        public FrmTeam()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            txtTitle.Clear();

            txtTitle.Focus();
        }

        private void FrmTeam_Load(object sender, EventArgs e)
        {
            Team.LoadGrid(gridTeam,Setting.DataBase);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }
            if (myConnection.Teams.Any(a=>a.Title==txtTitle.Text.Trim()))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            Team team = Team.Insert(txtTitle.Text.Trim(), myConnection);

            clearTextBox();

            DataValidationMesaage.AcceptMessage(team.Title);

            Team.LoadGrid(gridTeam,myConnection);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (gridTeam.SelectedRows.Count == 0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridTeam.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Team Casting
           
            int teamID = int.Parse(gridTeam.SelectedRows[0].Cells[1].Value.ToString());

            if (!Team.Validation(teamID,myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            Team team = Team.Get(teamID, myConnection);

            #endregion

            txtTitle.Text = team.Title;

            FormManagement.EnableYesNo(this.Controls);

            txtTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridTeam.SelectedRows.Count==0)
            {
                DataValidationMesaage.NoSelectedItemFromList(gridTeam.Text);

                return;
            }

            DataBaseDataContext myConnection = Setting.DataBase;

            #region Team Casting

            int teamID = int.Parse(gridTeam.SelectedRows[0].Cells[1].Value.ToString());

            if (!Team.Validation(teamID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            Team team = Team.Get(teamID, myConnection);

            #endregion

            if (team.TeamMembers.Any())
            {
                DataValidationMesaage.DataInUse(team.Title,gridTeam.Text);

                return;
            }
            DialogResult message = DataValidationMesaage.ConfirmDeleteData(team.Title);

            if (message==DialogResult.Yes)
            { 
                Team.Delete(team, myConnection);

                DataValidationMesaage.DeleteMessage();

                Team.LoadGrid(gridTeam,myConnection);

            }
            


        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DataBaseDataContext myConnection = Setting.DataBase;

            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                DataValidationMesaage.BlankTextBox("عنوان");

                return;
            }

            #region Team Casting

            int teamID = int.Parse(gridTeam.SelectedRows[0].Cells[1].Value.ToString());

            if (!Team.Validation(teamID, myConnection))
            {
                DataValidationMesaage.NoDataInBank();

                return;

            }

            Team team = Team.Get(teamID, myConnection);

            #endregion

            if (myConnection.Teams.Any(a => a.Title == txtTitle.Text.Trim() && a.ID !=team.ID))
            {
                DataValidationMesaage.DuplicateData(txtTitle.Text);

                return;
            }

            Team.Edit(team,txtTitle.Text.Trim(),myConnection);

            DataValidationMesaage.EditMessage();

            clearTextBox();

            Team.LoadGrid(gridTeam, myConnection);

            FormManagement.DisableYesNo(this.Controls);

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FormManagement.DisableYesNo(this.Controls);

            txtTitle.Focus();
        }
        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyEnterToSaveChanges(e, btnYes, btnSave);
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            BTM.Language.SwitchToPersian();
        }

        private void gridTeam_KeyDown(object sender, KeyEventArgs e)
        {
            FormManagement.KeyDelToRemove(e, btnDelete);
        }
    }
}
