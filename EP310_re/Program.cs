using System;

// 5*5の二次元配列に置いて、乱数で発生させた計25の「場所に」1から順に25の値までを配置し、内容を表示するプログラム
// 値を表示する場所,代入する値は重複しないこと
// 復習1回目
namespace EP310_re
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5*5の二次元配列のインスタンス生成
            const int SIZE = 5;
            int[,] data = new int[SIZE, SIZE];
            // 二次元配列の初期化
            for(int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = 0;
                }
            }

            //　二次元配列に要素が0であるものがなくなるまで下記の処理を繰り返す
            Random random = new Random();
            int count = SIZE * SIZE;
            // 代入する値の初期化
            int num = 1;
            while( count > 0)
            {
                // 代入する位置の変数
                int m = random.Next(SIZE);
                int n = random.Next(SIZE);

                if( data[m, n] == 0)
                {
                    data[m, n ] = num;
                    num++;
                    count--;
                }
            }

            // 結果の表示
            for(int i = 0; i < data.GetLength(0); i++)
            {
                for( int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0, 2:d}|", data[i, j]);
                }
                Console.WriteLine();
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
        }
    }
}
