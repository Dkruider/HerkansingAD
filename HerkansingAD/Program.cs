using System;
using Huiswerk5;

namespace HerkansingAD
{
    class Program
    {
        static void BinarySearchTree()
        {
            BinarySearchTree<int> bst;

            bst = new BinarySearchTree<int>();

            bst.Insert(9);
            bst.Insert(2);
            bst.Insert(11);
            bst.Insert(1);
            bst.Insert(7);
            bst.Insert(10);
            bst.Insert(12);
            bst.Insert(3);
            bst.Insert(8);
            bst.Insert(5);
            bst.Insert(4);
            bst.Insert(6);

            Console.WriteLine(bst.ToPrefixString());
        }

        static void PriorityQueue()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();

            q.array = new int[] { 0, 25, 21, 22, 18, 19, 40, 50, 17, 16 };
            q.size = 9;

            Console.WriteLine(q.ToString());

            q.PercolateDown(1);

            Console.WriteLine(q.ToString());
        }


        static void Main(string[] args)
        {
            BinarySearchTree();
            PriorityQueue();

            Console.ReadKey();
        }
    }
}
