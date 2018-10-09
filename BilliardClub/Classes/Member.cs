using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BilliardClub
{
    public partial class Member
    {
        public Member(string code, string firstName, string lastName, string nationalCode, DateTime birthDate,
            string type,string sex,byte[] image) : this()
        {
            this.Code = code;

            this.FirstName = firstName;

            this.LastName = lastName;

            this.NationalCode = nationalCode;

            this.BirthDate = birthDate;

            this.Type = type;

            this.Sex = sex;

            this.Image = image;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        public static Member Insert(string code, string firstName, string lastName, string nationalCode,
            DateTime birthDate, string type,string sex,byte[] image,Level level, DataBaseDataContext connection)
        {
            Member member = new Member(code, firstName, lastName, nationalCode,
                birthDate, type,sex,image);

            member.Level = Level.Get(level.ID, connection);

            connection.Members.InsertOnSubmit(member);

            connection.SubmitChanges();

            return member;
        }
        public static void Edit(Member member, string code, string firstName, string lastName, string nationalCode,
            DateTime birthDate, string type,string sex, byte[] image,Level level, DataBaseDataContext connection)
        {
            member.Code = code;

            member.FirstName = firstName;

            member.LastName = lastName;

            member.NationalCode = nationalCode;

            member.BirthDate = birthDate;

            member.Type = type;

            member.Sex = sex;

            member.Image = image;

            member.Level = Level.Get(level.ID, connection);

            connection.SubmitChanges();
        }
        public static void Delete(Member member, DataBaseDataContext connection)
        {
            connection.Members.InsertOnSubmit(member);

            connection.SubmitChanges();
        }
        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<Member> myQuery = connection.Members.Select(a => a);

            cmbBox.Items.Clear();

            foreach (Member item in myQuery)
            {
                cmbBox.Items.Add(item);
            }
            if (!myQuery.Any())
            {
                cmbBox.Items.Add("یک عضو به ثبت برسانید");

                cmbBox.SelectedIndex = 0;

                return;
            }
            cmbBox.SelectedIndex = 0;
        }

        public static void LoadFilteredComboBoxByLevel(ComboBox cmbBox,Level level, DataBaseDataContext connection)
        {
            IQueryable<Member> myQuery = connection.Members.Where(a => a.Level==level);

            cmbBox.Items.Clear();

            foreach (Member item in myQuery)
            {
                cmbBox.Items.Add(item);
            }
            if (!myQuery.Any())
            {
                cmbBox.Items.Add("یک عضو به ثبت برسانید");

                cmbBox.SelectedIndex = 0;

                return;
            }
            cmbBox.SelectedIndex = 0;
        }
        public static void LoadGrid(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Members.Select(a => new
            {
                id = a.ID,
                code=a.Code,
                fullName = a.FirstName + " " + a.LastName,
                nationalCode = a.NationalCode,
                birthDate = BTM.Date.ConvertToPersianDate(a.BirthDate),
                sex=a.Sex,
                level=a.Level.Title
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 200;

            gridView.Columns[2].HeaderText = "کد عضویت";

            gridView.Columns[3].Width = 200;

            gridView.Columns[3].HeaderText = "نام و نام خانوادگی";

            gridView.Columns[4].Width = 100;

            gridView.Columns[4].HeaderText = "شماره ملی";

            gridView.Columns[5].Width = 100;

            gridView.Columns[5].HeaderText = "تاریخ تولد";

            gridView.Columns[6].Width = 100;

            gridView.Columns[6].HeaderText = "جنیست";

            gridView.Columns[7].Width = 100;

            gridView.Columns[7].HeaderText = "نوع عضویت";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByLevel(RadGridView gridView, Level level, DataBaseDataContext connection)
        {
            var query = connection.Members.Where(a=>a.Level==level).
                Select(a => new
            {
                id = a.ID,
                code = a.Code,
                fullName = a.FirstName + " " + a.LastName,
                nationalCode = a.NationalCode,
                birthDate = BTM.Date.ConvertToPersianDate(a.BirthDate),
                sex = a.Sex,
                level = a.Level.Title
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 200;

            gridView.Columns[2].HeaderText = "کد عضویت";

            gridView.Columns[3].Width = 200;

            gridView.Columns[3].HeaderText = "نام و نام خانوادگی";

            gridView.Columns[4].Width = 100;

            gridView.Columns[4].HeaderText = "شماره ملی";

            gridView.Columns[5].Width = 100;

            gridView.Columns[5].HeaderText = "تاریخ تولد";

            gridView.Columns[6].Width = 100;

            gridView.Columns[6].HeaderText = "جنیست";

            gridView.Columns[7].Width = 100;

            gridView.Columns[7].HeaderText = "نوع عضویت";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }

        }
        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.Members.Any(a => a.ID == id);
        }
        public static Member Get(int id, DataBaseDataContext connection)
        {
            return connection.Members.FirstOrDefault(a => a.ID == id);
        }
    }
}
