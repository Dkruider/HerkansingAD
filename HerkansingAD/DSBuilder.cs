using System;
using System.Collections.Generic;
using System.Text;
using Huiswerk2;
using Huiswerk2.Ex5Queue;
using Huiswerk4;
using Huiswerk5;
using Huiswerk6;

namespace HerkansingAD
{
    public class DSBuilder
    {

        // ArrayList
        public static IMyArrayList CreateMyArrayList()
        {
            return new MyArrayList(5);
        }

        // LinkedList
        public static IMyLinkedList<string> CreateMyLinkedList()
        {
            return new MyLinkedList<string>();
        }

        // Stack
        public static IMyStack<string> CreateMyStack()
        {
            return new MyStack<string>();
        }

        public static IMyStack<int> CreateMyArrayListStack()
        {
            return new MyArrayListStack<int>();
        }

        // Queue
        public static IMyQueue<string> CreateMyQueue()
        {
            return new MyQueue<string>();
        }

        public static IMyQueue<string> CreateMyArrayQueue()
        {
            return new MyArrayQueue<string>();
        }


        // FirstChildNextSibling
        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Empty()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string>();
            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Small()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string>();

            FCNSNode<string> d = new FCNSNode<string>("d");
            FCNSNode<string> c = new FCNSNode<string>("c");
            FCNSNode<string> b = new FCNSNode<string>("b", d, c);
            FCNSNode<string> a = new FCNSNode<string>("a", b, null);

            tree.root = a;

            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_18_3()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string>();

            FCNSNode<string> k = new FCNSNode<string>("k", null, null);
            FCNSNode<string> j = new FCNSNode<string>("j", k, null);
            FCNSNode<string> i = new FCNSNode<string>("i", null, j);
            FCNSNode<string> h = new FCNSNode<string>("h", null, null);
            FCNSNode<string> g = new FCNSNode<string>("g", null, null);
            FCNSNode<string> f = new FCNSNode<string>("f", null, g);
            FCNSNode<string> e = new FCNSNode<string>("e", i, null);
            FCNSNode<string> d = new FCNSNode<string>("d", h, e);
            FCNSNode<string> c = new FCNSNode<string>("c", null, d);
            FCNSNode<string> b = new FCNSNode<string>("b", f, c);
            FCNSNode<string> a = new FCNSNode<string>("a", b, null);

            tree.root = a;

            return tree;
        }

