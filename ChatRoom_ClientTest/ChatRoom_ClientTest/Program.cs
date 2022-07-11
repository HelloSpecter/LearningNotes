using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ChatRoom_ClientTest
{
    class Program
    {
        public static byte[] data_recieve = new byte[1024];
        static void Main(string[] args)
        {
            
            TcpClient client = new TcpClient("127.0.0.1", 7788);
            NetworkStream stream = client.GetStream();

            while (true)
            {
                Console.WriteLine("请输入发给服务器的数据内容：\n");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                ReceiveMessage(client.Client);
            }

            stream.Close();
            client.Close();
            Console.ReadKey();
        }
        
        private static void ReceiveMessage(Socket client)
        {
            int msg_Len = client.Receive(data_recieve);
            if (msg_Len > 0)
            {
                string msg = Encoding.UTF8.GetString(data_recieve, 0, msg_Len);
                Console.WriteLine("Client接受到的消息是：\n" + msg);
            }
        }
    }
}
