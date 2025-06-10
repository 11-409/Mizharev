namespace StackCastom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICharStack stack = new StackCastom(5);

            stack.Add('A');
            stack.Add('B');
            stack.Add('C');

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Delete());
            }
        }
    }
}
