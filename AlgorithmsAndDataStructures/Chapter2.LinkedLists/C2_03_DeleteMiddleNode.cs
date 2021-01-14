using Chapter2.LinkedLists.HelperMethods;
using System;

namespace Chapter2.LinkedLists
{
    public class C2_03_DeleteMiddleNode
    {
        public static void DeleteNode(Node head)
        {
            var current = head;
            Node prev = null;

            #region Show Initial List
            Console.WriteLine("The list as is now:");
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            current = head;
            #endregion

            #region Find the middle node
            int ListLength = 0;            
            while (current != null)
            {
                ListLength++;
                current = current.next;
            }
            
            current = head;
            Console.WriteLine("\n\nList's Length is : " + ListLength);
            var middleNode = ListLength / 2;
            Console.WriteLine("\nThe middle node that has to be deleted is : " + middleNode);
            if (ListLength == 0 || middleNode == ListLength || middleNode == 0)
            {
                Console.WriteLine("\nThe node to delete CANNOT be the 1st or last Node. Return !");
                return;
            }
            #endregion

            #region Delete Middle Node
            int count = 0;          
            prev = current;
            while (current!=null)
            {                
                if (count == middleNode)
                {
                    prev.next = current.next;
                }
                else
                {
                    prev = current;
                }
                current = current.next;
                count++;
            }
            current = head;
            #endregion

            #region Show the List After Deletion
            Console.WriteLine("\nThe list after the deletion ");          
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            #endregion
        }
    }
}
