using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯套娃信封问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solve:
            //w优先，h其次，对原(w,h)进行排序
            //取w与h分为2个数组，并分别求每个数组、每个Index的最长子序dq_w(i)、dq_h(i)
            //dq_w(i)与dq_h(i)值不相等的，去除（赋值0）
            //找出dq_w(i)或dq_h(i)的最大值即可
            //[[4,5],[4,6],[6,7],[2,3],[1,1]]
            //[[2,100],[3,200],[4,300],[5,500],[5,400],[5,250],[6,370],[6,360],[7,380]]
            //[[1,15],[7,18],[7,6],[7,100],[2,200],[17,30],[17,45],[3,5],[7,8],[3,6],[3,10],[7,20],[17,3],[17,45]]
            int[][] envelopes = new int[14][] { new int[2]{ 1, 15 }, new int[2]{ 7, 18 }, new int[2]{ 7, 6 }, new int[2]{ 7, 100 }, new int[2]{ 2, 200 }, new int[2]{ 17, 30 }, new int[2]{ 17, 45 }, new int[2]{ 3, 5 }, new int[2]{ 7, 8 }, new int[2]{ 3, 6 }, new int[2]{ 3, 10 }, new int[2]{ 7, 20 }, new int[2]{ 17, 3 }, new int[2]{ 17, 45 } };
            //envelopes[0] = new int[2] { 2, 100 };
            //envelopes[1] = new int[2] { 3, 200 };
            //envelopes[2] = new int[2] { 4, 300 };
            //envelopes[3] = new int[2] { 5, 500 };
            //envelopes[4] = new int[2] { 5, 400 };
            //envelopes[5] = new int[2] { 5, 250 };
            //envelopes[6] = new int[2] { 6, 370 };
            //envelopes[7] = new int[2] { 6, 360 };
            //envelopes[8] = new int[2] { 7, 380 };
            //envelopes[3] = new int[2] { 2, 3 };

            int k = envelopes.GetLength(0);


            

                Console.WriteLine("Old:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("[" + envelopes[i][0] + "," + envelopes[i][1] + "]");

            }

            //排序-W
            int[] temp_w = new int[2];
            for (int i = 0; i < k-1; i++)
            {
                for (int j = i+1; j < k; j++)
                {
                    if (envelopes[i][0]> envelopes[j][0])
                    {
                        temp_w = envelopes[i];
                        envelopes[i] = envelopes[j];
                        envelopes[j] = temp_w;
                    }
                }
            }

            Console.WriteLine("Sort1:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("[" + envelopes[i][0] + "," + envelopes[i][1] + "]");

            }


            //排序-H
            int l_dx = 0, r_dx = 0;
            bool isdirty = false;
            for (int i = 0; i < k-1; i++)
            {
                if (isdirty && envelopes[i][0] != envelopes[i + 1][0])
                {

                    int[] temp_h = new int[2];
                    for (int m = l_dx; m < r_dx; m++)
                    {
                        for (int n = m + 1; n < r_dx + 1; n++)
                        {
                            if (envelopes[m][1] < envelopes[n][1])
                            {
                                temp_h = envelopes[m];
                                envelopes[m] = envelopes[n];
                                envelopes[n] = temp_h;
                            }
                        }
                    }

                    isdirty = false;
                    l_dx = 0;
                    r_dx = 0;
                }
                if (envelopes[i][0]==envelopes[i+1][0])
                {
                    if (!isdirty)
                    {
                        l_dx = i;
                        isdirty = true;
                    }

                    r_dx = i + 1;

                }
                if (i==k-2&& isdirty)
                {
                    int[] temp_h = new int[2];
                    for (int m = l_dx; m < r_dx; m++)
                    {
                        for (int n = m + 1; n < r_dx + 1; n++)
                        {
                            if (envelopes[m][1] < envelopes[n][1])
                            {
                                temp_h = envelopes[m];
                                envelopes[m] = envelopes[n];
                                envelopes[n] = temp_h;
                            }
                        }
                    }

                    isdirty = false;
                    l_dx = 0;
                    r_dx = 0;
                }

                
            }



            Console.WriteLine("Sort2:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("["+ envelopes [i][0]+","+ envelopes[i][1] + "]");

            }

            //取数组
            int[] ew = new int[k];
            int[] eh = new int[k];
            for (int i = 0; i < k; i++)
            {
                ew[i] = envelopes[i][0];
                eh[i] = envelopes[i][1];
            }

            Console.WriteLine("envelopes_W:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("[" + ew[i] + "]");

            }

            Console.WriteLine("envelopes_H:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("[" + eh[i] + "]");

            }

            //分别求最长子序列
            int[] dq_w = new int[k];
            int[] dq_h = new int[k];
            //初始化
            for (int i = 0; i < k; i++)
            {
                dq_w[i] = 1;
                dq_h[i] = 1;
            }
            //动态规划
            for (int i = 1; i < k; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (ew[i]>ew[j])
                    {
                        dq_w[i] = Math.Max(dq_w[j] + 1, dq_w[i]);
                    }
                    if (eh[i]>eh[j])
                    {
                        dq_h[i] = Math.Max(dq_h[j] + 1, dq_h[i]);
                    }
                }
            }


            Console.WriteLine("dq_w:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("[" + dq_w[i] + "]");

            }

            Console.WriteLine("dq_h:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("[" + dq_h[i] + "]");

            }

            Console.WriteLine("MAX:"+ dq_h.Max());

            Console.ReadKey();
        }
    }
}
