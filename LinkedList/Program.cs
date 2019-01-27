using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1, null);
            head.next = new Node(2, null);
            head.next.next = new Node(3, null);
            LinkedListCoreUtil.PrintLinkedList(head);
            //head = LinkedListCoreUtil.InsertNodeAtStart(0, head);
            Console.WriteLine();
            //LinkedListCoreUtil.PrintLinkedList(head);
            //Console.WriteLine();
            LinkedListCoreUtil.InsertAtEndOfList(100, head);
            LinkedListCoreUtil.PrintLinkedList(head);
            head = LinkedListCoreUtil.DeletionOfFrontNode(head);
            LinkedListCoreUtil.PrintLinkedList(head);
            Console.WriteLine();
            head = LinkedListCoreUtil.DeletionOfLastNode(head);
            LinkedListCoreUtil.PrintLinkedList(head);
            Console.ReadLine();
        }
    }
}
