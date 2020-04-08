using System;

// 円の半径を0以上の実数値で入力し、その円の面積と円周の長さを表示するプログラム
// 円周率は3.14とすること
namespace Prob102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("円の半径を入力 : ");
            double r = double.Parse(Console.ReadLine());
            if( r > 0)
            {
                Console.WriteLine("面積 = {0}", r * r * 3.14);
                Console.WriteLine("円周 = {0}", r * 2.0 * 3.14);
            }
            else
            {
                Console.WriteLine("0以上の値を入力してください");
            }
        }
    }
}
