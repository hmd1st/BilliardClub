using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClub
{
  public static  class Setting
    {
        public static DataBaseDataContext DataBase
        {
            get { return new DataBaseDataContext(@"data source=DESKTOP-DMH276P; initial catalog=BilliardClubDB; integrated security=true"); }
        }
    }
}
