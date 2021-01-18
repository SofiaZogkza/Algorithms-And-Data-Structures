using Chapter2.LinkedLists.HelperMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2.LinkedLists
{
    public class C2_04_Partition
    {
        public static Node ParticionTheList_Solution1(Node head, int x)
        {
            Console.WriteLine("The list as is now:");
            PrintList(head);

            Node beforeStart = null;
            Node beforeEnd = null;
            Node afterStart = null;
            Node afterEnd = null;

            while (head != null)
            {
                Node next = head.next;
                head.next = null;
                if (head.data < x)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = head;
                        beforeEnd = beforeStart;
                    }
                    else
                    {
                        beforeEnd.next = head;
                        beforeEnd = head;
                    }
                }
                else
                {
                    if (afterStart == null)
                    {
                        afterStart = head;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.next = head;
                        afterEnd = head;
                    }
                }
                head = next;
            }

            if (beforeStart == null)
            {
                return afterStart;
            }

            /* Merge before list and after list */
            beforeEnd.next = afterStart;

            Console.WriteLine("\nThe final list:");
            PrintList(beforeStart);

            return beforeStart;
        }

        public static Node ParticionTheList_Solution2(Node start, int x)
        {
            Console.WriteLine("The list as is now:");
            PrintList(start);

            Node head = start;
            Node tail = start;

            while (start != null)
            {
                Node next = start.next;
                if (start.data < x)
                {
                    // Insert node at head.
                    start.next = head;
                    head = start;
                }
                else
                {
                    // Insert node at tail.
                    tail.next = start;
                    tail = start;
                }
                start = next;
            }
            tail.next = null;

            Console.WriteLine("\nThe final list:");
            PrintList(head);

            // The head has changed, so we need to return it to the user.
            return head;
        }

        public static void PrintList(Node head)
        {
            var temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }    
}
