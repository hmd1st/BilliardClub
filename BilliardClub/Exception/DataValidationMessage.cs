using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardClub
{
    public static class DataValidationMesaage
    {
        private static bool IsPersianCharacters(string input)
        {
            return new Regex("[\u0600-\u06ff]|[\u0750-\u077f]|[\ufb50-\ufc3f]|[\ufe70-\ufefc]|[0-9]+").IsMatch(input);
        }

        public static void AcceptMessage()
        {
            MessageBox.Show("اطلاعات شما با موفقیت در بانک اطلاعاتی ذخیره گردید.", "کاربر گرامی", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        public static void EditMessage()
        {
            MessageBox.Show("اطلاعات شما با موفقیت ویرایش گردید. ", "کاربر گرامی", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        public static void DeleteMessage()
        {
            MessageBox.Show("اطلاعات شما با موفقیت حذف گردید. ", "کاربر گرامی", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }
        public static void AcceptMessage(string text)
        {
            MessageBox.Show(
                IsPersianCharacters(text)
                    ? string.Format(" مقدار {0} با موفقیت در بانک اطلاعاتی ذخیره گردید", text)
                    : string.Format(" با موفقیت در بانک اطلاعاتی ذخیره گردید {0} مقدار", text), "کاربر گرامی",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public static void NoSelectedItemFromList(string listName)
        {
            MessageBox.Show(
                IsPersianCharacters(listName)
                    ? string.Format("کاربر گرامی هیچ مقداری از {0} انتخاب نشده است", listName)
                    : string.Format("انتخاب نشده است {0} کاربر گرامی هیچ مقداری از ", listName),
                "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void NoDataInBank()
        {
            MessageBox.Show(" کاربر گرامی  مقدار انتخاب شده در بانک اطلاعاتی موجود نمی باشد ", "اخطار", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void BlankTextBox(string text)
        {
            MessageBox.Show(
                IsPersianCharacters(text)
                    ? string.Format("کاربر گرامی لطفا مقدار {0} را کامل کنید", text)
                    : string.Format("را کامل کنید {0} کاربر گرامی لطفا مقدار ", text),
                "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DuplicateData(string text)
        {
            MessageBox.Show(
                IsPersianCharacters(text)
                    ? string.Format("کاربر گرامی  مقدار {0} قبلا در بانک اطلاعاتی ذخیره گردیده است", text)
                    : string.Format("قبلا در بانک اطلاعاتی ذخیره گردیده است {0} کاربر گرامی  مقدار ", text),
                "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DataInUse(string title, string listName)
        {
            if (IsPersianCharacters(title) && !IsPersianCharacters(listName))
            {
                MessageBox.Show(string.Format("در حال استفاده می باشد {1} کاربر گرامی مقدار {0} از", title, listName),
                    "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsPersianCharacters(title) && IsPersianCharacters(listName))
            {
                MessageBox.Show(string.Format("از {1} در حال استفاده می باشد {0} کاربر گرامی مقدار", title, listName),
                    "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IsPersianCharacters(title) && IsPersianCharacters(listName))
            {
                MessageBox.Show(string.Format("کاربر گرامی مقدار {0} از {1} در حال استفاده می باشد", title, listName),
                    "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(string.Format("از {1} در حال استفاده می باشد {0} کاربر گرامی مقدار", title, listName),
                    "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static DialogResult ConfirmDeleteData(string text)
        {
            return MessageBox.Show(
                IsPersianCharacters(text)
                    ? string.Format(" آیا از حذف مقدار {0}  از بانک اطلاعاتی اطمینان دارید؟", text)
                    : string.Format("از بانک اطلاعاتی اطمینان دارید؟ {0} آیا از حذف مقدار ", text),
                "کاربر گرامی", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
