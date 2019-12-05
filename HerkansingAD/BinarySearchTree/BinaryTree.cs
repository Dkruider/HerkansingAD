namespace Huiswerk5
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;
        private int _height;

        //----------------------------------------------------------------------
        // Cunstructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>(rootItem, null, null);
        }

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            if (root == null) throw new BinarySearchTreeEmptyException();

            return root;
        }

        public int Size()
        {
            return root == null ? 0 : GetSize(root);

            // local function for recursive https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions
            int GetSize(BinaryNode<T> n)
            {
                if (n == null) return 0;

                return 1 + GetSize(n.left) + GetSize(n.right);
            }
        }

        public int Height()
        {
            return root == null ? -1 : GetHeight(root, 0);

            // local function for recursive
            int GetHeight(BinaryNode<T> node, int n)
            {
                if (node == null) return 0;

                if (n > _height) _height = n;

                GetHeight(node.left, n + 1);
                GetHeight(node.right, n + 1);

                return _height;
            }
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            BinaryNode<T> left = null;
            BinaryNode<T> right = null;

            if (t1 != null)
            {
                left = t1.GetRoot();
            }

            if (t2 != null)
            {
                right = t2.GetRoot();
            }

            root = new BinaryNode<T>(rootItem, left, right);
        }

        public string ToPrefixString()
        {
            return root == null ? "NIL" : PrefixString(root).TrimEnd();

            // local function for recursive
            string PrefixString(BinaryNode<T> node)
            {
                if (node == null) return "NIL ";

                return "[ " + node.data + " " + PrefixString(node.left) + PrefixString(node.right) + "] ";
            }
        }

        public string ToInfixString()
        {
            return root == null ? "NIL" : InfixString(root).TrimEnd();

            // local function for recursive
            string InfixString(BinaryNode<T> node)
            {
                if (node == null) return "NIL ";

                return "[ " + InfixString(node.left) + node.data + " " + InfixString(node.right) + "] ";
            }
        }

        public string ToPostfixString()
        {
            return root == null ? "NIL" : PostfixString(root).TrimEnd();

            // local function for recursive
            string PostfixString(BinaryNode<T> node)
            {
                if (node == null) return "NIL ";

                return "[ " + PostfixString(node.left) + PostfixString(node.right) + node.data + " " + "] ";
            }
        }

        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            return root == null ? 0 : GetNumberOfLeaves(root);

            // local function for recursive
            int GetNumberOfLeaves(BinaryNode<T> node)
            {
                if (node == null) return 0;

                if (node.left == null && node.right == null) return 1;

                return GetNumberOfLeaves(node.left) + GetNumberOfLeaves(node.right);
            }
        }

        public int NumberOfNodesWithOneChild()
        {
            return root == null ? 0 : GetNumberOfNodesWithOneChild(root);

            // local function for recursive
            int GetNumberOfNodesWithOneChild(BinaryNode<T> node)
            {
                if (node == null) return 0;

                int count = 0;

                if (node.left != null && node.right == null || node.left == null && node.right != null) count++;

                return count + GetNumberOfNodesWithOneChild(node.left) + GetNumberOfNodesWithOneChild(node.right);
            }
        }

        public int NumberOfNodesWithTwoChildren()
        {
            return root == null ? 0 : GetNumberOfNodesWithTwoChildren(root);

            // local function for recursive 
            int GetNumberOfNodesWithTwoChildren(BinaryNode<T> node)
            {
                if (node == null) return 0;

                int count = 0;

                if (node.left != null && node.right != null) count++;

                return count + GetNumberOfNodesWithTwoChildren(node.left) + GetNumberOfNodesWithTwoChildren(node.right);
            }
        }


    }
}