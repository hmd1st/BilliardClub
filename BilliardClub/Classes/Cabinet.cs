using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
   public partial class Cabinet
    {
        public Cabinet(string title): this()
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public static Cabinet Insert(string title,DataBaseDataContext connection)
        {
            Cabinet cabinet = new Cabinet(title);

            connection.Cabinets.InsertOnSubmit(cabinet);

            connection.SubmitChanges();

            return cabinet;
        }

        public static void Edit(Cabinet cabinet, string title, DataBaseDataContext connection)
        {
            cabinet.Title = title;

            connection.SubmitChanges();
        }

        public static void Delete(Cabinet cabinet,DataBaseDataContext connection)
        {
            connection.Cabinets.DeleteOnSubmit(cabinet);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<Cabinet> myQuery = connection.Cabinets.Select(a => a);

            cmbBox.Items.Clear();

            foreach (Cabinet item in myQuery)
            {
                cmbBox.Items.Add(item);
            }

            if (!myQuery.Any())
            {
                cmbBox.Items.Add("یک آیتم به ثبت برسانید");

                cmbBox.SelectedIndex = 0;
            }
            cmbBox.SelectedIndex = 0;
        }

        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var myQuery = connection.Cabinets.Select(a => new
            {
                id = a.ID,
                title = a.Title,
            });

            gridView.DataSource = myQuery;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "عنوان";

            gridView.Columns[2].Width = 300;

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id,DataBaseDataContext connection)
        {
            return connection.Cabinets.Any(a=>a.ID == id);
        }

        public static Cabinet Get(int id, DataBaseDataContext connection)
        {
            return connection.Cabinets.FirstOrDefault(a=>a.ID==id);
        }
    }
}
