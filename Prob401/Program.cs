using System;

// 乱数を1~10を生成し、配列の要素を６つに代入する。その配列の要素を表示するプログラム。
namespace Prob401
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rundom = new Random();
            int[] num = new int[6];
            for(int i = 0; i < num.Length; i++)
            {
                int rundomNum = rundom.Next(1, 11);
                num[i] = rundomNum;
                Console.WriteLine("num[{0}] = {1}", i, num[i]);
            }
        }
    }
}
