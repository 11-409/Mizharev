namespace SumTreeElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreeNode head = new TreeNode(1);
            head.Left = new TreeNode(2);
            head.Right = new TreeNode(3);
            head.Left.Left = new TreeNode(4);
            head.Left.Right = new TreeNode(5);

            Console.WriteLine(TreeTools.GetSumOfElements(head));
        }
    }

    class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
        }
    }

    class TreeTools
    {
        public static int GetSumOfElements(TreeNode node)
        {
            if (node == null) return 0;
            return node.Value + GetSumOfElements(node.Left) + GetSumOfElements(node.Right);
        }
    }
}
