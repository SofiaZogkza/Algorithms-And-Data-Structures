using AlgorithmsAndDataStructures.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter2.LinkedLists
{
    public class C2_01_RemoveDups
    {
        public static void RemoveDuplicates(int n)
        {
            var _unsortedList = new FillALinkedList();
            var newList = _unsortedList.FillLinkedList(n);
            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Linked List's Length: " + n);

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


    }
}
