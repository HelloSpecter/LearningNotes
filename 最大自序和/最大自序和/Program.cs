using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最大自序和
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2};

            int i1 = 0, j1 = 0, max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                int j = 0;
                while (j<nums.Length)
                {
                    int temp = 0;
                    for (int k = j; k <= j+i; k++)
                    {
                        if (k>=nums.Length)
                        {
                            break;
                        }
                        temp += nums[k];
                    }
                    if (temp>max)
                    {
                        max = temp;
                    }
                    j++;
                }
            }
            for (int m = i1; m <= i1 + j1; m++)
            {
                Console.Write(nums[m] + " ");
            }
            Console.WriteLine("\n"+max.ToString());

            Console.ReadKey();
        }
    }
}
