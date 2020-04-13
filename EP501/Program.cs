using System;

// 静的メンバであるメソッドMul,Div(掛け算、割り算)を追加し、入力された2つの数値の四則演算の結果を表示するプログラム
namespace EP501
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("二つの数値を入力してください");
            Console.Write("一つ目 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("二つ目 : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("四則演算の結果");
            Console.WriteLine("足し算 : {0}", Program.Add(a, b));
            // 同じクラスであるとき、クラス名を省力可
            Console.WriteLine("足し算 : {0}", Add(a, b));
            Console.WriteLine("引き算 : {0}", Program.Sub(a, b));
            Console.WriteLine("掛け算 : {0}", Program.Mul(a, b));
            Console.WriteLine("割り算 : {0}", Program.Div(a, b));

        }
    }
}
