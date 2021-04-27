using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树的最小深度
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root==null)
            {
                return 0;
            }
            TreeNode cur;
            Queue<TreeNode> q = new Queue<TreeNode>();
            Queue<TreeNode> visited = new Queue<TreeNode>();
            q.Enqueue(root);
            int step = 0;
            while (q.Count>0)
            {
                int sz = q.Count;
                for (int i = 0; i < sz; i++)
                {

                    cur = q.Dequeue();
                    if (cur.left == null && cur.right == null)
                    {
                        return step; 
                    }
                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        q.Enqueue(cur.right);
                    }
                }

                step++;
            }
            return step;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
