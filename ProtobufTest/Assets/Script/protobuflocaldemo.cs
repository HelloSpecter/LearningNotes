using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Protobuf;
using Protobuf;
using UnityEngine.UI;
using UnityEngine.Events;

public class protobuflocaldemo : MonoBehaviour/* , IReceiveMessage*/
{
    public InputField[] inputArry;
    public Text[] receive_info;
    public Button btn_send;
    public Button btn_connect;
    public Person cur_data = null;
    public bool needUpdate = false;
    public Person receive_data = null;
    public Client client;
    // Start is called before the first frame update
    void Start()
    {
        btn_send.onClick.AddListener(OnButtonSendMessage);
        btn_connect.onClick.AddListener(OnButtonConnect);
    }

    // Update is called once per frame
    void Update()
    {
        if (needUpdate)
        {
            DeserializeData(client.data_recieve, client.s_Len);
        }
    }

    public void UpdateInfo(Person personData)
    {
        Debug.Log(string.Format("[{0}]解析完毕，更新UI...", System.DateTime.Now));
        receive_info[0].text = personData.Name;
        receive_info[1].text = personData.Age.ToString();
        receive_info[2].text = personData.NameList[0];
        receive_info[3].text = personData.NameList[1];
        receive_info[4].text = personData.NameList[2];
        Debug.Log(string.Format("[{0}]更新UI完毕!", System.DateTime.Now));
    }

    public void DeserializeData(byte[] data,int length)
    {
        needUpdate = false;
        Debug.Log(string.Format("[{0}]接收到消息，正在解析...", System.DateTime.Now));
        IMessage IMperson = new Person();
        receive_data = (Person)IMperson.Descriptor.Parser.ParseFrom(data,0,length);
        UpdateInfo(receive_data);
    }

    public void OnButtonSendMessage()
    {
        if (cur_data == null)
        {
            cur_data = new Person();
        }
        bool enable = true;
        for (int i = 0; i < 5; ++i)
        {
            if (string.IsNullOrEmpty(inputArry[i].text))
            {
                enable = false;
                break;
            }
        }
        if (enable)
        {
            cur_data.Name = inputArry[0].text;
            cur_data.Age = int.Parse(inputArry[1].text);
            cur_data.NameList.Clear();
            cur_data.NameList.Add(inputArry[2].text);
            cur_data.NameList.Add(inputArry[3].text);
            cur_data.NameList.Add(inputArry[4].text);
            //Debug.Log(string.Format("{0},{1},{2},{3},{4}", cur_data.Name, cur_data.Age, cur_data.NameList[0], cur_data.NameList[1], cur_data.NameList[2]));
        }
        else
        {
            Debug.LogError("InputData valid!");
        }
        client.SendMessage(cur_data.ToByteArray());
    }

    public void OnButtonConnect()
    {
        client = new Client();
        client.main = this;
        //client.Imsg = this;
        client.Connect();
        //client.receriveMsg += ReceivedMessage;
    }

    public void ReceivedMessage(byte[] data, int len)
    {
        DeserializeData(data, len);
    }
}
