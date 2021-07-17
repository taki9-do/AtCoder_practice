using System;

namespace _210717_1_cabbages
{
    class A_cabbeges
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int A = int.Parse(input[1]);
            int X = int.Parse(input[2]);
            int Y = int.Parse(input[3]);

            int sum = 0;

            for(int i = 0; i < N; i++)
            {
                if (i < A)
                {
                    sum += X;
                }
                else if (i >= A)
                {
                    sum += Y;
                }
            }

            Console.Write(sum);

        }
    }
}
