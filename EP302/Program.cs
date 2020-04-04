using System;

// キーボードから正の整数を入力させ、その数値の約数(割り切ることできる数)を全て表示させるプログラム
namespace EP302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正数を入力 : ");
            var n = float.Parse(Console.ReadLine());
            // 整数の判定式
            var m = n / Math.Floor(n);

            // 正数かつ整数の判定
            if(0 < n　&& m == 1)
            {
                for(int i = (int)n; 0 < i; i--)
                {
                    // 約数の判定
                    if(n % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("適切な数値を入力してください");
            }
        }
    }
}
