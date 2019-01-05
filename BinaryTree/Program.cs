using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            TraversalUtil.PreOrderTraversal(root);
            TreeNode root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(5);
            root1.left.left = new TreeNode(3);
            root1.left.right = new TreeNode(4);
            Console.WriteLine();
            TraversalUtil.InOrderTraversal(root1);
            Console.WriteLine();
            TraversalUtil.PostOrderTraversal(root1);
            Console.ReadLine();
        }
    }
}
