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
    }
}
