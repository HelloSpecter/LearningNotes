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
                //string msg = Encoding.UTF8.GetString(data, 0, msg_Len);
                Console.WriteLine(string.Format("[{0}]接受到了消息，正在转发...",System.DateTime.Now));
                Program.BroadCastMessage(data,msg_Len);
            }
        }

        public  void SendMessage(byte[] data,int len)
        {
            this.client_Socket.Send(data,0,len,SocketFlags.None);
        }
    }
}
