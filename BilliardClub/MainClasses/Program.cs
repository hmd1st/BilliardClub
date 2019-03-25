using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClub.Forms;

namespace BilliardClub
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseDataContext myConnection = Setting.DataBase;
            if (!myConnection.DatabaseExists())
            {
                myConnection.CreateDatabase();

                #region Insert RaspberryPins

                for (int i = 1; i <= 24; i++)
                {
                    RaspberryPin.Insert(i.ToString(), true, myConnection);
                }

                #endregion

                #region Insert SocialNetworkTypes

                SocialNetworkType.Insert("اینستاگرام", myConnection);
                SocialNetworkType.Insert("تلگرام", myConnection);
                SocialNetworkType.Insert("وایبر", myConnection);
                SocialNetworkType.Insert("وی چت", myConnection);
                SocialNetworkType.Insert("توییتر", myConnection);
                SocialNetworkType.Insert("لینکداین", myConnection);
                SocialNetworkType.Insert("فیسبوک", myConnection);

                #endregion

                #region Insert PhoneOperators

                Phone.Insert("ایرانسل", myConnection);
                Phone.Insert("همراه اول", myConnection);
                Phone.Insert("رایتل", myConnection);
                Phone.Insert("تالیا", myConnection);
                Phone.Insert("تلفن ثابت", myConnection);

                #endregion

                #region Insert Level

                Level.Insert("طلایی", myConnection);
                Level.Insert("نقره ای", myConnection);
                Level.Insert("برنزی", myConnection);
                Level.Insert("VIP", myConnection);

                #endregion


            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
