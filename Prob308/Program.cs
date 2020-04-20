using System;

// 1~100までの素数を全て表示するプログラム　
// 素数 1より大きい自然数 かつ １とその自身の以外の約数がない正数
namespace Prob308
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2~100までの数に対して下記の処理を実行
            for(int i = 2; i < 101; i++)
            {
                // 約数の数
                int num = 0;
                for(int j = i; j > 1; j--)
                {
                    int divisor = i % j;
                    // 約数の判定
                    if(divisor == 0)
                    {
                        // 約数の個数増加
                        num++;
                    }
                }
                // 素数の判定
                if(num == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
