using System;
using System.Collections.Generic;
using System.Linq;

// 正の整数を入力させる。それ以外の数値を入力された時、それまで入力された正の整数を全て表示し、合計値、平均値、最大値、最小値を表示するプログラム
namespace EP601
{
    class Program
    {
        static void Main(string[] args)
        {
            // 正の整数を管理
            List<int> n = new List<int>();
            // 正数の入力
            while(true)
            {
                Console.Write("正の整数を入力 : ");
                int a = int.Parse(Console.ReadLine());
                // 判定 正数
                if(a > 0)
                {
                    n.Add(a);
                }
                else
                {
                    break;
                }
            }

            // 入力された正数の表示
            Console.WriteLine("入力された正数");
            foreach(int i in n)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 合計値, 平均値, 最大値, 最小値 の変数の初期化
            int sum = 0;
            int ave = 0;
            int max = n[0];
            int min = n[0];

            for(int i = 0; i < n.Count; i++)
            {
                sum += n[i];
                if(max < n[i])
                {
                    max = n[i];
                }
                else if(min > n[i])
                {
                    min = n[i];
                }
            }
            ave = sum / n.Count;

            // 結果の表示
            // Listで利用可能なメソッド　using.System.Linqを記述で利用可能
            // Console.WriteLine("合計値 : {0}", sum);
            Console.WriteLine("合計値 : {0}", n.Sum());
            // Console.WriteLine("平均値 : {0}", ave);
            Console.WriteLine("平均値 : {0}", n.Average());
            // Console.WriteLine("最大値 : {0}", max);
            Console.WriteLine("最大値 : {0}", n.Max());
            // Console.WriteLine("最小値 : {0}", min);
            Console.WriteLine("最小値 : {0}", n.Min());
        }
    }
}
