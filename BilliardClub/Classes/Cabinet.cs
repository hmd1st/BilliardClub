using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Cabinet(string title, bool isAvailable) : this()
        {
            this.Title = title;
            this.IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public static Cabinet Insert(string title, bool isAvailable, DataBaseDataContext connection)
        {
            Cabinet cabinet = new Cabinet(title, isAvailable);

            connection.Cabinets.InsertOnSubmit(cabinet);

            connection.SubmitChanges();

            return cabinet;
        }

        public static void Edit(Cabinet cabinet, string title,bool isAvailable, DataBaseDataContext connection)
        {
            cabinet.Title = title;

            cabinet.IsAvailable = isAvailable;

            connection.SubmitChanges();
        }

        public static void Delete(Cabinet cabinet, DataBaseDataContext connection)
        {
            connection.Cabinets.DeleteOnSubmit(cabinet);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            var myQuery = connection.Cabinets.Select(a => a);

            cmbBox.Items.Clear();

            foreach (var item in myQuery)
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

            gridView.Columns[2].Width = 422;

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadGridColorful(RadGridView gridView, DataBaseDataContext connection)
        {
            var myQuery = connection.Cabinets.Select(a => new
            {
                id = a.ID,
                title = a.Title,
                isAvailable=a.IsAvailable
            });

            gridView.DataSource = myQuery;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "عنوان";

            gridView.Columns[2].Width = 422;

            gridView.Columns[3].IsVisible = false;

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;

                for (int j = 0; j < gridView.Rows[i].Cells.Count; j++)
                {
                    gridView.Rows[i].Cells[j].Style.CustomizeFill = true;

                    gridView.Rows[i].Cells[j].Style.DrawFill = true;

                    gridView.Rows[i].Cells[j].Style.BackColor = (bool) gridView.Rows[i].Cells[3].Value
                        ? Color.LightGreen
                        : Color.Gray;
                }

            }

        }

        public static void LoadGridAvailables(RadGridView gridView, DataBaseDataContext connection)
        {
            var myQuery = connection.Cabinets.Where(a=>a.IsAvailable).Select(a => new
            {
                id = a.ID,
                title = a.Title,
            });

            gridView.DataSource = myQuery;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "عنوان";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.91 * gridView.Width); ;

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void SearchGridByTitle_LoadGridAvailables(string text, RadGridView gridView,
            DataBaseDataContext connection)
        {
            var myQuery =
                connection.Cabinets.OrderByDescending(a => a.ID)
                    .Where(a => a.IsAvailable && a.Title.Contains(text))
                    .Select(a => new
                    {
                        id = a.ID,
                        title = a.Title,
                    });

            gridView.DataSource = myQuery;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "عنوان";

            gridView.Columns[2].Width = (int) Math.Ceiling(0.91*gridView.Width);
            ;

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void ShowList(ListView list, DataBaseDataContext connection)
        {
            IQueryable<Cabinet> myQuery = connection.Cabinets.Select(a => a);

            list.Items.Clear();

            foreach (Cabinet item in myQuery)
            {
                ListViewItem lst = new ListViewItem();

                lst.Tag = item;

                lst.Text = item.ID.ToString();

                lst.SubItems.Add(item.Title);

                list.Items.Add(lst);
            }
        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.Cabinets.Any(a => a.ID == id);
        }

        public static Cabinet Get(int id, DataBaseDataContext connection)
        {
            return connection.Cabinets.FirstOrDefault(a => a.ID == id);
        }

    }
}
