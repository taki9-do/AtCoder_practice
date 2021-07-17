using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace _210717_C_ColorfulCandies
{
    class C_ColorfulCandies
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            int N = int.Parse(input1[0]);
            int K = int.Parse(input1[1]);
            input1 = null;

            string[] input2 = Console.ReadLine().Split(' ');
            List<int> C = new List<int>();
            for(int i = 0; i < input2.Length; i++)
            {
                C.Add(int.Parse(input2[i]));
            }
            input2 = null;

            List<int> count = new List<int>();
            List<int> count2 = new List<int>();


            for (int j=0;j<(N - K + 1); j++)
            {
                for (int i = 0; i < K; i++)
                {
                    count.Add(C[j + i]);
                }

                IEnumerable<int> temp = count.Distinct();
                count2.Add(temp.Count());

                count.Clear();
                temp = null;
            }

            Console.WriteLine(count2.Max());

            

        }
    }
}
