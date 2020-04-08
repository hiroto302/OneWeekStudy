using System;

// 3つの実数値を入力し、その和と平均を求めるプログラム
namespace Prob103
{
    class Program
    {
        static void Main(string[] args)
        {
            // double a, b, c;
            // Console.WriteLine("3つの数値を入力");
            // Console.Write("1つ目 : ");
            // a = double.Parse(Console.ReadLine());
            // Console.Write("2つ目 : ");
            // b = double.Parse(Console.ReadLine());
            // Console.Write("3つ目 : ");
            // c = double.Parse(Console.ReadLine());

            // Console.WriteLine("和 = {0}", a + b + c);
            // Console.WriteLine("平均値 = {0}", (a + b + c) / 3.0);

            // 上記を配列を用いて記述
            Console.WriteLine("3つの数値を入力");
            double[] n = new double[3];
            double total = 0;
            for(int i = 0; i < n.Length ; i++)
            {
                Console.Write("{0}つ目の値 : ", i + 1);
                n[i] = double.Parse(Console.ReadLine());
                total += n[i];
            }
            Console.WriteLine("和 = {0}", total);
            Console.WriteLine("平均値 = {0}", total / 3.0);
        }
    }
}
