using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树转堆
{
    class Program
    {
        static void Main(string[] args)
        {
            int len =10;
            int[] ori = new int[len];
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                ori[i] = random.Next(1, 10*len);
            }

            Console.WriteLine("原数组为:");
            for (int i = 0; i < len; i++)
            {
                Console.Write("["+ori[i]+"]"+" ");
            }
            

            int[] cur = new int[len];

            cur = (int[])ori.Clone();

            AdjustHeap(cur, cur.Length, 0,cur.Length);

            Console.WriteLine("\n调整后数组为:");

            for (int i = 0; i < len; i++)
            {
                Console.Write("[" + cur[i] + "]" + " ");
            }

            HeapSort(ori);

            Console.WriteLine("\n排序后数组为:");

            for (int i = 0; i < len; i++)
            {
                Console.Write("[" + ori[i] + "]" + " ");
            }
            Console.ReadKey();

        }
        static void HeapSort(int[] cur)
        {
            for (int i = cur.Length; i > 1  ; i--)
            {
                AdjustHeap(cur, i, 0, i);
                Swap(cur, 0, i - 1);
            }

        }
        
        static void AdjustHeap(int[] cur,int len,int i,int max)
        {
            //left=2*i+1,right=2*i+2
            while (i < len / 2&&i>=0||i==0)
            {
                bool isSwap = false;
                isSwap = Compare(cur, i, max);
                if (isSwap&&i!=0)
                {
                    if ((i-1)%2==0)
                    {
                        AdjustHeap(cur, i, (i - 1) / 2,max);
                    }
                    else
                    {
                        AdjustHeap(cur, i, (i - 2) / 2, max);
                    }
                    
                }
                i++;
            }

        }
        static void Swap(int[] cur, int a, int b)
        {
            int temp;
            temp = cur[a];
            cur[a] = cur[b];
            cur[b] = temp;
        }

        static bool Compare(int[] cur,int i,int max)
        {
            bool isSwap = false;
            if (cur[i] <= cur[2 * i + 1] && 2*i+1< max)
            {
                Swap(cur, i, 2 * i + 1);
                isSwap = true;
            }
            if (2*i+2<max)
            {
                if (cur[i] <= cur[2 * i + 2])
                {
                    Swap(cur, i, 2 * i + 2);
                    isSwap = true;
                }
            }
            
            return isSwap;
        }

    }
}
