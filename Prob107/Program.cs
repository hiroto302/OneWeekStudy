using System;

// * を任意の数だけ横に並べて表示するプログラム
namespace Prob107
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("生成したい * の数を入力 : ");
            int n = int.Parse(Console.ReadLine());
            string [] stars = new string[n];
            for ( int i = 0; i < stars.Length; i++)
            {
                stars[i] = "* ";
                Console.Write(stars[i]);
            }
            Console.WriteLine();
            Console.WriteLine("{0}個生成しました", n);
        }
    }
}
