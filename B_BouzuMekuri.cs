using System;

namespace _210717_B_BouzuMekuri
{
    class B_BouzuMekuri
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[] array_S = new char[N];
            string S = Console.ReadLine();
            array_S = S.ToCharArray();

            for(int i = 0; i < N; i++)
            {
                if (array_S[i].ToString() == "1")
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("Takahashi");
                        break;
                    }
                    else if ((i % 2) == 1)
                    {
                        Console.WriteLine("Aoki");
                        break;
                    }


                }
            }
        }
    }
}
