using System;
using System.Collections.Generic;
using Huiswerk2;
using Huiswerk2.Ex5Queue;
using Huiswerk4;
using Huiswerk5;
using Huiswerk6;
using HerkansingAD.RecursiveExercises;
using HerkansingAD.Sorting;

namespace HerkansingAD
{
    class Program
    {

        static void Factorial()
        {
            System.Console.WriteLine("\n=====   Factorial   =====\n");

            Factorial f = new Factorial();

            int MAX = 20;

            System.Console.WriteLine("Iteratief:");
            for (int n = 1; n < MAX; n++)
            {
                System.Console.WriteLine("          {0,2}! = {1,20}", n, f.FacIterative(n));
            }
            System.Console.WriteLine("Recursief:");
            for (int n = 1; n < MAX; n++)

            {
                System.Console.WriteLine("          {0,2}! = {1,20}", n, f.FacRecursive(n));
            }
        }

        static void Fibonacci()
        {
            System.Console.WriteLine("\n=====   Fibonacci   =====\n");
            Fibonacci f = new Fibonacci();

            int MAX = 35;

            System.Console.WriteLine("Recursief:");
            for (int n = 1; n <= MAX; n++)
            {
                System.Console.WriteLine("          Fibonacci({0,2}) = {1,8} ({2,9} calls)", n, f.FibonacciRecursive(n), f.calls);
            }

            System.Console.WriteLine("Iteratief:");
            for (int n = 1; n <= MAX; n++)
            {
                System.Console.WriteLine("          Fibonacci({0,2}) = {1,8} ({2,9} loops)", n, f.FibonacciIterative(n), f.calls);
            }
        }

        static void OmEnOm()
        {
            System.Console.WriteLine("\n=====   OmEnOm   =====\n");
            int MAX = 20;

            OmEnOm o = new OmEnOm();

            for (int n = 0; n < MAX; n++)
            {
                System.Console.WriteLine("          OmEnOm({0,2}) = {1,3}", n, o.OmEnOmMethod(n));
            }
        }

        static void Enen()
        {
            System.Console.WriteLine("\n=====   Enen   =====\n");
            Enen e = new Enen();

            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine("Enen({0,4}) = {1,2}", i, e.EnenMethod(i));
            }
            System.Console.WriteLine("Enen(1024) = {0,2}", e.EnenMethod(1024));
        }

