using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Network;

namespace WpfApp1
{
    public class Client
    {
        private readonly TcpConnection connectionContainer;

        public Client()
        {
            Thread.Sleep(1500);//wait for server
            ConnectionResult result = ConnectionResult.TCPConnectionNotAlive;
            connectionContainer = ConnectionFactory.CreateSecureTcpConnection("127.0.0.1", 5666, out result);
            if (result == ConnectionResult.Connected)
            {
            }
        }
    }
}
