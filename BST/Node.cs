using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Node
    {
        public int Data { get; set; }
        public Node Right;
        public Node Left;

        public Node(int value)
        {
            Data = value;
            Right = null;
            Left = null;
        }
    }
}