        // BinaryTree
        public static IBinaryTree<int> CreateBinaryTreeEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            return tree;
        }

        //
        //         5
        //       /   \
        //     2       6
        //    / \
        //   8   7
        //      /
        //     1
        //
        public static IBinaryTree<int> CreateBinaryTreeInt()
        {
            BinaryTree<int> t8 = new BinaryTree<int>(8);
            BinaryTree<int> t1 = new BinaryTree<int>(1);
            BinaryTree<int> t6 = new BinaryTree<int>(6);

            BinaryTree<int> t7 = new BinaryTree<int>();
            BinaryTree<int> t2 = new BinaryTree<int>();
            BinaryTree<int> t5 = new BinaryTree<int>();


            t7.Merge(7, t1, null);
            t2.Merge(2, t8, t7);
            t5.Merge(5, t2, t6);

            return t5;
        }

        //
        //         t
        //       /   \
        //     w       a
        //    / \     / \
        //   q   g   o   p
        public static IBinaryTree<string> CreateBinaryTreeString()
        {
            BinaryTree<string> tq = new BinaryTree<string>("q");
            BinaryTree<string> tg = new BinaryTree<string>("g");
            BinaryTree<string> to = new BinaryTree<string>("o");
            BinaryTree<string> tp = new BinaryTree<string>("p");
            BinaryTree<string> tw = new BinaryTree<string>();
            BinaryTree<string> tt = new BinaryTree<string>();
            BinaryTree<string> ta = new BinaryTree<string>();

            tw.Merge("w", tq, tg);
            ta.Merge("a", to, tp);
            tt.Merge("t", tw, ta);

            return tt;
        }

        // BinarySearchTree
        public static IBinarySearchTree<int> CreateBinarySearchTreeIntEmpty()
        {
            BinarySearchTree<int> t = new BinarySearchTree<int>();
            return t;
        }

        public static IBinarySearchTree<int> CreateBinarySearchTreeInt1Element()
        {
            BinaryNode<int> t4 = new BinaryNode<int>(4, null, null);

            BinarySearchTree<int> t = new BinarySearchTree<int>();
            t.root = t4;
            return t;
        }

        //
        //         6
        //       /   \
        //     4       7
        //    / \
        //   2   5
        //
        public static IBinarySearchTree<int> CreateBinarySearchTreeIntSmall()
        {
            BinaryNode<int> t2 = new BinaryNode<int>(2, null, null);
            BinaryNode<int> t5 = new BinaryNode<int>(5, null, null);
            BinaryNode<int> t7 = new BinaryNode<int>(7, null, null);
            BinaryNode<int> t4 = new BinaryNode<int>(4, t2, t5);
            BinaryNode<int> t6 = new BinaryNode<int>(6, t4, t7);

            BinarySearchTree<int> t = new BinarySearchTree<int>();
            t.root = t6;
            return t;
        }
        public static IBinarySearchTree<int> CreateBinarySearchTreeIntModerate()
        {
            BinaryNode<int> t7 = new BinaryNode<int>(7, null, null);
            BinaryNode<int> t12 = new BinaryNode<int>(12, null, null);
            BinaryNode<int> t24 = new BinaryNode<int>(24, null, null);
            BinaryNode<int> t37 = new BinaryNode<int>(37, null, null);
            BinaryNode<int> t50 = new BinaryNode<int>(50, null, null);
            BinaryNode<int> t8 = new BinaryNode<int>(8, t7, t12);
            BinaryNode<int> t3 = new BinaryNode<int>(3, null, t8);
            BinaryNode<int> t42 = new BinaryNode<int>(42, t37, null);
            BinaryNode<int> t34 = new BinaryNode<int>(34, null, t42);
            BinaryNode<int> t45 = new BinaryNode<int>(45, t34, t50);
            BinaryNode<int> t32 = new BinaryNode<int>(32, null, t45);
            BinaryNode<int> t26 = new BinaryNode<int>(26, t24, t32);
            BinaryNode<int> t17 = new BinaryNode<int>(17, t3, t26);

            BinarySearchTree<int> t = new BinarySearchTree<int>();
            t.root = t17;
            return t;
        }

        // PriorityQueue
        public static IPriorityQueue<int> CreatePriorityQueueEmpty()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();
            return q;
        }

        //
        //          1
        //        /   \
        //      3       5
        //     /
        //    4
        //
        public static IPriorityQueue<int> CreatePriorityQueueSmall()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();

            q.array = new int[] { 0, 1, 3, 5, 4 };
            q.size = 4;

            return q;
        }

        //
        //          2
        //        /   \
        //      4       2
        //     / \     / \
        //    7   5   5   6
        //   / \
        //  8   9
        //
        public static IPriorityQueue<int> CreatePriorityQueueModerate()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();

            q.array = new int[] { 0, 2, 4, 2, 7, 5, 5, 6, 8, 9 };
            q.size = 9;

            return q;
        }

        public static IPriorityQueue<int> CreatePriorityQueueFull()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();
            System.Random r = new System.Random();

            for (int i = 0; i < PriorityQueue<int>.DEFAULT_CAPACITY; i++)
                q.Add(r.Next(PriorityQueue<int>.DEFAULT_CAPACITY * 3));
            q.size = PriorityQueue<int>.DEFAULT_CAPACITY;

            return q;
        }

        // Graph
        public static IGraph CreateGraphEmpty()
        {
            return new Graph();
        }

        public static Graph CreateGraph14_1()
        {
            Graph graph = new Graph();

            graph.GetVertex("V0");
            graph.GetVertex("V1");
            graph.GetVertex("V2");
            graph.GetVertex("V3");
            graph.GetVertex("V4");
            graph.GetVertex("V5");
            graph.GetVertex("V6");
            graph.AddEdge("V0", "V1", 2);
            graph.AddEdge("V0", "V3", 1);
            graph.AddEdge("V1", "V3", 3);
            graph.AddEdge("V1", "V4", 10);
            graph.AddEdge("V3", "V2", 2);
            graph.AddEdge("V3", "V5", 8);
            graph.AddEdge("V3", "V6", 4);
            graph.AddEdge("V3", "V4", 2);
            graph.AddEdge("V2", "V0", 4);
            graph.AddEdge("V2", "V5", 5);
            graph.AddEdge("V4", "V6", 6);
            graph.AddEdge("V6", "V5", 1);

            return graph;
        }

        public static Graph CreateGraph()
        {
            Graph graph = new Graph();

            graph.GetVertex("V0");
            graph.GetVertex("V1");
            graph.GetVertex("V2");
            graph.GetVertex("V3");
            graph.GetVertex("V4");
            graph.GetVertex("V5");
            graph.GetVertex("V6");
            graph.AddEdge("V0", "V1", 2);
            graph.AddEdge("V0", "V3", 1);
            graph.AddEdge("V1", "V3", 3);
            graph.AddEdge("V1", "V4", 10);
            graph.AddEdge("V3", "V2", 2);
            graph.AddEdge("V3", "V5", 8);
            //graph.AddEdge("V3", "V6", 4);
            graph.AddEdge("V3", "V4", 2);
            graph.AddEdge("V2", "V0", 4);
            graph.AddEdge("V2", "V5", 5);
            //graph.AddEdge("V4", "V6", 6);
            graph.AddEdge("V6", "V5", 1);

            return graph;
        }

        public static Graph ConnectedGraph()
        {
            Graph graph = new Graph();

            graph.GetVertex("V0");
            graph.GetVertex("V1");
            graph.GetVertex("V2");
            graph.GetVertex("V3");

            graph.AddEdge("V0", "V1", 2);
            graph.AddEdge("V1", "V2", 1);
            graph.AddEdge("V2", "V3", 3);
            graph.AddEdge("V3", "V0", 10);

            return graph;
        }



    }
}
