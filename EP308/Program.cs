using System;

// 1から100までの乱数を10個生成し、それらを表示し、大きい順にならべかえるプログラム。
namespace EP308
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] n = new int[10];
            

            for ( int i = 0; i < n.Length; i++)
            {
                n[i] = random.Next(101);
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();

            // 数値の並べ替え
            // 最大値を表示する処理を10回繰り返す
            for (int i = 0; i < n.Length; i++)
            {
                // 変数の初期化　下記の2つはここで初期化すること
                int max = 0;    // 仮の最大値
                int pos = 0;    // 仮の最大値の位置
                // 既存の配列の最大値と位置の取得
                for( int j = 0; j < n.Length; j++)
                {
                    // 既存の最大値と位置の取得
                    if(max < n[j])
                    {
                        max = n[j];
                        pos = j;
                    }
                }
                // 表示した最大値を0にする
                Console.WriteLine(max);
                n[pos] = 0;
            }


        }
    }
}
