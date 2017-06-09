using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementSystemClient
{
    public class NetConnection
    {
        private string hostIp;
        private int port;
        private TcpClient client;
        private NetworkStream stream;

        public delegate void MsgRecieved(string data);
        public event MsgRecieved MsgRecievedEvent;
        public event Action Disconneted;
        const int PORT = 42;

        public NetConnection(string hostIp)
        {
            this.hostIp = hostIp;
            this.port = PORT;

            client = new TcpClient();
            try
            {
                client.Connect(hostIp, port);
                stream = client.GetStream();

                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();
            }
            catch (SocketException e)
            {
                throw new ArgumentException("Не удалось подключиться к серверу", e);
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
                catch (SocketException e)
                {
                    MessageBox.Show("Ошибка соединения");
                    Disconnect();
                    break;
                }    
                catch (IOException e)
                {
                    MessageBox.Show("Ошибка соединения.");
                    Disconnect();
                    break;
                }
            }
        }


        public void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
            Disconneted();
        }
    }
}
