using System;

namespace _210731_A_Alloy
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            if (A > 0 || B > 0)
            {
                if (A == 0)
                {
                    Console.WriteLine("Silver");

                }
                else if (B == 0)
                {
                    Console.WriteLine("Gold");

                }
                else
                {
                    Console.WriteLine("Alloy");

                }
            }

            

        }
    }
}
