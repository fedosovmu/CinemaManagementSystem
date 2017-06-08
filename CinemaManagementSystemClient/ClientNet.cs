using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaManagementSystemClient
{
    public class ClientNet
    {
        private string hostIp;
        private int port;
        private TcpClient client;
        private NetworkStream stream;

        public delegate void MsgRecieved(string data);
        public event MsgRecieved MsgRecievedEvent;
        public event Action Connected;
        public event Action ConnectionError;

        public ClientNet(string hostIp, int port)
        {
            this.hostIp = hostIp;
            this.port = port;

            client = new TcpClient();
            try
            {
                client.Connect(hostIp, port);
                stream = client.GetStream();

                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();

                this.Connected();
            }
            catch
            {
                this.ConnectionError();
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }


        public void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    MsgRecievedEvent(message);
                }
                catch
                {
                    this.ConnectionError();
                }
            }
        }


        public void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
