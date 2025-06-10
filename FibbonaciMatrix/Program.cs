namespace Число_фибоначчи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число Фибоначи");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonaciMatrix.FindFibonaciNum(n));
        }
    }
}
