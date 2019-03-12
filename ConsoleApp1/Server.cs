using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
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
            connection.RegisterStaticPacketHandler<TmpRequest>(Handler);
        }

        private void Handler(TmpRequest packet, Connection connection)
        {
            Console.WriteLine($"Request from client: { packet.Result}");
            Console.WriteLine("Sending response");
            connection.Send(new TmpResponse(packet) { Result = packet.Result});
        }
    }
}
