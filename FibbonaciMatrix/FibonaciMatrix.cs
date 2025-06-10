using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Число_фибоначчи
{
    public class FibonaciMatrix
    {
        public static void MultiplyMatrix(int[,] A, int[,] B)
        {
            int a = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
            int b = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
            int c = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            int d = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];
            A[0, 0] = a;
            A[0, 1] = b;
            A[1, 0] = c;
            A[1, 1] = d;
        }
        public static void PowerMatrix(int[,] A, int n)
        {
            int[,] X = { { 1, 1 }, { 1, 0 } };
            if (n == 0 || n == 1)
                return;

            PowerMatrix(A, n / 2);
            MultiplyMatrix(A, A);

            if (n % 2 != 0)
               MultiplyMatrix(A, X);
        }
        public static int FindFibonaciNum(int n)
        {
            if (n == 0)
                return 0;
            int[,] A = { { 1, 1 }, { 1, 0 } };
            PowerMatrix(A, n - 1);

            return A[0, 0];
        }
    }
}
