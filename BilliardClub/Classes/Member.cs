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
            string type, string sex, byte[] image) : this()
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
            DateTime birthDate, string type, string sex, byte[] image,bool hasCabinet, Level level, DataBaseDataContext connection)
        {
            Member member = new Member(code, firstName, lastName, nationalCode,
                birthDate, type, sex, image);

            member.Level = Level.Get(level.ID, connection);

            connection.Members.InsertOnSubmit(member);

            connection.SubmitChanges();

            return member;
        }

        public static void Edit(Member member, string code, string firstName, string lastName, string nationalCode,
            DateTime birthDate, string type, string sex, byte[] image, Level level, DataBaseDataContext connection)
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
            connection.Members.DeleteOnSubmit(member);

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

        public static void LoadComboBoxByLevel(ComboBox cmbBox, Level level, DataBaseDataContext connection)
        {
            IQueryable<Member> myQuery = connection.Members.Where(a => a.Level == level);

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

            gridView.Columns[4].HeaderText = "کد ملی";

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

        public static void SearchGridByMemberCode_LoadGridBriefly(string text, RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Members.OrderByDescending(a => a.ID).Where(a => a.Code.Contains(text)).Select(
                a => new
                {
                    id = a.ID,
                    code = a.Code,
                    fullName = a.FirstName + " " + a.LastName,
                    nationalCode = a.NationalCode
                });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = (int)Math.Ceiling(0.2 * gridView.Width);

            gridView.Columns[2].HeaderText = "کد عضویت";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.5 * gridView.Width);

            gridView.Columns[3].HeaderText = "نام و نام خانوادگی";

            gridView.Columns[4].Width = (int)Math.Ceiling(0.2 * gridView.Width); ;

            gridView.Columns[4].HeaderText = "کد ملی";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void SearchGridByMemberFullName_LoadGridBriefly(string text, RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Members.OrderByDescending(a => a.ID).Where(a => a.FirstName.Contains(text) || a.LastName.Contains(text)).Select(
                a => new
                {
                    id = a.ID,
                    code = a.Code,
                    fullName = a.FirstName + " " + a.LastName,
                    nationalCode = a.NationalCode
                });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = (int)Math.Ceiling(0.2 * gridView.Width);

            gridView.Columns[2].HeaderText = "کد عضویت";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.5 * gridView.Width);

            gridView.Columns[3].HeaderText = "نام و نام خانوادگی";

            gridView.Columns[4].Width = (int)Math.Ceiling(0.2 * gridView.Width); ;

            gridView.Columns[4].HeaderText = "کد ملی";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void SearchGridByMemberNationalCode_LoadGridBriefly(string text, RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Members.OrderByDescending(a => a.ID).Where(a => a.NationalCode.Contains(text)).Select(
                a => new
                {
                    id = a.ID,
                    code = a.Code,
                    fullName = a.FirstName + " " + a.LastName,
                    nationalCode = a.NationalCode
                });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = (int)Math.Ceiling(0.2 * gridView.Width);

            gridView.Columns[2].HeaderText = "کد عضویت";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.5 * gridView.Width);

            gridView.Columns[3].HeaderText = "نام و نام خانوادگی";

            gridView.Columns[4].Width = (int)Math.Ceiling(0.2 * gridView.Width); ;

            gridView.Columns[4].HeaderText = "کد ملی";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public static void LoadGridBriefly(RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Members.Select(a => new
            {
                id = a.ID,
                code = a.Code,
                fullName = a.FirstName + " " + a.LastName,
                nationalCode = a.NationalCode
            });

            gridView.DataSource = query;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = (int)Math.Ceiling(0.2 * gridView.Width);

            gridView.Columns[2].HeaderText = "کد عضویت";

            gridView.Columns[3].Width = (int)Math.Ceiling(0.5 * gridView.Width);

            gridView.Columns[3].HeaderText = "نام و نام خانوادگی";

            gridView.Columns[4].Width = (int)Math.Ceiling(0.215 * gridView.Width); ;

            gridView.Columns[4].HeaderText = "کد ملی";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void SearchGridByMemberCode(string text, RadGridView gridView, DataBaseDataContext connection)
        {
            var query = connection.Members.OrderByDescending(a => a.ID).Where(a => a.Code.Contains(text)).Select(
                a => new
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

            gridView.Columns[4].HeaderText = "کد ملی";

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

        public static void LoadGridByLevel(RadGridView gridView, Level level, DataBaseDataContext connection)
        {
            var query = connection.Members.Where(a => a.Level == level).
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

            gridView.Columns[4].HeaderText = "کد ملی";

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

        public static void LoadGridJoinSocialNetworkAccountJoinPhoneNumber(RadGridView gridView, DataBaseDataContext connection)
        {
            var joinQuery = connection.Members.Join(
                connection.SocialNetworkAccounts.Where(a => a.Status == true),
                member => member.ID,
                social_network_account => social_network_account.MemberID, (mem, account) => new
                {
                    mem,
                    account
                }).Join(connection.PhoneNumbers.Where(a => a.Status == true),
                memsocial => memsocial.mem.ID, phone => phone.MemberID,
                (memsocial, phone) => new
                {
                    id = memsocial.mem.ID,
                    code = memsocial.mem.Code,
                    fullName = memsocial.mem.FirstName + " " + memsocial.mem.LastName,
                    nationalCode = memsocial.mem.NationalCode,
                    birthDate = BTM.Date.ConvertToPersianDate(memsocial.mem.BirthDate),
                    sex = memsocial.mem.Sex,
                    level = memsocial.mem.Level.Title,
                    socialNetAccount = memsocial.account.Account,
                    phoneNum = phone.Number
                });

            //var query = connection.Members.Where(a => a.Level == level).
            //    Select(a => new
            //    {
            //        id = a.ID,
            //        code = a.Code,
            //        fullName = a.FirstName + " " + a.LastName,
            //        nationalCode = a.NationalCode,
            //        birthDate = BTM.Date.ConvertToPersianDate(a.BirthDate),
            //        sex = a.Sex,
            //        level = a.Level.Title
            //    });

            gridView.DataSource = joinQuery;

            gridView.Columns[1].IsVisible = false;

            gridView.Columns[2].Width = 70;

            gridView.Columns[2].HeaderText = "کد عضویت";

            gridView.Columns[3].Width = 150;

            gridView.Columns[3].HeaderText = "نام و نام خانوادگی";

            gridView.Columns[4].Width = 100;

            gridView.Columns[4].HeaderText = "کد ملی";

            gridView.Columns[5].Width = 100;

            gridView.Columns[5].HeaderText = "تاریخ تولد";

            gridView.Columns[6].Width = 110;

            gridView.Columns[6].HeaderText = "جنیست";

            gridView.Columns[7].Width = 90;

            gridView.Columns[7].HeaderText = "نوع عضویت";

            gridView.Columns[8].Width = 150;

            gridView.Columns[8].HeaderText = "اکانت شبکه اجتماعی";

            gridView.Columns[9].Width = 110;

            gridView.Columns[9].HeaderText = "شماره تماس";

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
