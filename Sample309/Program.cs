using System;

namespace Sample309
{
    class Program
    {
        static void Main(string[] args)
        {
            // 多次元配列(二次元配列)の生成 縦3 ✖️ 横4
            int[,] a = new int[3, 4];
            int m, n;
            // 二次元配列に値を代入
            for(m = 0; m < 3; m++)
            {
                for(n = 0; n < 4; n++)
                {
                    // 2次元配列の各要素に値を代入
                    a[m, n] = m + n;
                }
            }
            // 二次元配列に値を出力
            for (m = 0; m < 3; m++)
            {
                for(n = 0; n < 4; n++)
                {
                    Console.Write("a[{0},{1}]={2} ", m, n, a[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}
