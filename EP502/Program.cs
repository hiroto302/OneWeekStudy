using System;

// 入力された数値の三角関数の計算結果を表示するプログラム
// Mathクラスの利用 数学の処理の静的メンバがまとめられている
namespace EP502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("角度を入力 : ");
            double angle = double.Parse(Console.ReadLine());
            // 角度を弧度法に変換
            double rad = Math.PI * angle / 180.0;
            // 入力した角度のsin, cos, tan の表示
            Console.WriteLine("sin{0} = {1}", angle, Math.Sin(rad));
            Console.WriteLine("cos{0} = {1}", angle, Math.Cos(rad));
            Console.WriteLine("tan{0} = {1}", angle, Math.Tan(rad));
        }
    }
}
