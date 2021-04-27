using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 打开转盘锁
{
    //不转数字，直接字符串与字符
    //用集合代替队列
    //deadkey直接初始化到visited里
    //2个bfs使用轮换方法，轮流与对边比较、自我扩散（每次都只于最外侧比较）
    class BFS_improve
    {
        public int OpenLock(string[] deadends, string target)
        {
            //状态数组，1、2、3、4正转，-1，-2，-3，-4逆转
            int step = 0;
            int[] locked = new int[deadends.Length];
            for (int i = 0; i < deadends.Length; i++)
            {
                locked[i] = int.Parse(deadends[i]);
            }
            int m_target = int.Parse(target);

            if (m_target==0)
            {
                return 0;
            }
            int[] step1 = new int[] { 1, 10, 100, 1000, 9, 90, 900, 9000 };
            if (step1.Contains(m_target))
            {
                return 1;
            }
            //头部bfs
            Queue<int> head_q = new Queue<int>();//存放当前的number
            Queue<int> head_visited = new Queue<int>();//存放访问过的number
            Queue<int> head_s = new Queue<int>();//存放待调整的状态参数
            //尾部bfs
            Queue<int> tail_q = new Queue<int>();//存放当前的number
            Queue<int> tail_visited = new Queue<int>();//存放访问过的number
            Queue<int> tail_s = new Queue<int>();//存放待调整的状态参数


            head_q.Enqueue(0);
            head_s.Enqueue(0);

            tail_q.Enqueue(m_target);
            tail_s.Enqueue(0);

            int h_step = -1;
            int t_step = -1;

            while (head_s.Count > 0&&tail_s.Count>0)
            {
                h_step++;
                int h_sz = head_s.Count;
                for (int j = 0; j < h_sz; j++)
                {

                
                int head = advance(head_q.Dequeue(), head_s.Dequeue());
                if (tail_visited.Contains(head))
                {
                    step = h_step + t_step;
                    return step;
                }
                if ((!locked.Contains(head))&&(!head_visited.Contains(head)))
                {
                    //将该节点的子节点放入队列
                    head_visited.Enqueue(head);
                    for (int i = 1; i < 5; i++)
                    {
                    head_q.Enqueue(head);
                    head_s.Enqueue(i);

                    head_q.Enqueue(head);
                    head_s.Enqueue(-i);
                    }
                }
                }

                t_step++;
                int t_sz = tail_s.Count;
                for (int j = 0; j < t_sz; j++)
                {

                
                int tail = advance(tail_q.Dequeue(), tail_s.Dequeue());
                if (head_visited.Contains(tail))
                {
                    step = h_step + t_step;
                    return step;
                }

                if ((!locked.Contains(tail)) && (!tail_visited.Contains(tail)))
                {
                    //将该节点的子节点放入队列
                    tail_visited.Enqueue(tail);
                    for (int i = 1; i < 5; i++)
                    {
                        tail_q.Enqueue(tail);
                        tail_s.Enqueue(i);

                        tail_q.Enqueue(tail);
                        tail_s.Enqueue(-i);
                    }
                }
                }
                
            }
            return -1;


            //以下为调用的本地方法

            int advance(int a,int b)//进行单次旋转操作
            {
                int c = a;
                int mul =(int)(Math.Pow(10, 4 - Math.Abs(b)));
                a = a % (10 * mul);
                if (b>0)
                {
                    if (a/mul==9)
                    {
                        c -= 9*mul;
                    }
                    else
                    {
                        c += mul;
                    }
                }
                if (b<0)
                {
                    if (a/mul==0)
                    {
                        c += 9 * mul;
                    }
                    else
                    {
                        c -= mul;
                    }
                }
                return c;
            }
        }
    }
}
