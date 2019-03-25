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
    public partial class RaspberryPin
    {
        //public static List<int> ReservedPins = new List<int>
        //{1, 2, 4, 6, 9, 14, 17, 20, 25, 27, 28, 30, 34};

        //public static List<int> GpioPins = new List<int>()
        //{3, 5, 7, 8, 10, 11, 12, 13, 15, 16, 18, 19, 21, 22, 23, 24, 26, 29, 31, 32, 33, 35, 36, 37};

        public RaspberryPin(string pinNumber, bool isAvailable) : this()
        {
            this.PinNumber = pinNumber;

            this.IsAvailable = isAvailable;

        }

        public override string ToString()
        {
            return this.PinNumber;
        }

        public static RaspberryPin Insert(string pinNumber, bool isAvailable, DataBaseDataContext connection)
        {
            RaspberryPin raspberryPin = new RaspberryPin(pinNumber, isAvailable);

            connection.RaspberryPins.InsertOnSubmit(raspberryPin);

            connection.SubmitChanges();

            return raspberryPin;

        }

        public static void Delete(RaspberryPin raspberryPin, DataBaseDataContext connection)
        {
            connection.RaspberryPins.DeleteOnSubmit(raspberryPin);

            connection.SubmitChanges();
        }

        public static void Edit(RaspberryPin raspberryPin, string pinNumber, bool isAvailable,
            DataBaseDataContext connection)
        {
            raspberryPin.PinNumber = pinNumber;

            raspberryPin.IsAvailable = isAvailable;

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox comboBox, DataBaseDataContext connection)
        {
            comboBox.Items.Clear();

            var query = connection.RaspberryPins.Select(a => a);

            foreach (var item in query)
            {
                comboBox.Items.Add(item);
            }

            if (!query.Any())
            {
                comboBox.Items.Add("یک آیتم به ثبت برسانید.");

                comboBox.SelectedIndex = 0;
            }

            comboBox.SelectedIndex = 0;

        }
        public static void LoadComboBoxAvailables(ComboBox comboBox, DataBaseDataContext connection)
        {
            comboBox.Items.Clear();

            var query = connection.RaspberryPins.Where(a => a.IsAvailable);

            foreach (var item in query)
            {
                comboBox.Items.Add(item);
            }

            if (!query.Any())
            {
                comboBox.Items.Add(" رله آزاد موجود نیست.");

                comboBox.SelectedIndex = 0;
            }

            comboBox.SelectedIndex = 0;

        }
        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.RaspberryPins.Select(a => new
            {
                id = a.ID,
                pinNumber = a.PinNumber
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "شماره پین";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);


            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void SearchGridByPinNumber(RadGridView gridView, string text, DataBaseDataContext connection)
        {
            var query =
                connection.RaspberryPins.OrderByDescending(a => a.ID)
                    .Where(a => a.PinNumber.Contains(text))
                    .Select(a => new
                    {
                        id = a.ID,
                        pinNumber = a.PinNumber,
                    });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].HeaderText = "شماره پین";

            gridView.Columns[2].Width = (int)Math.Ceiling(0.495 * gridView.Width);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.RaspberryPins.Any(a => a.ID == id);
        }

        public static RaspberryPin Get(int id, DataBaseDataContext connection)
        {
            return connection.RaspberryPins.FirstOrDefault(a => a.ID == id);
        }
    }
}
