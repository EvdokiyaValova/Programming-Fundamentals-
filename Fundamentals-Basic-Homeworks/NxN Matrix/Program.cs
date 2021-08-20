using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            MatrixN(n);
        }

        private static void MatrixN(int n)
        {
            int[,] matrixN = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixN[i, j] = n;
                    Console.Write(matrixN[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
