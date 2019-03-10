using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using Network.Enums;

namespace ConsoleApp1
{
    class Server
    {
        private readonly ServerConnectionContainer _connectionContainer;

        public Server()
        {
            _connectionContainer = ConnectionFactory.CreateSecureServerConnectionContainer("127.0.0.1", 5666, 2048, false);
            _connectionContainer.ConnectionEstablished += ConnectionEstablished;
        }

        public void Start()
        {
            _connectionContainer.Start();
        }

        private void ConnectionEstablished(Connection connection, ConnectionType connectionType)
        {
            Console.WriteLine(
                $"{_connectionContainer.Count} {connection.GetType()} connected on port {connection.IPRemoteEndPoint.Port}");
        }
    }
}
