using System;
using System.Collections.Generic;
using System.Text;
using Huiswerk2;
using Huiswerk2.Ex5Queue;
using Huiswerk4;

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



    }
}
