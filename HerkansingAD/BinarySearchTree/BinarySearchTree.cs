using System;

namespace Huiswerk5
{
    public class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : System.IComparable<T>
    {

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x)
        {
            BinaryNode<T> newNode = new BinaryNode<T>(x, null, null);

            if (root == null)
            {
                root = newNode;
                return;
            }

            BinaryNode<T> current = root;
            BinaryNode<T> parent = root;

            while (current != null)
            {
                parent = current;
                int compare = newNode.data.CompareTo(current.data);

                switch (compare)
                {
                    case 1:
                        current = current.right;
                        break;
                    case -1:
                        current = current.left;
                        break;
                    case 0:
                        throw new BinarySearchTreeDoubleKeyException();
                }
            }

            if (newNode.data.CompareTo(parent.data) == 1) parent.right = newNode;
            else parent.left = newNode;
        }


        public T FindMin()
        {
            if (root == null) throw new BinarySearchTreeEmptyException();

            BinaryNode<T> current = root;

            while (current.left != null)
            {
                current = current.left;
            }

            return current.data;
        }

        public T FindMax()
        {
            if (root == null) throw new BinarySearchTreeEmptyException();

            BinaryNode<T> current = root;

            while (current.right != null)
            {
                current = current.right;
            }

            return current.data;
        }

        public void RemoveMin()
        {
            Remove(FindMin());
        }

        public Tuple<BinaryNode<T>, BinaryNode<T>> GetNode(T x)
        {
            BinaryNode<T> current = root;
            BinaryNode<T> parent = current;

            int compare = x.CompareTo(current.data);

            while (compare != 0)
            {
                parent = current;

                switch (compare)
                {
                    case -1:
                        current = current.left;
                        break;
                    case 1:
                        current = current.right;
                        break;
                }

                // check if key actually exists
                if (current != null)
                {
                    compare = x.CompareTo(current.data);
                }
                else
                {
                    throw new BinarySearchTreeElementNotFoundException();
                }
            }

            return Tuple.Create(current, parent);
        }

        public void Remove(T x)
        {
            if (root == null) throw new BinarySearchTreeElementNotFoundException();

            int compare = x.CompareTo(root.data);

            // check if x is root
            if (compare == 0)
            {
                root = null;
                return;
            }

            // get the node you want to delete including the parent
            BinaryNode<T> nodeToDelete = GetNode(x).Item1;
            BinaryNode<T> parent = GetNode(x).Item2;

            // if current has no children
            if (nodeToDelete.left == null && nodeToDelete.right == null)
            {
                compare = nodeToDelete.data.CompareTo(parent.data);

                if (compare == -1) parent.left = null;
                if (compare == 1) parent.right = null;
                return;
            }

            // if current has 1 child
            if (nodeToDelete.left != null && nodeToDelete.right == null || nodeToDelete.left == null && nodeToDelete.right != null)
            {
                BinaryNode<T> newChild = null;

                // find if child is left or right child
                if (nodeToDelete.left != null) newChild = nodeToDelete.left;
                if (nodeToDelete.right != null) newChild = nodeToDelete.right;

                // check if newChild is left or right child
                compare = nodeToDelete.data.CompareTo(parent.data);
                if (compare == -1) parent.left = newChild;
                if (compare == 1) parent.right = newChild;
                return;
            }

            // if current has 2 children
            if (nodeToDelete.left != null && nodeToDelete.right != null)
            {
                BinaryNode<T> findMin = nodeToDelete.right;

                while (findMin.left != null)
                {
                    parent = findMin;
                    findMin = findMin.left;
                }

                // replace current find min value
                nodeToDelete.data = findMin.data;

                // clear parent left
                parent.left = null;
            }
        }

        public string InOrder()
        {
            return root == null ? "" : InOrder(root).TrimEnd();

            string InOrder(BinaryNode<T> node)
            {
                if (node == null) return "";

                return InOrder(node.left) + $"{node.data} " + InOrder(node.right);
            }
        }

        public override string ToString()
        {
            return InOrder();
        }
    }
}
