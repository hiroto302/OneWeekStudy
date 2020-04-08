using System;

// 立方体の幅、奥行、高さを入力し、その体積を求めるプログラム
namespace Prob104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("各値を入力してください");
            double[] n = new double[3];
            for(int i = 0; i < n.Length ; i++)
            {
                if( i == 0)
                {
                    Console.Write("立方体の幅 : ");
                    n[i] = double.Parse(Console.ReadLine());
                }
                else if( i == 1)
                {
                    Console.Write("立方体の奥行き : ");
                    n[i] = double.Parse(Console.ReadLine());
                }
                else if( i == 2)
                {
                    Console.Write("立方体の高さの: ");
                    n[i] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("立方体の体積 = {0}", n[0] * n[1] * n[2]);
        }
    }
}
