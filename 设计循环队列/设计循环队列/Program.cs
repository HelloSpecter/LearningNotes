using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计循环队列
{
    public class MyCircularQueue
    {
        int[] m_Queue;
        int front = -1, rear = -1;
        int len;

        public MyCircularQueue(int k)
        {
            m_Queue = new int[k];
            len = k;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            else if (IsEmpty())
            {
                front++;
            }
            rear = ++rear < len ? rear : rear - len;
            m_Queue[rear] = value;
            return true;
            
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            if (front==rear)
            {
                front = -1;
                rear = -1;
                return true;
            }
            front = ++front < len ? front : front - len;
            //if (front>rear)
            //{
            //    front = -1;
            //    rear = -1;
            //}
            return true;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return m_Queue[front];
        }

        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return m_Queue[rear];
        }

        public bool IsEmpty()
        {
            if (rear==-1&&front==-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if ((rear+1)%len==front)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
