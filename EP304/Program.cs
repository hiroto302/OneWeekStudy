using System;

// 1 ~ 100 までの乱数を10回発生させる。そのうちの最大値を最小値を表示させるプログラム
namespace EP304
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            max = 0;
            min = 101;
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                int n = random.Next(101);
                Console.Write(n + " ,");
                if(max < n)
                {
                    max = n;
                }
                else if(min > n)
                {
                    min = n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値 : {0}", max);
            Console.WriteLine("最小値 : {0}", min);
        }
    }
}
