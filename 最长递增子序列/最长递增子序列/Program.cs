using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最长递增子序列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            int[] len = new int[nums.Length];
            int[] temp = new int[nums.Length];
            int max_len = 1;
            len[0] = nums[0];
            temp[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                Compare(i);
                 temp[i] = max_len;
            }

            void Compare(int i)
            {
                if (max_len == 0)
                {
                    len[max_len] = nums[i];
                    max_len = 1;
                    return;
                }
                if (nums[i] == len[max_len - 1])
                {
                    return;
                }

                if (nums[i] > len[max_len - 1])
                {
                    max_len += 1;
                }
                else
                {
                    if (true)
                    {

                    }
                }
                len[max_len - 1] = nums[i];

            }

            for (int i = 0; i < max_len; i++)
            {

            Console.Write(len[i]+ " ");
            }
           
            Console.WriteLine("\n"+temp.Max());
            Console.ReadKey();
        }
    }
}
