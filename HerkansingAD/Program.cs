using System;
using Huiswerk2;
using Huiswerk2.Ex5Queue;
using Huiswerk5;

namespace HerkansingAD
{
    class Program
    {

        static void ArrayList()
        {
            System.Console.WriteLine("\n=====   Opgave 1 : MyArrayList   =====\n");

            MyArrayList al = new MyArrayList(10);
            System.Console.WriteLine(al);
            al.Add(2);
            al.Add(3);
            al.Add(5);
            System.Console.WriteLine(al);
            Console.WriteLine(al.Get(0));
            try
            {
                Console.WriteLine(al.Get(3));
            }
            catch (MyArrayListIndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            al.Set(2, 4);
            System.Console.WriteLine(al);

            al.Clear();
            for (int i = 0; i < 10; i++)
            {
                al.Add(i);
            }
            al.Set(9, 2);
            al.Set(7, 2);
            System.Console.WriteLine(al);
            Console.WriteLine(al.CountOccurences(2));

            Console.WriteLine($"value exist: {al.CheckValueExist(10)}");
            Console.WriteLine($"value exist: {al.CheckValueExist(2)}");
        }


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

        static void Queue()
        {
            //IMyQueue<int> queue = new MyArrayQueue<int>();
            IMyQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.ToString());

            Console.WriteLine(queue.Contains(10));

            Console.WriteLine(queue.Count());

            queue.Dequeue();

            Console.WriteLine(queue.Count());
        }

        public static void Stack()
        {
            IMyStack<int> stack = new MyStack<int>();
            IMyStack<int> arrayListStack = new MyArrayListStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            arrayListStack.Push(1);
            arrayListStack.Push(2);
            arrayListStack.Push(3);
            arrayListStack.Push(4);
            arrayListStack.Push(5);

            Console.WriteLine(stack.ToString());
            Console.WriteLine(arrayListStack.ToString());

            Console.WriteLine(stack.Pop());
            Console.WriteLine(arrayListStack.Pop());

            Console.WriteLine(stack.ToString());
            Console.WriteLine(arrayListStack.ToString());
        }


        static void Main(string[] args)
        {
            //ArrayList();
            //BinarySearchTree();
            //PriorityQueue();
            //Queue();
            Stack();

            Console.ReadKey();
        }
    }
}
