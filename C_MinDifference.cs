using System;
using System.Collections.Generic;

namespace _210731_C_MinDifference
{
    class C_MinDifference
    {
        static void Main(string[] args)
        {

            //配列の長さの入力
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            //配列Aの入力
            int[] A = new int[N];
            string[] input1 = Console.ReadLine().Split(' ');
            for(int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(input1[i]);
            }

            //配列Bへの入力
            int[] B = new int[M];
            string[] input2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = int.Parse(input2[i]);
            }

            //配列のソート
            Array.Sort(A);
            Array.Sort(B);

            int min = 1010000000;

            int ai = 0, bi = 0;

            while (ai < N && bi < M)
            {
                min = Math.Min(min, Math.Abs(A[ai] - B[bi]));
                if (A[ai] < B[bi]) ai++;
                else bi++;
            }

            Console.WriteLine(min);

        }
    }
}
