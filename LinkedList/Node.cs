using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
