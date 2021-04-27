using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 岛屿数量
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        { 
            char[][] temp = new char[grid.GetLength(0)][];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                temp[i] = new char[grid[i].Length];
                grid[i].CopyTo(temp[i], 0);
            }

            void Search(int a, int b)
            {
                left(a, b);
                right(a, b);
                up(a, b);
                down(a, b);
            }
            void left(int m, int n)
            {
                int j = n - 1;
                if (j < 0)
                {
                    return;
                }
                if (grid[m][j] == '1'&&temp[m][j]=='1')
                {
                    temp[m][j] = '0';
                    Search(m, j);
                }
                return;
            }
            void right(int m, int n)
            {
                int j = n + 1;
                if (j >= grid[m].Length)
                {
                    return;
                }
                if (grid[m][j] == '1' && temp[m][j] == '1')
                {
                    temp[m][j] = '0';
                    Search(m, j);
                }
                return;
            }
            void up(int m, int n)
            {
                int i = m - 1;
                if (i < 0)
                {
                    return;
                }
                if (grid[i][n] == '1' && temp[i][n] == '1')
                {
                    temp[i][n] = '0';
                    Search(i, n);
                }
                return;
            }
            void down(int m, int n)
            {
                int i = m +1;
                if (i >= grid.GetLength(0))
                {
                    return;
                }
                if (grid[i][n] == '1' && temp[i][n] == '1')
                {
                    temp[i][n] = '0';
                    Search(i, n);
                }
                return;
            }
            int count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (temp[i][j]=='1')
                    {
                        count++;
                        Search(i, j);
                    }
                }
            }
            return count;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////关于赋值引用于数值赋值的测试
            //char[][] grid = { new char[] { 'c' }, new char[] { 'v', 'e', 'y' }, new char[] { 'c', 'u' } };
            //char[][] temp = grid;
            ////char[][] temp = new char[grid.GetLength(0)][];
            ////for (int i = 0; i < grid.GetLength(0); i++)
            ////{
            ////    temp[i] = new char[grid[i].Length];
            ////    grid[i].CopyTo(temp[i], 0);
            ////}
            //void search(char[][] zifu)
            //{
            //    foreach (char[] item in zifu)
            //    {
            //        foreach (char i in item)
            //        {
            //            Console.Write(i+" ");
            //        }
            //    }
            //}
            //search(temp);
            //grid[0][0] = '1';
            //Console.WriteLine("\n");
            //search(temp);
            //Console.ReadLine();
            Solution solution = new Solution();
            DFS_Improve dfs = new DFS_Improve();
            char[][] grid = new char[][] { new char[] { '1', '1', '1', '0', '0' }, new char[] { '0', '0', '1', '0', '0' }, new char[] { '0', '0', '1', '0', '0' }, new char[] { '1', '1', '1', '0', '0' } };
            Console.WriteLine(solution.NumIslands(grid));
            Console.WriteLine(dfs.NumIslands(grid));
            Console.ReadLine();
        }
    }
}
