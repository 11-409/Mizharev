using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BinarySearchTree
    {
        private Node root;

        public Node Root
        {
            get { return root; }
            set { root = value; }
        }

        public BinarySearchTree(Node node = null)
        {
            Root = node;
        }

        public bool Search(int target, Node node = null)
        {
            if (node == null)
                node = Root;

            if (node == null)
                return false;

            if (node.Data == target)
                return true;

            if (node.Data > target)
                return Search(target, node.Left);
            else
                return Search(target, node.Right);
        }
        public void Add(int value, ref Node nodeRef)
        {
            if (nodeRef == null)
            {
                nodeRef = new Node(value);
                return;
            }

            if (value < nodeRef.Data)
                Add(value, ref nodeRef.Left);
            else if (value > nodeRef.Data)
                Add(value, ref nodeRef.Right);
        }
        public void Add(int value)
        {
            Add(value, ref root);
        }
    }
}
