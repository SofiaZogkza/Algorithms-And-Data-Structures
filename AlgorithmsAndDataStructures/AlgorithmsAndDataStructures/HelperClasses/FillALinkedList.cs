using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.HelperClasses
{
    public class FillALinkedList
    {
        public LinkedList<int> FillLinkedList(int length)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.AddLast(random.Next(0, 10));
            }

            return list;
        }        
    }
}
