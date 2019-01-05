using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class TraversalUtil
    {
        public static void PreOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                Console.Write($"{root.data}, ");
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }

        public static void InOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                InOrderTraversal(root.left);
                Console.Write($"{root.data}, ");
                InOrderTraversal(root.right);
            }
        }

        public static void PostOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.Write($"{root.data}, ");
            }
        }

        public static void LevelOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                List<TreeNode> queue = new List<TreeNode>();
                queue.Add(root);
                while (queue.Count > 0)
                {
                    int count = queue.Count;
                    while (count > 0)
                    {
                        TreeNode node = queue.ElementAt(0);
                        queue.RemoveAt(0);
                        Console.Write($"{node.data}, ");
                        if (node.left != null)
                        {
                            queue.Add(node.left);
                        }
                        if (node.right != null)
                        {
                            queue.Add(node.right);
                        }
                        count--;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
