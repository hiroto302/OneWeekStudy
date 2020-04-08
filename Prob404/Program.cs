using System;

// 月を表す数値を入力させ、それに対応する月の名前を英語で表示するプログラム
namespace Prob404
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {"January", "February", "March", "April", "May", "June",
                                "July", "August","September", "October", "November", "December"};
            Console.Write("月(1~12)を入力してください : ");
            int m = int.Parse(Console.ReadLine());
            if( m >= 1 && m <= 12)
            {
                Console.WriteLine("{0}月は、英語で{1}", m, months[m - 1]);
            }
            else
            {
                Console.WriteLine("適切な値を入力せよ");
            }
        }
    }
}
