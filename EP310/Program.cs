using System;

// 5*5の二次元配列に置いて、乱数で発生させた「場所に」1~25の値を配置し、内容を表示するプログラム
// 値を表示する場所,代入する値は重複しないこと
namespace EP310
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5*5の二次元配列作成
            const int SIZE = 5;
            int[,] data = new int[SIZE, SIZE];
            // 値0を代入し初期化
            for(int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = 0;
                }
            }

            Random random = new Random();
            // 配列に代入する値
            int num = 1;

            while(num <= SIZE*SIZE)
            {
                // 数値を置く位置の決定
                int m = random.Next(SIZE);
                int n = random.Next(SIZE);
                // 値の重複防止
                if(data[m, n] == 0)
                {
                    // 値の代入
                    data[m, n] = num;
                    num++;
                }
            }

            // 結果の表示
            for(int i = 0; i < data.GetLength(0); i++)
            {
                // 値の表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0, 2:d}|", data[i, j]);
                }
                Console.WriteLine();
                // 線の表示
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }


        }
    }
}
