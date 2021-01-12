using Chapter2.LinkedLists.HelperMethods;
using System;

namespace Chapter2.LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper help = new Helper();
            //C2_01_RemoveDups.RemoveDuplicates(10);



            Node start = new Node(10);
            start.next = new Node(12);
            start.next.next = new Node(11);
            start.next.next.next = new Node(11);
            start.next.next.next.next = new Node(12);
            start.next.next.next.next.next = new Node(11);
            start.next.next.next.next.next.next = new Node(10);

            Console.WriteLine("Linked list before removing " + "duplicates :");
            help.PrintList(start);

            C2_01_RemoveDups.RemoveDuplicaties_CustomedLinkedList(start);

            Console.WriteLine("\nLinked list after removing " +
                              "duplicates :");
            help.PrintList(start);



            Console.ReadLine();
        }
    }
}
