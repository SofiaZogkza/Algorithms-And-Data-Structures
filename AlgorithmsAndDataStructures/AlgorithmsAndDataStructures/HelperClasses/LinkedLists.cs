using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.HelperClasses
{
    internal class LinkedLists
    {
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
    }

    internal class DNode
    {
        internal int data;
        internal DNode prev;
        internal DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
