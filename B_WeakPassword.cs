using System;

namespace _210731_B_WeakPassword
{
    class B_WeakPassword
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            int temp = input;
            int count = 0;
            int[] X = new int[4];

            while (temp > 0)
            {
                X[3-count] = (temp % 10);
                temp /= 10;
                count++;
            }

            bool all_same = false;
            bool stairs = false;

            if (X[0] == X[1])
            {
                if (X[1] == X[2])
                {
                    if (X[2] == X[3])
                    {
                        all_same = true;
                    }
                }
            }

            if (((X[0] + 1) % 10) == X[1]) 
            {
                if (((X[1] + 1) % 10) == X[2])
                {
                    if (((X[2] + 1) % 10) == X[3])
                    {
                        stairs = true;
                    }
                }

            }

            

            if (all_same == true || stairs == true)
            {
                Console.WriteLine("Weak");
            }
            else
            {
                Console.WriteLine("Strong");

            }

        }

    }
}
