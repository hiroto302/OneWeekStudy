using System;

//コンソールから入力された2つの整数の和を表示するプログラム
namespace EP201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b = {0}", a + b);
        }
    }
}
