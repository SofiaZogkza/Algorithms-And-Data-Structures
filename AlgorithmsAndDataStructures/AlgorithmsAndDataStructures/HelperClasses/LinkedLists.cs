using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.HelperClasses
{
    //public class Node
    //{
    //    public int data;
    //    public Node next;
    //    public Node(int d)
    //    {
    //        data = d;
    //        next = null;
    //    }
    //}

    public class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
