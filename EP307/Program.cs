using System;

// 1~100までの乱数を発生させランダムに10個生成する。生成した数値を偶数と奇数に分けて表示させるプログラム
namespace EP307
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            int i = 0;
            while(i < numbers.Length)
            {
                int num = rnd.Next(1,101);
                numbers[i] = num;
                i++;
            }

            string[] names = {"偶数", "奇数"};
            for(int n = 0; n < names.Length; n++)
            {
                Console.WriteLine(names[n]);
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[j] % 2 == n)
                    {
                        Console.WriteLine(numbers[j]);
                    }
                }
            }

            // 助長なので上記に修正
            // Console.WriteLine("偶数を表示");
            // for(int e = 0; e <numbers.Length; e++)
            // {
            //     if(numbers[e] % 2 == 0)
            //     {
            //         Console.WriteLine(numbers[e]);
            //     }
            // }
            // Console.WriteLine("奇数を表示");
            // for(int o = 0; o <numbers.Length; o++)
            // {
            //     if(numbers[o] % 2 == 1)
            //     {
            //         Console.WriteLine(numbers[o]);
            //     }
            // }
        }
    }
}