using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
namespace ChatRoom_Server
{
    class Client
    {
        Socket client_Socket;
        byte[] data = new byte[1024];
        public bool isConnected = false;
        private Thread thread;

        public  Client(Socket s)
        {
            this.client_Socket = s;
            this.isConnected = true;
            thread = new Thread(ReceiveMessage);
            thread.Start();
            
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                if (this.client_Socket.Poll(10,SelectMode.SelectRead))
                {
                    this.client_Socket.Close();
                    this.isConnected = false;
                    break;
                }

                int msg_Len = this.client_Socket.Receive(data);
                string msg = Encoding.UTF8.GetString(data, 0, msg_Len);
                Console.WriteLine("接受到的消息是：\n"+msg);

                Program.BroadCastMessage(msg);
            }
        }

        public  void SendMessage(string sendMsg)
        {
            byte[] sendData = Encoding.UTF8.GetBytes(sendMsg);
            this.client_Socket.Send(sendData);
        }
    }
}
