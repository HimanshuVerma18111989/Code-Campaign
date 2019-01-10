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
    }
}
