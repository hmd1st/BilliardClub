using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
  public static  class FormManagement
    {
        public static void EnableYesNo(RadButton btnSave, RadButton btnEdit, RadButton btnDelete, RadButton btnYes,
            RadButton btnNo, RadGridView radGridView)
        {
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnNo.Enabled = true;
            btnYes.Enabled = true;
            radGridView.Enabled = false;
        }

        public static void EnableYesNo(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item.Name == "btnYes" || item.Name == "btnNo")
                    item.Enabled = true;

                else if ((item is RadButton || item is RadGridView))
                    item.Enabled = false;
            }
        }

        public static void EnableYesNoIncludingComboBox(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item.Name == "btnYes" || item.Name == "btnNo")
                    item.Enabled = true;

                else if ((item is RadButton || item is RadGridView || item is ComboBox))
                    item.Enabled = false;
            }
        }

        public static void DisableYesNo(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item.Name == "btnYes" || item.Name == "btnNo")
                    item.Enabled = false;
                else if ((item is RadButton || item is RadGridView))
                    item.Enabled =true;

            }

        }

        public static void DisableYesNoIncludingComboBox(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item.Name == "btnYes" || item.Name == "btnNo")
                    item.Enabled = false;
                else if ((item is RadButton || item is RadGridView || item is ComboBox))
                    item.Enabled = true;
            }

        }
        public static void DisableYesNo(RadButton btnSave, RadButton btnEdit, RadButton btnDelete, RadButton btnYes,
            RadButton btnNo, RadGridView radGridView)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnNo.Enabled = false;
            btnYes.Enabled = false;
            radGridView.Enabled = true;
        }

        public static void KeyEnterToSaveChanges(KeyEventArgs e, RadButton btnYes, RadButton btnSave)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!btnYes.Enabled)
                {
                    btnSave.PerformClick();
                }
                else
                {
                    btnYes.PerformClick();
                }
            }
        }

        public static void KeyDelToRemove(KeyEventArgs e, RadButton btnDelete)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete.PerformClick();
            }
        }

    }
}
