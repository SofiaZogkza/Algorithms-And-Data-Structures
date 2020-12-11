using System;

namespace BinarySearchTree
{
    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data;

        //public Node(int data)
        //{
        //    data = root;
        //}

        //public void Insert(int value)
        //{
        //    if (value <= root)
        //    {
        //        if (left == null)
        //        {
        //            left = new Node(value);
        //        }
        //        else
        //        {
        //            left.Insert(value);
        //        }
        //    }
        //    else
        //    {
        //        if (right == null)
        //        {
        //            right = new Node(value);
        //        }
        //        else
        //        {
        //            right.Insert(value);
        //        }
        //    }
        //}

        //public Boolean Contains(int value)
        //{
        //    if (value == root)
        //    {
        //        return true;
        //    }
        //    else if (value < root)
        //    {
        //        if (left == null)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return left.Contains(value);
        //        }
        //    }
        //    else
        //    {
        //        if(right == null)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return right.Contains(value);
        //        }
        //    }
        //}

        //public void PrintInOrder()
        //{
        //    if (left != null)
        //    {
        //        left.PrintInOrder();
        //    }
        //    Console.WriteLine(root);
        //    if (right != null)
        //    {
        //        right.PrintInOrder();

        //    }
        //}

        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
