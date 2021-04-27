using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十大排序算法
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成随机数组
            int len = 20;
            int[] arr =new int[len];
            int[] arr_or = new int[len];
            bool outResult = false;
            Random random = new Random();
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("是否输出排序结果：");
            ConsoleKeyInfo c = Console.ReadKey();
            if (c.KeyChar=='t')
            {
                outResult = true;
            }
            else
            {
                outResult = false;
            }
            if (outResult) Console.WriteLine("OriginalData1:");
            for (int i = 0; i < len; i++)
            {
                arr_or[i] = random.Next(1, len*3);
                if(outResult) Console.Write("["+ arr_or[i]+"] ");
            }

            //arr_or = new int[10] { 7,23,12,27,17,24,6,18,6,28};

            arr = (int[])arr_or.Clone();
            watch.Restart();
            BubbleSort(arr);
            watch.Stop();
            Console.WriteLine("\nBubbleSort:总时间"+watch.Elapsed.TotalMilliseconds+"ms");

            for (int i = 0; i < len; i++)
            {
                if (outResult) Console.Write("[" + arr[i] + "] ");
            }

            Console.WriteLine("\n");

            //---

            arr = (int[])arr_or.Clone();

            watch.Restart();
            SelectionSort(arr);
            watch.Stop();
            Console.WriteLine("SelectionSort:总时间" + watch.Elapsed.TotalMilliseconds + "ms");

            for (int i = 0; i < len; i++)
            {
                if (outResult) Console.Write("[" + arr[i] + "] ");
            }
            Console.WriteLine("\n");

            //---

            arr = (int[])arr_or.Clone();

            //int[] sorted = new int[len];
            watch.Restart();
            InsertionSort(arr);
            watch.Stop();
            Console.WriteLine("InsertionSort:总时间" + watch.Elapsed.TotalMilliseconds + "ms");

            for (int i = 0; i < len; i++)
            {
                if (outResult) Console.Write("[" + arr[i] + "] ");
            }
            Console.WriteLine("\n");

            //---

            arr = (int[])arr_or.Clone();
            watch.Restart();
            ShellSort(arr);
            watch.Stop();
            Console.WriteLine("ShellSort:总时间" + watch.Elapsed.TotalMilliseconds + "ms");

            for (int i = 0; i < len; i++)
            {
                if (outResult) Console.Write("[" + arr[i] + "] ");
            }
            Console.WriteLine("\n");

            //---

            arr = (int[])arr_or.Clone();
            watch.Restart();
            MergeSort(arr);
            watch.Stop();
            Console.WriteLine("MergeSort:总时间" + watch.Elapsed.TotalMilliseconds + "ms");

            for (int i = 0; i < len; i++)
            {
                if (outResult) Console.Write("[" + arr[i] + "] ");
            }
            Console.WriteLine("\n");

            //---

            arr = (int[])arr_or.Clone();
            watch.Restart();
            QuickSort(arr);
            watch.Stop();
            Console.WriteLine("QuickSort:总时间" + watch.Elapsed.TotalMilliseconds + "ms");

            for (int i = 0; i < len; i++)
            {
                if (outResult) Console.Write("[" + arr[i] + "] ");
            }
            Console.WriteLine("\n");

            //---

            arr = (int[])arr_or.Clone();
            watch.Restart();
            HeapSort(arr);
            watch.Stop();
            Console.WriteLine("HeapSort:总时间" + watch.Elapsed.TotalMilliseconds + "ms");

            for (int i = 0; i < len; i++)
            {
                if (outResult) Console.Write("[" + arr[i] + "] ");
            }
            Console.WriteLine("\n");

            //---

            Console.ReadKey();
            
        }

        /// <summary>
        /// 1_BubbleSort
        /// 外层循环 len-1 为趟数
        /// 内层循环为每一趟中的比较次数(已经排好序的不遍历)
        /// </summary>
        /// <param name="arr"></param>
        static void BubbleSort(int[] arr)
        {
            bool isSwap;
            for (int i = arr.Length-1; i > 0; i--)
            {
                isSwap = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = 0;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        if(!isSwap)isSwap = true;
                    }
                }
                if (!isSwap)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 2_SelectionSort
        /// 首先在未排序序列中找到最小（大）元素，存放到排序序列的起始位置。
        ///再从剩余未排序元素中继续寻找最小（大）元素，然后放到已排序序列的末尾。
        ///重复第二步，直到所有元素均排序完毕。
        /// </summary>
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[min].CompareTo(arr[j])>0)
                    {
                        min = j;
                    }
                }
                if (i!=min)
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }

        /// <summary>
        /// 3_InsertionSort
        /// 原理与扑克牌摸牌类似：
        /// 刚拿到的牌，在之前的牌（已经理好顺序）中找合适的位置插入
        /// 重点：1.把当前位置的数拿出来（temp复制一份）2.依次对之前的数据（已排好序）从后往前判断,小于就交换位置,不小于就保持原位，并立即往后进行下一个数的判断
        /// </summary>
        /// <param name="arr"></param>
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                for (int j = i-1; j >= 0; j--)
                {
                    if (temp<arr[j])
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            //int k = arr.Length;
            //int[] sorted = new int[k];

            //int len0 = 1;
            //sorted[0] = arr[0];

            //for (int i = 1; i < k; i++)
            //{
            //    Insert(len0, arr[i]);
            //    len0++;
            //}

            //return sorted;

            //void Insert(int len, int num)
            //{
            //    bool isSwap = false;
            //    for (int i = 0; i < len; i++)
            //    {
            //        if (num<sorted[i])
            //        {
            //            for (int j = len-1; j >= i; j--)
            //            {
            //                sorted[j + 1] = sorted[j];
            //            }
            //            sorted[i] = num;
            //            if (!isSwap)
            //            {
            //            isSwap = true;

            //            }
            //        }
            //        if (isSwap)
            //        {
            //            break;
            //        }
            //    }
            //    if (!isSwap)
            //    {
            //        sorted[len] = num;
            //    }
            //}


        }

        /// <summary>
        /// 4_ShellSort
        /// 插入排序的改进：
        /// 跳着（以k为间隔取出数据：1+k 1+2k 1+3k.. 2+k 2+2k 2+3k.. ）进行插入排序，跳的间隔逐渐缩小，最终为k=1时最后进行1遍插入排序
        /// 核心:
        /// 1.D(k+1间隔)的有序序列在经过D(k)间隔排序后，仍然是D(k+1)间隔的
        /// 2.在当前间隔内，不重复取值！eg:k=2时:(0,2,4,6,8,10...)、(1,3,5,7,9,11....)2组就结束了,切记！->(2,4,6,8,10..)这种不要取
        /// </summary>
        static void ShellSort(int[] arr)
        {
            //设置增量数组
            int[] gap = new int[5];
            //int temp = arr.Length;
            //for (int i = 0; i < 5; i++)
            //{
            //    temp = temp / 2;
            //    if (temp <= 1)
            //    {
            //        break;
            //    }
            //    gap[i] = temp;
            //}

            //增量序列：(2的k次方)-1
            for (int i = 1; i <= 5; i++)
            {
                gap[5-i] = (int)Math.Pow(2, i) - 1;
            }


            //最后1次增量必须为1
            gap[gap.Length - 1] = 1;

            //增量个数：
            int gap_len = gap.Length;

            for (int i = 0; i < gap_len; i++)//增量gap有几个就计算几遍
            {
                for (int idx = 0; idx < gap[i] ; idx++)//进行分组，注意j<gap[i]，已经分过组、排过序的不要重复操作
                {
                    for (int cur_idx = idx+gap[i]; cur_idx < arr.Length; cur_idx+=gap[i])//该间隔下，每1个待排序的数
                    {
                        int temp = arr[cur_idx];//复制这个数，在后面的排序中找合适的位置放置

                        for (int pre_idx = cur_idx-gap[i]; pre_idx >= idx; pre_idx-=gap[i])//将该数与之前的有序数组进行插入排序
                        {
                            if (temp<arr[pre_idx])//如果比前1个数小，交换位置
                            {
                                arr[pre_idx+gap[i]] = arr[pre_idx];
                                arr[pre_idx] = temp;
                            }
                            else//比前1个数大，则当前位置即最佳，不再往前判断，进入下1个数的判断
                            {
                                break;
                            }
                        }
                    }
                }
            }

            
        }

        /// <summary>
        /// 5_Merge sort
        /// 归并排序、合并排序：
        /// 向下递归拆分、拆到1个数时向上合并并排序
        /// </summary>
        /// <param name="arr"></param>
        static void MergeSort(int[] arr)
        {
            int[] result = new int[arr.Length];
            int start = 0;
            int end = arr.Length - 1;
            if (end<=start)
            {
                return;
            }

            Recursion(arr, result, start, end);

        }
        static void Recursion(int[] arr,int[] result,int start,int end)
        {
            if (start==end)
            {
                return;
            }
            int middle = (start + end) / 2;
            //拆分左侧
            Recursion(arr,result,start,middle);
            //拆分右侧
            Recursion(arr, result, middle + 1, end);
            //归并排序
            Merge(arr, result, start, end);
        }//递归拆分
        static void Merge(int[] arr,int[] result,int start,int end)
        {
            int middle = (start + end) / 2;
            int index1 = start;
            int end1 = middle;
            int index2 = middle + 1;
            int end2 = end;
            int result_idx = start;
            while (index1<=end1&&index2<=end2)
            {
                result[result_idx++] = arr[index1] <= arr[index2] ? arr[index1++] : arr[index2++];
            }
            while (index1 <= end1)
            {
                result[result_idx++] = arr[index1++];
            }
            while (index2<=end2)
            {
                result[result_idx++] = arr[index2++];
            }
            for (int i = start; i <= end; i++)
            {
                arr[i] = result[i];
            }
        }

        /// <summary>
        /// 6_快速排序
        /// 核心：
        /// 1.分区、排序取中间点
        /// 2.左右两区递归，直到start == end || start == end + 1（对应1个数字和0个数字的情况）
        /// 3.分区时注意left和right的边界情况
        /// </summary>
        /// <param name="arr"></param>
         static void QuickSort(int[] arr)
        {
            quickSort(arr, 0, arr.Length - 1);
        }
         static void quickSort(int[] arr, int start, int end)
        {
            // 如果区域内的数字少于 2 个，退出递归
            if (start >= end) return;
            // 将数组分区，并获得中间值的下标
            int middle = partition1(arr, start, end);
            // 对左边区域快速排序
            quickSort(arr, start, middle - 1);
            // 对右边区域快速排序
            quickSort(arr, middle + 1, end);
        }
        /// <summary>
        /// 简单分区
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
         static int partition1(int[] arr, int start, int end)
        {
            // 取第一个数为基数
            int pivot = arr[start];
            // 从第二个数开始分区
            int left = start + 1;
            // 右边界
            int right = end;
            // left、right 相遇时退出循环
            while (left < right)
            {
                // 找到第一个大于基数的位置
                while (left < right && arr[left] <= pivot) left++;
                // 交换这两个数，使得左边分区都小于或等于基数，右边分区大于或等于基数
                if (left != right)
                {
                    exchange(arr, left, right);
                    right--;
                }
            }
            // 如果 left 和 right 相等，单独比较 arr[right] 和 pivot
            if (left == right && arr[right] > pivot) right--;
            // 将基数和中间数交换
            if (right != start) exchange(arr, start, right);
            // 返回中间值的下标
            return right;
        }
        /// <summary>
        /// 双指针分区
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int partition2(int[] arr, int start, int end)
        {
            // 取第一个数为基数
            int pivot = arr[start];
            // 从第二个数开始分区
            int left = start + 1;
            // 右边界
            int right = end;
            while (left < right)
            {
                // 找到第一个大于基数的位置
                while (left < right && arr[left] <= pivot) left++;
                // 找到第一个小于基数的位置
                while (left < right && arr[right] >= pivot) right--;
                // 交换这两个数，使得左边分区都小于或等于基数，右边分区大于或等于基数
                if (left < right)
                {
                    exchange(arr, left, right);
                    left++;
                    right--;
                }
            }
            // 如果 left 和 right 相等，单独比较 arr[right] 和 pivot
            if (left == right && arr[right] > pivot) right--;
            // 将基数和轴交换
            exchange(arr, start, right);
            return right;
        }
         static void exchange(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// 7_堆排序:
        /// 利用堆得概念来排序的选择排序算法
        /// 大顶堆->用于升序排列，小顶堆->用于降序排列
        /// 核心：
        /// 1.用数列构建出1个大顶堆
        /// 2.取出堆顶的数字后，将剩余的数字调整成新的大堆顶
        /// </summary>
        /// <param name="arr"></param>
        public static void HeapSort(int[] arr)
        {
            // 构建初始大顶堆
            buildMaxHeap(arr);
            for (int i = arr.Length - 1; i > 0; i--)
            {
                // 将最大值放到数组最后
                Swap(arr, 0, i);
                // 调整剩余数组，使其满足大顶堆
                maxHeapify(arr, 0, i);
            }
        }

        // 构建初始大顶堆
        public static void buildMaxHeap(int[] arr)
        {
            // 从最后一个非叶子结点开始调整大顶堆，最后一个非叶子结点的下标就是 arr.length / 2-1
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                maxHeapify(arr, i, arr.Length);
            }
        }

        // 调整大顶堆，第三个参数表示剩余未排序的数字的数量，也就是剩余堆的大小
        private static void maxHeapify(int[] arr, int i, int heapSize)
        {
            // 左子结点下标
            int l = 2 * i + 1;
            // 右子结点下标
            int r = l + 1;
            // 记录根结点、左子树结点、右子树结点三者中的最大值下标
            int largest = i;
            // 与左子树结点比较
            if (l < heapSize && arr[l] > arr[largest])
            {
                largest = l;
            }
            // 与右子树结点比较
            if (r < heapSize && arr[r] > arr[largest])
            {
                largest = r;
            }
            if (largest != i)
            {
                // 将最大值交换为根结点
                Swap(arr, i, largest);
                // 再次调整交换数字后的大顶堆
                maxHeapify(arr, largest, heapSize);
            }
        }
        // 交换元素
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
