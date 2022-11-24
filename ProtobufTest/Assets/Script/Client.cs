using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
//public interface IReceiveMessage
//{
//     void ReceivedMessage(byte[] data, int len);
//}
public class Client
{
    //#region Singleton
    //private static readonly Client s_Instance = new Client();
    //public static Client instance { get { return s_Instance; } }
    //#endregion
    
    public  byte[] data_recieve = new byte[1024];
    public  TcpClient client = null;
    public  protobuflocaldemo main;
    public  int s_Len;
    //public IReceiveMessage Imsg;
    //public UnityAction<byte[],int> receriveMsg;
    public void Connect()
    {
        client = new TcpClient("127.0.0.1", 7788);
        Thread thread;
        thread = new Thread(ReceiveMessage);
        thread.Start();
        if (client.Connected)
        {
            Debug.Log(string.Format("[{0}]已连接服务端", System.DateTime.Now));
        }
    }
    public void SendMessage(byte[] data)
    {
        //if (client.Connected == false)
        //{
        //    client.Close();
        //    client = new TcpClient("127.0.0.1", 7788);
        //}
        NetworkStream stream = client.GetStream();
        stream.Write(data, 0, data.Length);
        //stream.Close();
        Debug.Log(string.Format("[{0}]信息已发送",System.DateTime.Now));
    }
    
    public void ReceiveMessage()
    {
        while (true)
        {
            int msg_Len = client.Client.Receive(data_recieve);
            if (msg_Len > 0)
            {
                //因为socket在子线程，所以不能调用unity主线程函数（接口、事件都不行）...
                //后续再尝试可能可以的方案：1.主线程socket异步通信；2.主线程轮询socket，收到的包放进主线程消息队列
                //这里用最粗暴的方法，直接改个标记参数~
                this.s_Len = msg_Len;
                main.needUpdate = true;
                //Imsg.ReceivedMessage(data_recieve, msg_Len);
                //receriveMsg(data_recieve, msg_Len);
            }
        }
    }
}