        static void ForwardString()
        {
            System.Console.WriteLine("\n=====   ForwardString   =====\n");

            ForwardString f = new ForwardString();

            List<int> list = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });

            System.Console.WriteLine(f.Forward(list, 3));
            System.Console.WriteLine(f.Forward(list, 7));
            System.Console.WriteLine(f.BackwardString(list, 3));
            System.Console.WriteLine(f.BackwardString(list, 7));
        }

        static void Sorting()
        {
            System.Console.WriteLine("\n=====   Sorting   =====\n");
            Sorter isort = new InsertionSort();
            Sorter msort = new MergeSort();
            Sorter ssort = new ShellSort();
            isort.Run();
            msort.Run();
            ssort.Run();

            //            return;
            int[] numbers =
                {100, 1000, 10000};
            //                {12};
            foreach (int num in numbers)
            {
                isort.RunWithTimer(num);
                msort.RunWithTimer(num);
                ssort.RunWithTimer(num);
            }
        }


        static void ArrayList()
        {
            System.Console.WriteLine("\n=====   MyArrayList   =====\n");

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

        static void LinkedList()
        {
            System.Console.WriteLine("\n=====   MyLinkedList   =====\n");

            IMyLinkedList<string> lst = DSBuilder.CreateMyLinkedList();
            lst.AddFirst("1");
            lst.AddFirst("2");
            lst.AddFirst("3");
            lst.Insert(0, "0");

            Console.WriteLine(lst.ToString());

            MyLinkedList<string> ll = new MyLinkedList<string>();
            System.Console.WriteLine(ll);
            ll.AddFirst("a");
            ll.AddFirst("b");
            ll.AddFirst("c");
            ll.Insert(2, "x");
            System.Console.WriteLine(ll);
            try
            {
                ll.Insert(4, "kan niet");
            }
            catch (MyLinkedListIndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
            }

            ll.Clear();
            ll.AddFirst("a");
            ll.AddFirst("b");
            System.Console.WriteLine(ll.GetFirst());
            ll.RemoveFirst();
            System.Console.WriteLine(ll);
            ll.RemoveFirst();
            System.Console.WriteLine(ll);
        }

        static void BinaryTree()
        {
            System.Console.WriteLine("\n=====   BinaryTree   =====\n");

            IBinaryTree<int> intTree;
            IBinaryTree<string> stringTree;

            // Empty tree
            intTree = DSBuilder.CreateBinaryTreeEmpty();
            System.Console.WriteLine(intTree.Size());
            System.Console.WriteLine(intTree.Height());
            System.Console.WriteLine(intTree.ToPrefixString());
            System.Console.WriteLine(intTree.ToInfixString());
            System.Console.WriteLine(intTree.ToPostfixString());

            // Int tree
            intTree = DSBuilder.CreateBinaryTreeInt();
            System.Console.WriteLine(intTree.Size());
            System.Console.WriteLine(intTree.Height());
            System.Console.WriteLine(intTree.ToPrefixString());
            System.Console.WriteLine(intTree.ToInfixString());
            System.Console.WriteLine(intTree.ToPostfixString());
            System.Console.WriteLine(intTree.NumberOfNodesWithOneChild());

            // String tree
            stringTree = DSBuilder.CreateBinaryTreeString();
            System.Console.WriteLine(stringTree.Size());
            System.Console.WriteLine(stringTree.Height());
            System.Console.WriteLine(stringTree.ToPrefixString());
            System.Console.WriteLine(stringTree.ToInfixString());
            System.Console.WriteLine(stringTree.ToPostfixString());
        }

        static void BinarySearchTree()
        {
            System.Console.WriteLine("\n=====   BinarySearchTree   =====\n");

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
            System.Console.WriteLine("\n=====   PriorityQueue   =====\n");

            PriorityQueue<int> q = new PriorityQueue<int>();

            q.Add(10);
            q.Add(9);
            q.Add(8);
            q.Add(7);
            q.Add(6);
            q.Add(5);

            //q.array = new int[] { 0, 25, 21, 22, 18, 19, 40, 50, 17, 16 };
            //q.size = 9;

            Console.WriteLine(q.ToString());

            //q.PercolateDown(1);

            //Console.WriteLine(q.ToString());
        }

        static void Queue()
        {
            System.Console.WriteLine("\n=====   Queue   =====\n");

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
            System.Console.WriteLine("\n=====   Stack   =====\n");

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

        public static void FirstChildNextSibling()
        {
            System.Console.WriteLine("\n=====   FirstChildNextSibling   =====\n");

            IFirstChildNextSibling<string> tree;

            // Empty tree
            tree = DSBuilder.CreateFirstChildNextSibling_Empty();
            Console.WriteLine("Empty");
            tree.PrintPreOrder();
            System.Console.WriteLine("Size: {0}", tree.Size());
            System.Console.WriteLine(tree);

            // Small tree
            tree = DSBuilder.CreateFirstChildNextSibling_Small();
            Console.WriteLine("\nSmall");
            tree.PrintPreOrder();
            System.Console.WriteLine("Size: {0}", tree.Size());
            System.Console.WriteLine(tree);

            // Tree from figure 18.3
            tree = DSBuilder.CreateFirstChildNextSibling_18_3();
            Console.WriteLine("\n18_3");
            tree.PrintPreOrder();
            System.Console.WriteLine("Size: {0}", tree.Size());
            System.Console.WriteLine(tree);
        }

        public static void Graph()
        {
            System.Console.WriteLine("\n=====   Graph   =====\n");

            // Figuur 14.1 uit boek.
            Graph graph = DSBuilder.CreateGraph14_1();

            graph.Unweighted("V0");

            System.Console.WriteLine($"Unweighted\n{graph}\n");

            graph.Dijkstra("V0");

            System.Console.WriteLine($"Dijkstra\n{graph}\n");
            Console.WriteLine($"IsConnected: {graph.IsConnected()}");

            IGraph connectedGraph = DSBuilder.ConnectedGraph();
            connectedGraph.Dijkstra("V0");

            System.Console.WriteLine($"\nDijkstra\n{connectedGraph}\n");
            Console.WriteLine($"IsConnected: {connectedGraph.IsConnected()}");

        }


        static void Main(string[] args)
        {
            Factorial();
            Fibonacci();
            OmEnOm();
            Enen();
            ForwardString();
            Sorting();
            ArrayList();
            LinkedList();
            BinaryTree();
            BinarySearchTree();
            PriorityQueue();
            Queue();
            Stack();
            Graph();
            FirstChildNextSibling();

            Console.ReadKey();
        }
    }
}
