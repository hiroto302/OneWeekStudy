using System;

// 整数値を5回入力させ、その値を全て表示し、その中の最大値・最小値を表示するプログラム
namespace EP306
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            // 最小値, 最大値の変数
            int min = 0;
            int max = 0;

            for (int i = 0; i < n.Length; i++)
            {
                // 数値の入力
                Console.Write("{0}回目 整数を入力 : ", i + 1);
                n[i] = int.Parse(Console.ReadLine());
                // 初期設定
                if(i == 0)
                {
                    min = n[0];
                    max = n[0];
                }
                // 値の更新
                else if(1 <= i)
                {
                    // 最大値の更新
                    if( max < n[i])
                    {
                        max = n[i];
                    }
                    // 最小値の更新
                    else if ( min > n[i])
                    {
                        min = n[i];
                    }
                }
            }
            // 値の出力
            foreach( int a in n)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("最大値 : {0}", max);
            Console.WriteLine("最小値 : {0}", min);
        }
    }
}
