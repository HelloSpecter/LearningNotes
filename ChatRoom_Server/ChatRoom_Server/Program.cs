using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ChatRoom_Server
{
     class Program
    {
        static List<Client> clients = new List<Client>();
        static  Socket clientSocket;
        static void Main(string[] args)
        {
            //新建Socket连接
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //定义IP地址（本地）
            IPAddress IpAdress = IPAddress.Parse("127.0.0.1");
            //定义网络节点
            IPEndPoint IpEndPoint = new IPEndPoint(IpAdress, 7788);
            //Socket与网络节点绑定
            tcpServer.Bind(IpEndPoint);
            //设置监听
            tcpServer.Listen(100);

            Console.WriteLine("TCPServer is running...");

            while (true)
            {
                clientSocket = tcpServer.Accept();
                //Console.WriteLine(string.Format("[{0}][{1}]连接到了客户端...", System.DateTime.Now, clientSocket.LocalEndPoint.AddressFamily));
                Console.WriteLine(string.Format("[{0}][{1}]连接到了客户端...", System.DateTime.Now, clientSocket.LocalEndPoint.AddressFamily));
                Client client_new = new Client(clientSocket);
                Program.clients.Add(client_new);
            }

            
        }


        public static void BroadCastMessage(byte[] data,int len)
        {
            List<Client> notConnectedList = new List<Client>();

            //筛选所有Sockets，处于未连接状态的移除广播列表，已连接状态的发送Meg数据
            foreach (var client in clients)
            {
                if (client.isConnected)
                {
                    client.SendMessage(data,len);
                }
                else
                {
                    notConnectedList.Add(client);
                }
            }
            Console.WriteLine(string.Format("[{0}]已转发消息", System.DateTime.Now));
            foreach (var client_Not in notConnectedList)
            {
                clients.Remove(client_Not);
            }
        }





    }
}
