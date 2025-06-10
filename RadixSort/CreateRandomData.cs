using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Radix_sort
{
    public class CreateRandomData
    {
        private static readonly Random random = new Random();
        private const string TestDataPath = "TestData";
        private const int MinSizeArray = 100;
        private const int MaxSizeArray = 10000;
        private const int CountTests = 50;
        public static void GenerateData()
        {
            if (!Directory.Exists(TestDataPath))
                Directory.CreateDirectory(TestDataPath);

            for (int i = 0; i < CountTests; i++)
            {
                int size = random.Next(MinSizeArray, MaxSizeArray + 1);
                int[] data = Enumerable.Range(0, size).Select(_ => random.Next(0, 100000)).ToArray();

                File.WriteAllText($"{TestDataPath}/dataset_{i}.txt", string.Join(" ", data));
            }
        }
        public static void RunTest()
        {
            foreach (var file in Directory.GetFiles(TestDataPath))
            {
                int[] data = File.ReadAllText(file).Split(' ').Select(int.Parse).ToArray();

                var watch = Stopwatch.StartNew();
                int[] radixSortArray = Radixsort.RadixSort(data);
                watch.Stop();
                double seconds = (new TimeSpan(watch.ElapsedTicks)).TotalSeconds;

                Console.WriteLine($"Файл: {Path.GetFileName(file)}");
                Console.WriteLine($"Количество входных данных:{data.Length}");
                Console.WriteLine($"Время; {seconds} секунд");
                Console.WriteLine($"Количество итераций: { Radixsort.TotalIterations}");
                Console.WriteLine($"Правильно ли отсортировано: {IsSorted(radixSortArray)}");
                Console.WriteLine("---------");
            }
        }
        private static bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1])
                    return false;
            return true;
        }
    }
}
