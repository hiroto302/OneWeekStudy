using System;

// 自分の名前を表示するプログラム
namespace Prob101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("名前を入力 : ");
            string name = Console.ReadLine();
            Console.WriteLine("俺の名前は、{0}です", name);
        }
    }
}
