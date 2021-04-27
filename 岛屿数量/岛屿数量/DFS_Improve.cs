using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 岛屿数量
{
    class DFS_Improve
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        Search(i, j);
                    }
                }
            }
            return count;
        void Search(int r,int c)
        {
                if (!inarea(r,c))
                {
                    return;
                }
                if (grid[r][c]!='1')
                {
                    return;
                }
                grid[r][c] = '2';//如果是1，标记为已遍历
                //下面开始上下左右深度搜索
                Search(r - 1, c);
                Search(r + 1, c);
                Search(r, c - 1);
                Search(r, c + 1);
        }
        bool inarea(int r,int c)
        {
            if (r>=0&&r< grid.GetLength(0)&&c>=0&&c<grid[r].Length)
            {
                    return true;
            }
                return false;
        }

        }

    }
}
