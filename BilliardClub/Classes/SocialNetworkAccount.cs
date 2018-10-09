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
    public partial class SocialNetworkAccount
    {
        public SocialNetworkAccount(bool status, string account) : this()
        {
            this.Status = status;

            this.Account = account;


        }

        //public override string ToString()
        //{
        //    return this.Status;
        //}

        public static SocialNetworkAccount Insert(SocialNetworkType socialNetworkType, Member member,
            bool status, string account, DataBaseDataContext connection)
        {
            SocialNetworkAccount socialNetworkAccount = new SocialNetworkAccount(status, account);

            socialNetworkAccount.SocialNetworkType = socialNetworkType;

            socialNetworkAccount.Member = member;

            connection.SocialNetworkAccounts.InsertOnSubmit(socialNetworkAccount);

            connection.SubmitChanges();

            return socialNetworkAccount;
        }

        public static void Edit(SocialNetworkAccount socialNetworkAccount, SocialNetworkType socialNetworkType, Member member,
            bool status, string account, DataBaseDataContext connection)
        {
            socialNetworkAccount.Status = status;

            socialNetworkAccount.Account = account;

            socialNetworkAccount.SocialNetworkType = socialNetworkType;

            socialNetworkAccount.Member = member;

            connection.SubmitChanges();
        }

        public static void Delete(SocialNetworkAccount socialNetworkAccount, DataBaseDataContext connection)
        {
            connection.SocialNetworkAccounts.DeleteOnSubmit(socialNetworkAccount);

            connection.SubmitChanges();
        }

        public static void LoadComboBox(ComboBox cmbBox, DataBaseDataContext connection)
        {
            IQueryable<SocialNetworkAccount> myQuery = connection.SocialNetworkAccounts.Select(a => a);

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

        public static void LoadFilteredComboBoxBySocialNetworkType(ComboBox cmbBox, SocialNetworkType socialNetworkType,
            DataBaseDataContext connection)
        {
            IQueryable<SocialNetworkAccount> myQuery = connection.SocialNetworkAccounts.
                Where(a => a.SocialNetworkType == socialNetworkType);

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

        public static void LoadFilteredComboBoxByMember(ComboBox cmbBox, Member member,
            DataBaseDataContext connection)
        {
            IQueryable<SocialNetworkAccount> myQuery = connection.SocialNetworkAccounts.
                Where(a => a.Member == member);

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
            var myQuery = connection.SocialNetworkAccounts.Select(a => new
            {
                id = a.ID,
                status = a.Status,
                account = a.Account
            });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "نام کاربری";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridBySocialNetworkType(RadGridView grid, SocialNetworkType socialNetworkType,
            DataBaseDataContext connection)
        {
            var myQuery = connection.SocialNetworkAccounts.Where(a => a.SocialNetworkType == socialNetworkType)
                .Select(a => new
                {
                    id = a.ID,
                    status = a.Status,
                    account = a.Account

                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "نام کاربری";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static void LoadFilteredGridByMember(RadGridView grid, Member member,
            DataBaseDataContext connection)
        {
            var myQuery = connection.SocialNetworkAccounts.Where(a => a.Member == member)
                .Select(a => new
                {
                    id = a.ID,
                    status = a.Status,
                    account = a.Account
                });

            grid.DataSource = myQuery;

            grid.Columns[1].IsVisible = false;

            grid.Columns[2].HeaderText = "وضعیت";

            grid.Columns[2].Width = 300;

            grid.Columns[3].HeaderText = "نام کاربری";

            grid.Columns[3].Width = 100;

            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public static bool Validation(int id, DataBaseDataContext connection)
        {
            return connection.SocialNetworkAccounts.Any(a => a.ID == id);
        }

        public static SocialNetworkAccount Get(int id, DataBaseDataContext connection)
        {
            return connection.SocialNetworkAccounts.FirstOrDefault(a => a.ID == id);
        }
    }
}
