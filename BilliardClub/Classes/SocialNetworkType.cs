using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class SocialNetworkType
    {
        public SocialNetworkType(string title) : this()
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public static SocialNetworkType Insert(string title, DataBaseDataContext connection)
        {
            SocialNetworkType socialNetworkType = new SocialNetworkType(title);

            connection.SocialNetworkTypes.InsertOnSubmit(socialNetworkType);

            connection.SubmitChanges();

            return socialNetworkType;
        }

        public static void Edit(SocialNetworkType socialNetworkType, string title, DataBaseDataContext connection)
        {
            socialNetworkType.Title = title;

            connection.SubmitChanges();
        }

        public static void Delete(SocialNetworkType socialNetworkType, DataBaseDataContext connection)
        {
            connection.SocialNetworkTypes.DeleteOnSubmit(socialNetworkType);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<SocialNetworkType> myQuery = connection.SocialNetworkTypes.Select(a => a);

            cmbBox.Items.Clear();

            foreach (var item in myQuery)
            {
                cmbBox.Items.Add(item);
            }

            if (!myQuery.Any())
            {
                cmbBox.Items.Add("یک آیتم به ثبت برسانید");

                cmbBox.SelectedIndex = 0;

                return;
            }

            cmbBox.SelectedIndex = 0;
        }

        public static void LoadGrid(RadGridView grid, DataBaseDataContext connection)
        {
            var myQuery = connection.SocialNetworkTypes.Select(a => new
            {
                id = a.ID,
                title = a.Title
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "عنوان";

            grid.Columns[2].Width = 420;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.SocialNetworkTypes.Any(a => a.ID == id);
        }

        public static SocialNetworkType Get(int id, DataBaseDataContext connection)
        {
            return connection.SocialNetworkTypes.FirstOrDefault(a => a.ID == id);
        }
    }
}
