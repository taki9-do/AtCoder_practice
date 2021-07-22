using System;

namespace _210718_A_ArithmeticSequence
{
    class A_ArithmeticSequence
    {
        static void Main(string[] args)
        {
            //オーバーフロー防ぐためdouble
            string[] input = Console.ReadLine().Split(' ');
            double A1 = double.Parse(input[0]);
            double A2 = double.Parse(input[1]);
            double A3 = double.Parse(input[2]);

            double count = 0;
            double ans = sub_1(A1, A2, A3);

            double temp = 0;

            if (ans < 0)
            {
                //小数点切り捨てはmath.floor
                temp = Math.Floor((1 - ans) / 2);
            }
            else if (ans >= 0)
            {
                temp = 0;
            }

            count = ans + 3 * temp;

            Console.WriteLine(count);
            
        }


        static double sub_1(double a1,double a2,double a3)
        {
           double ans = (2 * a2) - a1 - a3;

            return ans;
        }
    }
}
