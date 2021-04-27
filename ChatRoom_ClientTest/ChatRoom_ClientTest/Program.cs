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
            }

            stream.Close();
            client.Close();
            Console.ReadKey();
        }
    }
}
