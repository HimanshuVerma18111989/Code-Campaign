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
            /*TreeNode root = new TreeNode(1);
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
            Console.WriteLine();*/
            /*TreeNode root2 = new TreeNode(1);
            root2.left = new TreeNode(2);
            root2.right = new TreeNode(3);
            root2.left.left = new TreeNode(4);
            root2.left.right = new TreeNode(5);
            root2.right.right = new TreeNode(8);
            root2.left.left.left = new TreeNode(6);
            root2.left.right.right = new TreeNode(7);
            root2.right.right.right = new TreeNode(9);
            TraversalUtil.LevelOrderTraversal(root2);*/
            TreeNode root3 = new TreeNode(1);
            root3.left = new TreeNode(2);
            root3.right = new TreeNode(5);
            root3.left.left = new TreeNode(3);
            root3.left.right = new TreeNode(4);
            root3.left.left.left = new TreeNode(7);
            root3.right.right = new TreeNode(6);
            //TraversalUtil.InorderTraversalIterative(root3);
            //TraversalUtil.PreOrderTraversal(root3);
            //TraversalUtil.PostOrderTraversalIterative(root3);
            TreeNode root4 = new TreeNode(1);
            root4.left = new TreeNode(2);
            root4.right = new TreeNode(3);
            root4.left.left = new TreeNode(4);
            root4.left.right = new TreeNode(5);
            root4.right.left = new TreeNode(6);
            root4.right.right = new TreeNode(7);
            root4.right.left.right = new TreeNode(8);
            //TraversalUtil.VerticalOrderTraversal(root4);
            //TraversalUtil.TopViewOfBinaryTree(root4);
            //TraversalUtil.BottomViewOfBinaryTree(root4);
            //TraversalUtil.LeftViewOfBinaryTree(root4);
            //TraversalUtil.RightViewOfBinaryTree(root4);
            //TraversalUtil.DiagonalTraversal(root4);

            TreeNode root5 = new TreeNode(1);
            root5.left = new TreeNode(2);
            root5.right = new TreeNode(6);
            root5.left.left = new TreeNode(3);
            root5.left.right = new TreeNode(4);
            root5.left.right.right = new TreeNode(5);

            //int height = CoreUtil.HeightBinaryTree(root5);
            //Console.Write($"Height: {height}");
            //Console.WriteLine();
            //int nodes = CoreUtil.NodesInBinaryTreeIterative(root5);
            //Console.WriteLine($"Number of nodes: {nodes}");
            //Console.WriteLine($"Number of nodes: {CoreUtil.NodesInBinaryTreeRecursive(root5)}");
            Console.WriteLine($"Number of Leafs: {CoreUtil.LeafNodeIterative(root5)}");
            Console.WriteLine($"Number of Leafs: {CoreUtil.LeafsInBinaryTreeRecursive(root5)}");
            Console.ReadLine();
        }
    }
}
