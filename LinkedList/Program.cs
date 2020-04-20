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
            head.next.next.next = new Node(4, null);
            head.next.next.next.next = new Node(5, null);
            LinkedListCoreUtil.PrintLinkedList(head);
            //head = LinkedListCoreUtil.InsertNodeAtStart(0, head);
            Console.WriteLine();
            //LinkedListCoreUtil.PrintLinkedList(head);
            //Console.WriteLine();
            /*LinkedListCoreUtil.InsertAtEndOfList(100, head);
            LinkedListCoreUtil.PrintLinkedList(head);
            head = LinkedListCoreUtil.DeletionOfFrontNode(head);
            LinkedListCoreUtil.PrintLinkedList(head);
            Console.WriteLine();
            head = LinkedListCoreUtil.DeletionOfLastNode(head);
            LinkedListCoreUtil.PrintLinkedList(head);*/
            //head = LinkedListCoreUtil.ReverseList(head);
            /*head = LinkedListCoreUtil.ReverseLinkedListRecursively(head, null);
            LinkedListCoreUtil.PrintLinkedList(head);*/
            //Node kthNode = LinkedListCoreUtil.FindKthElementFromEnd(head, -1);
            //Console.WriteLine($"{kthNode.data}");
            Node head2 = new Node(9, null);
            head2.next = new Node(9, null);
            head2.next.next = new Node(3, null);
            head2.next.next.next = new Node(4, null);
            head2.next.next.next.next = new Node(9, null);
            //head2.next.next.next = head.next;
            LinkedListCoreUtil.PrintLinkedList(head2);
            Console.WriteLine();
            /*Node intersect = LinkedListCoreUtil.FindIntersectionOfLists(head, head2);
            if (intersect != null)
            {
                Console.WriteLine($"{intersect.data}");
            }
            else
            {
                Console.WriteLine("No Intersection found");
            }*/
            Node retHead = LinkedListCoreUtil.AddingTwoLinkedList(head, head2, 10);
            LinkedListCoreUtil.PrintLinkedList(retHead);
            Console.ReadLine();
        }
    }
}
