using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatRoom_ClientTest
{
    class Program
    {
        public static byte[] data_recieve = new byte[1024];
        public static TcpClient client = new TcpClient("127.0.0.1", 7788);
        static void Main(string[] args)
        {
            NetworkStream stream = client.GetStream();
            Thread thread;
            thread = new Thread(ReceiveMessage);
            thread.Start();
            while (true)
            {
                Console.WriteLine("请输入发给服务器的数据内容：\n");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }

            stream.Close();
            client.Close();
            Console.ReadKey();
        }
        
        private static void ReceiveMessage()
        {
            while (true)
            {
                int msg_Len = client.Client.Receive(data_recieve);
                string msg = Encoding.UTF8.GetString(data_recieve, 0, msg_Len);
                Console.WriteLine(string.Format("[{0}]接受到的消息是：\n {1}", DateTime.Now, msg));
            }
        }
    }
}
