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
            //N,Kの入力
            string[] input1 = Console.ReadLine().Split(' ');
            int N = int.Parse(input1[0]);
            int K = int.Parse(input1[1]);
            input1 = null;

            //Cの入力
            string[] input2 = Console.ReadLine().Split(' ');
            int[] C = new int[N];
            for(int i = 0; i <N; i++)
            {
                C[i]=(int.Parse(input2[i]));
            }
            input2 = null;

            //連想配列dictionaryにC[0~(K-1)]の種類数を格納する。
            //'1'が2つなら'2','2'が１つなら'1'をそれぞれkeyとvalueとする。
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i = 0; i < K; i++)
            {
                
                if (dic.ContainsKey(C[i])==false)//重複がなければ要素追加
                {
                    dic.Add(C[i], 1);
                }
                else if (dic.ContainsKey(C[i]))//重複があれば+1
                {
                    dic[C[i]]++;
                }
            }
            int ans = dic.Count;//種類数の初期化

            //尺取り探索を活用。
            for(int i = K; i < N; i++)
            {
                //C[i(K)]（次の要素）を探索
                if (dic.ContainsKey(C[i]) == false)
                {
                    dic.Add(C[i], 1);
                }
                else if (dic.ContainsKey(C[i]))
                {
                    dic[C[i]]++;
                }

                //C[i-K]（最後に探索した要素）を-1または削除
                if (dic.ContainsKey(C[i-K]) == true)
                {
                    dic[C[i - K]]--;
                    if (dic[C[i - K]] == 0)
                    {
                        dic.Remove(C[i - K]);
                    }

                }
                
                //最大値の更新
                ans = Math.Max(ans, (dic.Count));
            }


            Console.WriteLine(ans);

        }
    }
}
