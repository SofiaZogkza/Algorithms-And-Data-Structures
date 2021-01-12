using AlgorithmsAndDataStructures.HelperClasses;
using Chapter2.LinkedLists.HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter2.LinkedLists
{
    public class C2_01_RemoveDups
    {
        public static void RemoveDuplicates(int ListLength)
        {
            var _unsortedList = new FillALinkedList();
            var newList = _unsortedList.FillLinkedList(ListLength);
            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Linked List's Length: " + ListLength);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in newList)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                    //newList.Remove(item);
                }
                else
                {
                    dict[item] = 1;
                }
            }

            foreach (var item in dict.Keys.ToList())
            {
                while(dict[item] != 1)
                {
                    dict[item]--;
                    newList.Remove(item);
                }
            }


            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("After Removing Dups the Linked List's Length: " + newList.Count);
        }

       
        public static void RemoveDuplicaties_CustomedLinkedList(Node head)
        {
            // Hash to store seen values
            HashSet<int> hs = new HashSet<int>();

            // Pick elements one by one 
            Node current = head;
            Node prev = null;
            while (current != null)
            {
                int curval = current.data;

                // If current value is seen before
                if (hs.Contains(curval))
                {
                    prev.next = current.next;
                }
                else
                {
                    hs.Add(curval);
                    prev = current;
                }
                current = current.next;
            }           
        }

        

        
    }
}
