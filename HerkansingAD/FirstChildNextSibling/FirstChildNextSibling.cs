using System;
using System.Collections.Generic;
using System.Text;

namespace Huiswerk4
{
    public class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FCNSNode<T> root;

        public int Size()
        {
            return Size(root);

            int Size(FCNSNode<T> node)
            {
                if (node == null) return 0;

                return 1 + Size(node.firstChild) + Size(node.nextSibling);
            }
        }

        public void PrintPreOrder()
        {
            if (root == null)
            {
                return;
            }

            string preOrderString = "";
            int whiteSpace = 1;

            PrintPreOrder(root, 1);
            Console.WriteLine(preOrderString);

            void PrintPreOrder(FCNSNode<T> node, int space)
            {
                while (true)
                {
                    if (node == null) return;

                    preOrderString += $"{node.data.ToString().PadLeft(whiteSpace)}\n";

                    // set whitespace
                    whiteSpace += 3;

                    PrintPreOrder(node.firstChild, whiteSpace);

                    // set whitespace to the last known space
                    whiteSpace = space;
                    node = node.nextSibling;
                }
            }
        }

        public override string ToString()
        {
            if (root == null) return "NIL";

            StringBuilder print = new StringBuilder();
            int parentheses = 0;

            BuildString(root);

            return print.ToString();

            void BuildString(FCNSNode<T> node)
            {
                if (node == null) return;

                print.Append(node.data);

                // first child
                if (node.firstChild != null) print.Append(",FC(");
                BuildString(node.firstChild);

                // next sibling
                if (node.nextSibling != null) print.Append(",NS(");
                BuildString(node.nextSibling);

                // add )
                parentheses++;
                if (parentheses < Size()) print.Append(")");
            }
        }
    }
}