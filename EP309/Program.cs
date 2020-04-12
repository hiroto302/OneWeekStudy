using System;

// 1~99までの乱数を10個生成 それぞれの範囲に該当する数を全て列挙するプログラム
namespace EP309
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] n = new int[10];
            for(int i = 0; i < n.Length; i++)
            {
                n[i] = random.Next(1, 100);
            }

            // 20毎の区分を5回繰り返して表示する
            int count = 20;
            for( int i = 0; i < 100; i += count)
            {
                Console.Write("{0}以上{1}未満 : ", i, i + count);
                foreach(int a in n)
                {
                    if(i < a && a < i + count )
                    {
                        Console.Write(a + " ");
                    }
                }
                Console.WriteLine();
            }
            // for(int i = 0; i < 2; i++)
            // {
            //     if(i == 0)
            //     {
            //         Console.Write("0以上50未満 : ");
            //         for(int j = 0; j < n.Length; j++)
            //         {
            //             if( n[j] < 50 && n[j] >= 0)
            //             {
            //                 Console.Write(n[j] + " ");
            //             }
            //         }
            //         Console.WriteLine();
            //     }
            //     else if (i == 1)
            //     {
            //         Console.Write("50以上100未満 : ");
            //         for(int j = 0; j < n.Length; j++)
            //         {
            //             if( n[j] < 100 && n[j] >= 50)
            //             {
            //                 Console.Write(n[j] + " ");
            //             }
            //         }
            //         Console.WriteLine();
            //     }
            // }
        }
    }
}
