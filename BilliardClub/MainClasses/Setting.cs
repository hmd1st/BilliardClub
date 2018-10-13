using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClub
{
  public static  class Setting
  {
      //private static DataBaseDataContext _dataBase;

      public static DataBaseDataContext DataBase
      {
          get{ return new DataBaseDataContext(@"data source=.; initial catalog=BilliardClub; integrated security=true"); }
          //get { return _dataBase; }
          
      }
  }
}
