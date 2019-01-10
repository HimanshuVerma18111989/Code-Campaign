using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class CoreUtil
    {
        public static int HeightBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int lh = HeightBinaryTree(root.left);
                int rh = HeightBinaryTree(root.right);
                int height = Math.Max(lh, rh) + 1;
                return height;
            }
        }

        public static int NodesInBinaryTreeIterative(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                int count = 0;
                while (queue.Count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    count++;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                return count;
            }
        }
        public static int NodesInBinaryTreeRecursive(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int countl = NodesInBinaryTreeRecursive(root.left);
                int countr = NodesInBinaryTreeRecursive(root.right);
                return countl + countr + 1;
            }
        }
    }
}
