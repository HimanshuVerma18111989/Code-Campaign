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
