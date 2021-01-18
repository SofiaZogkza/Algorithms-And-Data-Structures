using Chapter2.LinkedLists.HelperMethods;
using System;

namespace Chapter2.LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper help = new Helper();

            #region Remove Dublicates
            //C2_01_RemoveDups.RemoveDuplicates(10);

            //Node start = new Node(10);
            //start.next = new Node(12);
            //start.next.next = new Node(11);
            //start.next.next.next = new Node(11);
            //start.next.next.next.next = new Node(12);
            //start.next.next.next.next.next = new Node(11);
            //start.next.next.next.next.next.next = new Node(10);

            //Console.WriteLine("Linked list before removing " + "duplicates :");
            //help.PrintList(start);

            ////C2_01_RemoveDups.RemoveDuplicaties_CustomedLinkedList(start);

            //Console.WriteLine("\nLinked list after removing " +
            //                  "duplicates :");
            //help.PrintList(start);
            #endregion

            //C2_02_ReturnKthToLast.ReturnKthToLast(start, 3);

            //C2_03_DeleteMiddleNode.DeleteNode(start);

            Node start = new Node(3);
            start.next = new Node(5);
            start.next.next = new Node(8);
            start.next.next.next = new Node(5);
            start.next.next.next.next = new Node(10);
            start.next.next.next.next.next = new Node(2);
            start.next.next.next.next.next.next = new Node(1);
            //C2_04_Partition.ParticionTheList_Solution1(start, 5);
            C2_04_Partition.ParticionTheList_Solution2(start, 5);


            Console.ReadLine();
        }
    }
}
