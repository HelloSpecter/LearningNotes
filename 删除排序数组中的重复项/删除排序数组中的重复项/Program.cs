using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 删除排序数组中的重复项
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            ////这个方法太过复杂，时间不够
            //if (nums.Length==0)
            //{
            //    return 0;
            //}
            //int i;
            //for (i = 0; i < nums.Length-1; i++)
            //{
            //    if (nums[i + 1] == nums[i])
            //    {
            //        if (nums[i + 1] == nums.Max()) { break; }
            //        for (int j = i + 1; j < nums.Length - 1; j++)
            //        {
            //            if (nums[j + 1] > nums[j])
            //            {
            //                nums[j] = nums[j + 1];
            //            }
            //        }
            //        i = -1;
            //    }

            //}
            //return i + 1;
            //------------------------//
            //逻辑仍然复杂，时间消耗大
            //    int i;
            //    bool change;
            //    if (nums.Length == 0)
            //    {
            //        return 0;
            //    }
            //    int m_max = nums[0];
            //    for ( i = 0; i < nums.Length-1; i++)
            //    {

            //        change = false;
            //        if (nums[i + 1] <= nums[i])
            //        {
            //            int j = i + 1;
            //            for (; j < nums.Length; j++)
            //            {
            //                if (nums[j] > m_max)
            //                {
            //                    nums[i + 1] = nums[j];
            //                    m_max = nums[j];
            //                    change = true;
            //                    break;
            //                }

            //            }

            //        }
            //        else
            //        {
            //            m_max = nums[i + 1];
            //            continue;
            //        }
            //        if (!change)
            //        {
            //            break;
            //        }

            //    }
            //    return i + 1;
            //}
            if (nums.Length == 0)
            {
                return 0;
            }
            int slow = 0, fast = 0;
            for (; fast < nums.Length; fast++)
            {
                if (nums[fast] != nums[slow])
                {
                    nums[++slow] = nums[fast];
                }
            }
            return slow+1;
        }






        class Program
        {
            static void Main(string[] args)
            {
                int[] nums = { 1, 1,2,3,3,3,3,3,3,4,8 };
                Solution solution = new Solution();
                int len = solution.RemoveDuplicates(nums);
                Console.WriteLine("len:" + len);
                for (int i = 0; i < len; i++)
                {
                    Console.Write(nums[i] + " ");
                }

                Console.ReadLine();
            }

        }
    }
}
