using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乘积最大子组数
{
    class Program
    {
        static void Main(string[] args)
        {
            //dp(i)=max{dp(i-1)*nums(i),nums(i)};
            int[] nums = new int[5] { 2, -5, -2, -4, 3 };
            int[] dp1 = new int[nums.Length];
            int[] dp2 = new int[nums.Length];
            dp1[0] = nums[0];//max
            dp2[0] = nums[0];//min
            
            for (int i = 1; i < nums.Length; i++)
            {
                dp1[i] = Math.Max(dp1[i - 1] * nums[i], nums[i]);
                dp1[i] = Math.Max(dp1[i], dp2[i - 1] * nums[i]);
                dp2[i] = Math.Min(dp1[i - 1] * nums[i], nums[i]);
                dp2[i] = Math.Min(dp2[i], dp2[i - 1] * nums[i]);
            }

            Console.WriteLine(Math.Max(dp1.Max(),dp2.Max()));
            Console.ReadKey();
        }
    }
}
