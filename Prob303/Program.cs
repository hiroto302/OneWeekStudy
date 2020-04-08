using System;

// 正の整数を入力し、その値から0までカウントダウンを表示するプログラム
namespace Prob303
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力してください : ");
            int n = int.Parse(Console.ReadLine());
            for ( int i = n; 0 <= i; i--)
            {
                Console.WriteLine(i);
            }
            // while(0 <= n)
            // {
            //     Console.WriteLine(n);
            //     n --;
            // }
        }
    }
}
