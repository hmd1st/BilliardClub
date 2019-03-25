using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClub
{
    public partial class Configuration
    {
        public Configuration(string raspberryIpAddress,string raspberryPortNumber):this()
        {
            this.RaspberryIPAddress = raspberryIpAddress;

            this.RaspberryPortNumber = raspberryPortNumber;
        }

        public static Configuration Insert(string raspberryIpAddress, string raspberryPortNumber,
            DataBaseDataContext connection)
        {
            Configuration configuration = new Configuration(raspberryIpAddress,raspberryPortNumber);

            connection.Configurations.InsertOnSubmit(configuration);

            connection.SubmitChanges();

            return configuration;
        }

        public static void Edit(Configuration configuration, string raspberryIpAddress, string raspberryPortNumber,
            DataBaseDataContext connection)
        {
            configuration.RaspberryIPAddress = raspberryIpAddress;

            configuration.RaspberryPortNumber = raspberryPortNumber;

            connection.SubmitChanges();
        }

        public static void Delete(Configuration configuration, DataBaseDataContext connection)
        {
            connection.Configurations.DeleteOnSubmit(configuration);

            connection.SubmitChanges();
        }

    }
}
