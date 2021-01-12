using System;

namespace Chapter2.LinkedLists.HelperMethods
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
        }
    }

    public class Helper
    {
        public void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
    }
}
