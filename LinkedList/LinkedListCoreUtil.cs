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
