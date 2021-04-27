using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 打开转盘锁
{
    public class Solution
    {
        //2020.12.17_这种方法逻辑上是BFS广度优先算法的应用，可执行但时间上超时不能过LeetCode，考虑是string数组、char[]之间的频繁转换造成了时间复杂度过大
        public int OpenLock(string[] deadends, string target)
        {
            char[] list = new char[] { '0', '0', '0', '0', '0' };
            //状态数组，1、2、3、4正转，-1，-2，-3，-4逆转
            int step = 0;
            if (deadends.Contains("0000"))
            {
                return -1;
            }

            Queue<string> q = new Queue<string>();//存放5个number，密码和1个状态位
            Queue<string> visited = new Queue<string>();//存放4个number，即密码
            q.Enqueue(target+0.ToString());
            while (q.Count > 0)
            {
                int sz = q.Count;
                for (int i = 0; i < sz; i++)
                {
                    string cur;//当前密码
                    //char[] list_temp = list.Clone() as char[];
                    cur = advance(q.Dequeue()).Remove(4, 1);
                    if (cur == "0000")
                    {
                        return step;
                    }
                    if (deadends.Contains(cur) || visited.Contains(cur))
                    {
                        continue;
                    }
                    visited.Enqueue(cur);
                    for (int j = 1; j < 9; j++)
                    {
                        q.Enqueue(cur+j.ToString());
                    }



                }
                step++;
            }
            return -1;


            //以下为调用的本地方法

            string advance(string list_temp)//进行单次旋转操作
            {
                char[] temp = list_temp.ToCharArray();
                switch (temp[4])
                {
                    case '1': temp[0] = right(temp[0]); break;
                    case '2': temp[1] = right(temp[1]); break;
                    case '3': temp[2] = right(temp[2]); break;
                    case '4': temp[3] = right(temp[3]); break;
                    case '5': temp[0] = left(temp[0]); break;
                    case '6': temp[1] = left(temp[1]); break;
                    case '7': temp[2] = left(temp[2]); break;
                    case '8': temp[3] = left(temp[3]); break;
                    default:
                        break;
                }
                return getString(temp);

            }
            char left(char c)
            {
                if (c == '0')
                {
                    return (char)(c + 9);
                }
                return (char)(c - 1);
            }
            char right(char c)
            {
                if (c == '9')
                {
                    return (char)(c - 9);
                }
                return (char)(c + 1);
            }
            //bool isLock(string ifLock)
            //{
            //    foreach (string item in deadends)
            //    {
            //        if (ifLock == item)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}
            //bool isSolve(string ifSolve)
            //{
            //    if (ifSolve == target)
            //    {
            //        return true;
            //    }
            //    return false;
            //}
            string getString(char[] temp)
            {
                return (temp[0].ToString() + temp[1].ToString() + temp[2].ToString() + temp[3].ToString() + temp[4].ToString());
            }
            //return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //char[] list = new char[] { '0', '0', '0', '0' };
            ////list[0] = (char)(list[0]-1);
            ////Console.WriteLine((int)'9');
            //int num = list[0] - 48;
            //Console.WriteLine(num);
            //Console.WriteLine((char)(2+48));
            //string code = list[0].ToString() + list[1].ToString() + list[2].ToString() + list[3].ToString();
            //Console.WriteLine(code);
            //int[] num = new int[4];
            //num[0] = 2;
            //int[] temp = num.Clone() as int[];
            //num[0] = 5;
            //num[1] = 3;

            //foreach (var s in num)
            //{
            //    Console.Write(s+" ");
            //}
            //Console.WriteLine("\n");
            //foreach (var t in temp)
            //{
            //    Console.Write(t + " ");
            //}
            //string s = "012345";
            //string c = s;
            //s = s.Remove(5, 1);
            //c += 9.ToString();
            //Console.WriteLine(s+"  "+c);
            Solution solution = new Solution();
            BFS_improve bfs = new BFS_improve();

            //string[] end = new string[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" };
            //string tar = "8888";

            //string[] end = new string[] { "0201", "0101", "0102", "1212", "2002" };
            //string tar = "0202";

            string[] end = new string[] { "8888" };
            string tar = "0009";

            Console.WriteLine(bfs.OpenLock(end,tar));
            Console.ReadLine();
        }
    }
}
