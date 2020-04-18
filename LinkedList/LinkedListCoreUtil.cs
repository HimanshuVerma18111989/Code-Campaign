using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class LinkedListCoreUtil
    {
        public static Node InsertNodeAtStart(int data, Node head)
        {
            if (head == null)
            {
                return new Node(data, null);
            }
            else
            {
                Node node = new Node(data, null);
                node.next = head;
                head = node;
                return head;
            }
        }
        public static Node InsertAtEndOfList(int data, Node head)
        {
            if (head == null)
            {
                return new Node(data, null);
            }
            else
            {
                Node crawler = head;
                while (crawler.next!=null)
                {
                    crawler = crawler.next;
                }
                crawler.next = new Node(data, null);
            }
            return head;
        }

        public static Node DeletionOfFrontNode(Node head)
        {
            if (head == null)
            {
                return head;
            }
            else
            {
                head = head.next;
                return head;
            }
        }

        public static Node DeletionOfLastNode(Node head)
        {
            if (head == null)
            {
                return head;
            }
            else if (head.next == null)
            {
                head = head.next;
                return head;
            }
            else
            {
                Node crawler = head;
                while (crawler.next.next != null)
                {
                    crawler = crawler.next;
                }
                crawler.next = null;
                return head;
            }
        }

        public static Node ReverseList(Node head)
        {
            if (head == null)
            {
                return head;
            }
            else
            {
                Node prev = null;
                Node curr = head;
                Node next = head.next;
                while (next != null)
                {
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                    next = next.next;
                }
                curr.next = prev;
                return curr;
            }
        }

        public static Node ReverseLinkedListRecursively(Node curr, Node prev)
        {
            Node rvHead = null;
            if (curr == null)
            {
                return prev;
            }
            rvHead = ReverseLinkedListRecursively(curr.next, curr);
            curr.next = prev;
            return rvHead != null ? rvHead : null;
        }

        public static Node FindKthElementFromEnd(Node head, int k)
        {
            if (k <= 0)
            {
                throw new ArgumentException("k value should be greater than zero");
            }
            if (head == null)
            {
                return null;
            }
            else
            {
                int count = 1;
                Node curr = head;
                while ((curr != null) && (count <= k))
                {
                    curr = curr.next;
                    count++;
                }
                if (count <= k)
                {
                    throw new ArgumentException($"k value should not be greater than the length of list");
                }
                Node prev = head;
                while (curr != null)
                {
                    prev = prev.next;
                    curr = curr.next;
                }
                return prev;
            }
        }

        public static Node FindIntersectionOfLists(Node head1, Node head2)
        {
            //When one or both of the list is/are null.
            if ((head1 == null) || (head2 == null))
            {
                return null;
            }
            else
            {
                //Calculating length of both lists.
                int len1 = ListLength(head1);
                int len2 = ListLength(head2);
                //Finding the difference between both of the lists.
                int diff = len1 - len2;
                //when first list length is greater than second list length.
                if (diff > 0)
                {
                    while (diff > 0)
                    {
                        head1 = head1.next;
                        diff--;
                    }
                }
                //When second list length is greater than first list length.
                else if (diff < 0)
                {
                    //converting negative value of diff to positive.
                    diff = Math.Abs(diff);
                    while (diff > 0)
                    {
                        head2 = head2.next;
                        diff--;
                    }
                }
                //For loop termination conditions
                /* Condition 1: When there is no intersection between the lists
                 *      In that head1 and head2 will become null.
                 * Condition 2: When there is intersection between the lists
                 *      In that case head1 and head2 will become equal.
                 */
                while ((head1 != null) && (head2 != null) && (head1 != head2))
                {
                    //Moving head of both lists forward by one step until loop termination conditions are met.
                    head1 = head1.next;
                    head2 = head2.next;
                }
                //Returning either intersection node or null.
                return head1 == null ? head1 : head2;
            }
        }

        public static int ListLength(Node head)
        {
            int len = 0;
            while (head != null)
            {
                len++;
                head = head.next;
            }
            return len;
        }
        public static void PrintLinkedList(Node head)
        {
            Node cralwer = head;
            while (cralwer != null)
            {
                Console.Write($"{cralwer.data}--->");
                cralwer = cralwer.next;
            }
        }
    }
}
