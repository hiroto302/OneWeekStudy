using System;

//正の正数を入力し、その数以下の2, 3, 5 の倍数を全て表示するプログラム
namespace Prob304
{
    class Program
    {
        // 第一引数の値の、第二引数の倍数に当てはまる整数を表示するメソッド
        static void Answer(int inputNum, int multiple)
        {
            Console.WriteLine("{0}の倍数", multiple);
            for(int i = inputNum; 0 < i; i--)
                {
                    int a = i % multiple;
                    if(a == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("正数を入力 : ");
                    int n = int.Parse(Console.ReadLine());
                    if(n > 1)
                    {
                        Answer(n, 2);
                        Answer(n, 3);
                        Answer(n, 5);
                        Console.WriteLine("終了");
                        break;
                    }
                    else if(n == 1)
                    {
                        Console.WriteLine("1の倍数は1のみ");
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                // 整数かつ正数以外が入力された時呼ばれる処理
                catch(FormatException)
                {
                    Console.WriteLine("適切な値を入力せよ");
                }
            }

        }
    }
}
