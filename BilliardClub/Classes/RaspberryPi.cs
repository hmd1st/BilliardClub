using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BilliardClub.Classes
{
    class RaspberryPi
    {
        public RaspberryPi()
        {
            
        }

        public static void SendMessage(string message, IPAddress ipAddress, int portNumber)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
                ProtocolType.Udp);

            //IPAddress serverAddr = IPAddress.Parse("127.0.0.1");

            IPEndPoint endPoint = new IPEndPoint(ipAddress, portNumber);

            byte[] send_buffer = Encoding.ASCII.GetBytes(message);

            sock.SendTo(send_buffer, endPoint);
        }


    }
}
