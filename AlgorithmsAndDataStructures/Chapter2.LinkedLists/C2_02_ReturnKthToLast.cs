using Chapter2.LinkedLists.HelperMethods;
using System;

namespace Chapter2.LinkedLists
{
    public class C2_02_ReturnKthToLast
    {
        public static void ReturnKthToLast(Node head, int k)
        {
            Node current = head;
            int count = 0;

            Console.WriteLine("The list as is: ");
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            current = head;

            Console.WriteLine("\nLinked List items from kth element = " + k + " to last element ");
            while(current != null)
            {
                if (current != null && count >= k )
                {
                    Console.Write(current.data + " ");
                }
                current = current.next;
                count++;
            }

        }
    }
}
